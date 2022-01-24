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

namespace Ejercicio3
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

        private void RbCochazo_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                imCoche.Source = new BitmapImage(new Uri("coche3.jpg", UriKind.Relative));
            }catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void RbAsequible_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                imCoche.Source = new BitmapImage(new Uri("coche2.jpg", UriKind.Relative));
            }catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void RbAceptable_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                imCoche.Source = new BitmapImage(new Uri("coche1.png", UriKind.Relative));
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void CbPeliculas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string movie = "";
            int index = cbPeliculas.SelectedIndex;
            switch (index)
            {
                case 0:
                    movie = "avenger";
                    break;
                case 1:
                    movie = "harry";
                    break;
                case 2:
                    movie = "spidy";
                    break;
            }

            try
            {
                imgPelis.Source = new BitmapImage(new Uri(movie + ".jpg", UriKind.Relative));
            }catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
