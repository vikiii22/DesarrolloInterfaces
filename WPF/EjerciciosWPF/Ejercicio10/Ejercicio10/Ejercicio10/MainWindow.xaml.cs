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

namespace Ejercicio10
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, RoutedEventArgs e)
        {
            /**
             * comprobar que todos los campos tengan datos
             * la contraseña requisito mínimo de 3 carácteres
             * la contraseña debe coincidir
             * los mensajes de error en el label inferior
             */

            if (tbNombre.Text == "")
            {
                lbInfo.Content = "Debes añadir un nombre";
                tbNombre.Focus();
            }
            else if (tbDNI.Text=="") {
                lbInfo.Content = "Debes añadir el DNI";
                tbDNI.Focus();
            }
            else if (tbUsuario.Text=="")
            {
                lbInfo.Content = "Debes añadir el Usuario";
                tbUsuario.Focus();
            }
            else if (pass.Password=="" || pass.Password.Length < 3)
            {
                lbInfo.Content = "Debes añadir una contraseña mayor a 3 carácteres";
                pass.Focus();
            }
            else if(pass.Password != pass2.Password)
            {
                lbInfo.Content = "Las contraseñas tienen que ser iguales";
                pass2.Focus();
            }
            else
            {
                Usuario nuevoUsuario = new Usuario(tbNombre.Text, tbDNI.Text, tbUsuario.Text, "");
                listaUsuarios.Add(nuevoUsuario);
                dgUsuarios.ItemsSource = null;
                dgUsuarios.ItemsSource = listaUsuarios;
                BorrarDatos();
            }
        }

        private void TbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            lbInfo.Content = "";
        }

        public void BorrarDatos()
        {
            tbNombre.Text = "";
            tbDNI.Text = "";
            tbUsuario.Text = "";
            pass.Password = "";
            pass2.Password = "";
        }
    }
}
