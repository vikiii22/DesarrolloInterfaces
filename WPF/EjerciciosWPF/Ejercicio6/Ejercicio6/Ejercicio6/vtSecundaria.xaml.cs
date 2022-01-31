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
using System.Windows.Shapes;

namespace Ejercicio6
{
    /// <summary>
    /// Lógica de interacción para secundaria.xaml
    /// </summary>
    public partial class vtSecundaria : Window
    {

        private MainWindow wPadre;

        public vtSecundaria(MainWindow pPadre)
        {
            InitializeComponent();
            wPadre = pPadre;
        }

        private void BtAntigua_Click(object sender, RoutedEventArgs e)
        {
            wPadre.IsEnabled = true;
            wPadre.Show();
            Close();
        }

        private void BtNueva_Click(object sender, RoutedEventArgs e)
        {
            MainWindow miVentanaPrimaria = new MainWindow();
            wPadre.IsEnabled = true;
            miVentanaPrimaria.Show();
            Close();
        }
    }
}