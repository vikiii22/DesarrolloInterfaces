using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoFinalDIN
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static OleDbConnection conexion;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string conecta = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\datos\libros.mdb");
            conexion = new OleDbConnection(conecta);
            conexion.Open();
        }

        private void Btn_LibrosLibreria_Click(object sender, RoutedEventArgs e)
        {
            winLibroLibreria ventanaLibroLibreria = new winLibroLibreria();
            ventanaLibroLibreria.ShowDialog();
        }

        private void Btn_Libros_Click(object sender, RoutedEventArgs e)
        {
            winLibros ventanLibros = new winLibros();
            ventanLibros.ShowDialog();
        }

        private void Btn_LibrosGenero_Click(object sender, RoutedEventArgs e)
        {
            winLibroGenero ventanaLibrosGenero = new winLibroGenero();
            ventanaLibrosGenero.ShowDialog();
        }

        private void Btn_LibrosAutor_Click(object sender, RoutedEventArgs e)
        {
            winLibroAutor ventanaLibroAutor = new winLibroAutor();
            ventanaLibroAutor.ShowDialog();
        }

        private void Btn_LibrosEditorial_Click(object sender, RoutedEventArgs e)
        {
            winLibroEditorial ventanaLibroEditorial = new winLibroEditorial();
            ventanaLibroEditorial.ShowDialog();
        }

        private void Btn_Librerias_Click(object sender, RoutedEventArgs e)
        {
            winLibrerias ventanaLibrerias = new winLibrerias();
            ventanaLibrerias.ShowDialog();
        }
    }
}
