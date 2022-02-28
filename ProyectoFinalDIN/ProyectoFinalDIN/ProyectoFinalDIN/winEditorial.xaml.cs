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

namespace ProyectoFinalDIN
{
    /// <summary>
    /// Lógica de interacción para winEditorial.xaml
    /// </summary>
    public partial class winEditorial : Window
    {
        public winEditorial()
        {
            InitializeComponent();
        }

        DataTable tabla;
        DataRow filas;

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
            //dpFechaImpresion.Text = "";
        }

        private void cargardatoslisbox()
        { //Llenamos listbox con el título desde tabla libros 
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM editorial", MainWindow.conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            tabla = new DataTable();
            tabla = ds.Tables[0];
            lbLibros.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                filas = tabla.Rows[i];
                lbLibros.Items.Add(filas["nombre"].ToString());
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
            string numFilas = "SELECT TOP 1 codigoEditorial FROM editorial ORDER BY codigoEditorial DESC";
            OleDbCommand comando1 = new OleDbCommand(numFilas, MainWindow.conexion);
            int numFil = (int)comando1.ExecuteScalar();
            tbCodigo.Text = Convert.ToString(numFil + 1);
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

        private void CbAutor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, RoutedEventArgs e)
        {
            {
                if (lbLibros.Items.Count > 0)
                {
                    if (lbLibros.SelectedItem != null)
                    {
                        if (MessageBox.Show("¿Realmente desea eliminar el libro " + tbNombre.Text + " de la base de datos?",
                             "Confirmar Eliminación de Registro", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                        {
                            string borra = "DELETE FROM editorial WHERE codigoEditorial = @idborra";
                            OleDbCommand comandoborra = new OleDbCommand(borra, MainWindow.conexion);
                            comandoborra.Parameters.AddWithValue("@idborra", tbCodigo.Text);
                            try
                            {
                                comandoborra.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            MessageBox.Show("Datos borrados correctamente.");
                            lbLibros.Items.RemoveAt(lbLibros.SelectedIndex);
                            lbLibros.SelectedIndex = lbLibros.Items.Count - 1;
                            limpiartextbox();
                            tbCodigo.Clear();
                            cargardatoslisbox();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un libro a borrar.");
                        lbLibros.Focus();
                    }
                }
            }
        }

        private void BtSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (!camposrequeridos())
            {
                return;
            }
            Int32 mid = Convert.ToInt32(tbCodigo.Text);
            string modificar = "UPDATE editorial " + "SET Nombre = '" + tbNombre.Text + "', Direccion = '" + tbDireccion.Text + "', Poblacion = '" + tbPoblacion
                + "', Telefono =  '" + tbTelefono.Text + "', cif = '" + tbCif.Text + "' WHERE CodigoEditorial = @mid; ";
            //  MessageBox.Show(modificar);
            OleDbCommand comando2 = new OleDbCommand(modificar, MainWindow.conexion);
            comando2.Parameters.AddWithValue("@mid", mid);

            try
            {
                comando2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Datos modificados correctamente.");
            cargardatoslisbox();
            lbLibros.Focus();
            cambiaventana(true);
            limpiartextbox();
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            lbLibros.SelectedItem = null;
            limpiartextbox();
            tbCodigo.Clear();
            cambiaventana(true);
        }

        private void BtGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!camposrequeridos())
            {
                return;
            }

            String insertar = "INSERT INTO editorial(codigoEditorial, nombre, direccion, poblacion, telefono, cif)"
                 + "VALUES('" + tbCodigo.Text + "', '" + tbNombre.Text + "', '" + tbDireccion.Text + "', '" + tbPoblacion.Text
                 + "', '" + tbTelefono.Text + "', '" + tbCif.Text + "')";
            //     MessageBox.Show(insertar);
            OleDbCommand comando = new OleDbCommand(insertar, MainWindow.conexion);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            cargardatoslisbox();
            lbLibros.SelectedItem = lbLibros.Items.Count - 1;
            lbLibros.Focus();
            cambiaventana(true);
            limpiartextbox();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            limpiartextbox();
            //llenaCombo("librerias");
            cargardatoslisbox();
            cambiaventana(true);
        }

        private void LbLibros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbLibros.SelectedIndex > -1)
            {
                filas = tabla.Rows[lbLibros.SelectedIndex];

                tbCodigo.Text = filas["codigoEditorial"].ToString();
                tbNombre.Text = filas["nombre"].ToString();
                tbDireccion.Text = filas["direccion"].ToString();
                tbPoblacion.Text = filas["poblacion"].ToString();
                tbTelefono.Text = filas["telefono"].ToString();
                tbCif.Text = filas["cif"].ToString();
            }
        }
    }
}
