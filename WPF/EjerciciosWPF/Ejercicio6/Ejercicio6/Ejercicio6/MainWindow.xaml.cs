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

namespace Ejercicio6
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

        private void BtSecundariaOcultar_Click(object sender, RoutedEventArgs e)
        {
            vtSecundaria miventana = new vtSecundaria(this);
            miventana.Show();
            Hide();
        }

        private void BtSecundariaBloqueas_Click(object sender, RoutedEventArgs e)
        {
            vtSecundaria miventana = new vtSecundaria(this);
            IsEnabled = false;
            miventana.Show();
        }

        private void BtAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            winAcercaDe ventanaAcercaDe = new winAcercaDe();
            ventanaAcercaDe.ShowDialog();
        }
    }
}