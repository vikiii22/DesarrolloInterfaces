using System;
using System.Collections.Generic;
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

namespace Ejercicio1
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

        private void BtTres_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Botón tres púlsado");
        }

        private void BtDos_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Keydown botón dos");
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Keydown grid");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Keydown Window");
        }

        private void BtDos_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("PreviewKeyDown bt2");
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("PreviewKeyDown grid");
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("PreviewKeyDown Window");
        }

        private void BtTotal_Click(object sender, RoutedEventArgs e)
        {
            foreach(Control controlGrid in gridEj1.Children)
            {
                MessageBox.Show(controlGrid.Name);
            }

            MessageBox.Show("Total de elementos en grid " + Convert.ToString(gridEj1.Children.Count));
        }

        private void BtSender1_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Name == "btSender1")
            {
                MessageBox.Show("Hola mundo click boton1");
            }
            else
            {
                MessageBox.Show("Hola mundo click boton2");
            }
        }
    }
}
