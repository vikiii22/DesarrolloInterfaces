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
    /// Lógica de interacción para winLibroEditorial.xaml
    /// </summary>
    public partial class winLibroEditorial : Window
    {
        public winLibroEditorial()
        {
            InitializeComponent();
        }

        public static OleDbConnection conexion = MainWindow.conexion;

        private void BtSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM editorial", conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            dgEditorial.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void BtMostrarLibros_Click(object sender, RoutedEventArgs e)
        {
            if (dgEditorial.SelectedIndex > -1)
            {
                DataView datos = (DataView)dgEditorial.ItemsSource;
                string ced = datos.Table.Rows[dgEditorial.SelectedIndex]["CodigoEditorial"].ToString();
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM libros where CodigoEditorial=@micod", conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@micod", ced);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                dgLibros.ItemsSource = ds.Tables[0].DefaultView;
                string ced2 = datos.Table.Rows[dgEditorial.SelectedIndex]["nombre"].ToString();
                lbNaranja.Content = "Total de Libros en Editorial " + ced2 + ": " + dgLibros.Items.Count;
            }
            else
            {
                MessageBox.Show("Selecciona una libreria");
            }
        }
    }
}
