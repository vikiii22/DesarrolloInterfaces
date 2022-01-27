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

namespace Ejercicio5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int nl = 0;
        private int nb = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtNuevoLabel_Click(object sender, RoutedEventArgs e)
        {
            btNuevoLabel.Style = (Style)this.Resources["btVerde"];

            Label l = new Label();
            nl++;
            l.Name = "label";
            l.Content = "Hola " + nl;

            lista.Children.Add(l);
        }

        private void BtNuevoBoton_Click(object sender, RoutedEventArgs e)
        {
            btNuevoBoton.Style = (Style)Resources["btVerde"];

            Button bt = new Button();

            nb++;
            bt.Name = "botón";
            bt.Content = "Botón " + nb;
            lista.Children.Add(bt);
            bt.Click += new RoutedEventHandler(evento_boton);
        }

        private void evento_boton(Object sender, RoutedEventArgs e)
        {
            string senderName;
            senderName = sender.ToString();

            MessageBox.Show("Hola soy el botón " + senderName);
        }

        private void BtBorrarElemento_Click(object sender, RoutedEventArgs e)
        {
            int i;

            if (lista.Children.Count > 0)
            {
                i = lista.Children.Count - 1;
                lista.Children.RemoveAt(i);
            }
        }
    }
}
