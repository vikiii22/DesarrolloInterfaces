using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace proyectoFinal
{
    /// <summary>
    /// Lógica de interacción para winLibroLibreria.xaml
    /// </summary>
    public partial class winLibroLibreria : Window
    {
        public winLibroLibreria()
        {
            InitializeComponent();
        }


        private void cambiaventana(bool modo)
        { //cambiamos estilo de la ventana a edición o no según botones correspondientes
            lbLibros.IsEnabled = modo;
            uGridNuevoModificarEliminar.IsEnabled = modo;//UniformGrid botones indicados
            btGuardar.IsEnabled = !modo;
            btActualizar.IsEnabled = !modo;
            btCancelar.IsEnabled = !modo;
            texboxsololectura(modo);//otra función
        }

        private void texboxsololectura(bool modo)
        { //cambiamos modo de los textbox según estén edición o no 
            foreach (Control controlgrid in gridTexbox.Children)
            {
                if (controlgrid is ComboBox)
                {
                    ((ComboBox)controlgrid).IsReadOnly = modo;
                }

                if ((controlgrid is TextBox) && (controlgrid.Name == "tbTitulo" || controlgrid.Name == "tbISBN"
                    || controlgrid.Name == "tbObservaciones"))
                {
                    ((TextBox)controlgrid).IsReadOnly = modo;
                }
            }
        }

        private bool camposrequeridos()
        { //comprobamos si los datos obligatorios han sido introducidos
            if (tbFecha.Text == "")
            {
                MessageBox.Show("Falta fecha");
                tbFecha.Focus();
                return false;
            }

            foreach (Control controlgrid in gridTexbox.Children)
            {
                string[] requeridos = { "tbTitulo", "tbEditorial", "tbAutor", "tbGenero", "tbLibreria" };
                if ((controlgrid is TextBox) && (((TextBox)controlgrid).Text == ""))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (controlgrid.Name == requeridos[i]) //compruebo si es uno de los 5 texbox a comprobar
                        {
                            MessageBox.Show("Falta Dato " + controlgrid.Name.Substring(2));
                            controlgrid.Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void limpiartextbox()
        { //vaciamos combobox y textbox correspondientes
            foreach (Control controlgrid in gridTexbox.Children)
            {
                if (controlgrid is ComboBox)
                {
                    ((ComboBox)controlgrid).Text = "";
                }
                if (controlgrid is TextBox)
                {
                    ((TextBox)controlgrid).Clear();
                }
            }
            tbFecha.Text = "";
        }

        private void cargardatoslisbox()
        { //Llenamos listbox con el título desde tabla libros 
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM libros", MainWindow.conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            tabla = new DataTable();
            tabla = ds.Tables[0];
            lbLibros.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                filas = tabla.Rows[i];
                lbLibros.Items.Add(filas["titulo"].ToString());
            }
        }

        public void llenaCombo(string latabla)
        {  //llenamos combox correspondientes desde tabla  autor,editorial, etc
            String consulta = "SELECT nombre FROM " + latabla;

            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, MainWindow.conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            DataTable tabla = new DataTable();
            tabla = ds.Tables[0];

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                switch (latabla)
                {
                    case "librerias":
                        cbLibreria.Items.Add(tabla.Rows[i]["nombre"]);
                        break;
                    case "generos":
                        cbGenero.Items.Add(tabla.Rows[i]["nombre"]);
                        break;
                    case "autor":
                        cbAutor.Items.Add(tabla.Rows[i]["nombre"]);
                        break;
                    case "editorial":
                        cbEditorial.Items.Add(tabla.Rows[i]["nombre"]);
                        break;
                }

            }
        }

        string ponernombre(string latabla, string clave, string parametro)
        { //Desde textbox correspondiente pongo nombre en combobox autor, editorial, etc
            string sentenciasql = "SELECT nombre FROM " + latabla + " where " + clave + " = @micod";
            OleDbCommand comando = new OleDbCommand(sentenciasql, MainWindow.conexion);
            comando.Parameters.AddWithValue("@micod", parametro);
            OleDbDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                return lector["nombre"].ToString();
            }
            else
            {
                return "";
            }
        }

        public string poncodigo(string latabla, string elcodigo, string elitem)
        { //Desde combobox correspondiente pongo código en textbox autor,editorial,etc
            string sentenciasql = "SELECT " + elcodigo + " FROM " + latabla + " WHERE nombre = @micod";
            OleDbCommand comando5 = new OleDbCommand(sentenciasql, MainWindow.conexion);
            string mid = elitem;// cbLibreria.Items[cbLibreria.SelectedIndex].ToString();
            comando5.Parameters.AddWithValue("@midcod", mid);
            OleDbDataReader lector = comando5.ExecuteReader();
            if (lector.Read())
            {
                return lector[elcodigo].ToString();
            }
            else
            {
                return "";
            }
        }

        private void BtNuevo_Click(object sender, RoutedEventArgs e)
        {
            limpiartextbox();
            lbLibros.SelectedItem = null;
            cambiaventana(false);
            btActualizar.IsEnabled = false;
            string numFilas = "SELECT TOP 1 codigolibro FROM libros ORDER BY codigolibro DESC";
            OleDbCommand comando1 = new OleDbCommand(numFilas, MainWindow.conexion);
            int numFil = (int)comando1.ExecuteScalar();
            tbCodigo.Template = Convert.ToString(numFil + 1);
            //tbTitulo = Focus();
        }

        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            if (lbLibros.Items.Count > 0)
            {
                if (lbLibros.SelectedItem != null)
                {
                    cambiaventana(false);
                    btGuardar.IsEnabled = false;
                    //tbTitulo.Focus();
                }
                else
                {
                    MessageBox.Show("Tienes que seleccionar un libro de la lista para poder modificarlo.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Actualmente no hay nignun libro en la base de datos.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
