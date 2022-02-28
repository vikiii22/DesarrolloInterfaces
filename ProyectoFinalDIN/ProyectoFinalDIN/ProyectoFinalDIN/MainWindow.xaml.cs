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
    }
}
