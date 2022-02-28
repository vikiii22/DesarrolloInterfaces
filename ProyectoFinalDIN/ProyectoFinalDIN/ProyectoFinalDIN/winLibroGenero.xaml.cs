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
    /// Lógica de interacción para winLibroGenero.xaml
    /// </summary>
    public partial class winLibroGenero : Window
    {
        public winLibroGenero()
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
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM generos", conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            dgGenero.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void BtMostrarLibros_Click(object sender, RoutedEventArgs e)
        {
            if (dgGenero.SelectedIndex > -1)
            {
                DataView datos = (DataView)dgGenero.ItemsSource;
                string ced = datos.Table.Rows[dgGenero.SelectedIndex]["Codigo"].ToString();
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM libros where CodigoGenero=@micod", conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@micod", ced);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                dgLibros.ItemsSource = ds.Tables[0].DefaultView;
                string ced2 = datos.Table.Rows[dgGenero.SelectedIndex]["nombre"].ToString();
                lbNaranja.Content = "Total de Libros en Genero " + ced2 + ": " + dgLibros.Items.Count;
            }
            else
            {
                MessageBox.Show("Selecciona una libreria");
            }
        }
    }
}
