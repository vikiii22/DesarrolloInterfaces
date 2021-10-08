using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdicionDatos
{
    public partial class fmIntroDatos : Form
    {
        public TextBox tbNombre;
        public bool validacif(string cif)
        {
            int Suma = 0, Control; byte n; bool Resulta = false;
            if (cif.Length == 9)
            {  //sumar las cifras pares
                Suma = Convert.ToInt32(Convert.ToString(cif[2])) +
                Convert.ToInt32(Convert.ToString(cif[4])) + Convert.ToInt32(Convert.ToString(cif[6]));

                for (n = 0; n <= 3; n++)
                {//suma los impares
                    string impares = Convert.ToString(Convert.ToInt32(Convert.ToString(cif[n * 2 + 1])) * 2);
                    Suma = Suma + Convert.ToInt32(Convert.ToString(impares[0]));
                    if (impares.Length > 1)
                        Suma = Suma + Convert.ToInt32(Convert.ToString(impares[1]));
                }
                Control = 10 - (Suma % 10);/////////////////////////////////////
                string primercar = Convert.ToString(cif[0]);
                if ((primercar.IndexOf("X") >= 0) || (primercar.IndexOf("P") >= 0))
                {   //Control tipo letra
                    Resulta = (cif[8] == (char)(64 + Control));
                }
                else
                {   //Control tipo número
                    if (Control == 10) Control = 0;
                    Resulta = (Convert.ToString(cif[8])) == Convert.ToString(Control);
                }
            }//DEL IF
            return Resulta;
        } //fin de la funcion

        public bool calculaletranif(int dni, char letra)
        {
            char letracorrecta;
            int resto; // resto de la funcion para saber la letra en la cadena
            string letras = "TRWAGMYFPDXBNJZSQUHLCKE";
            resto = dni % 23;
            letracorrecta = letras[resto]; // esto es lo que devuelve la funcion
            if (letracorrecta == letra)
                return true;
            else
                return false;
        }

        public fmIntroDatos()
        {
            InitializeComponent();
        }

        private void tbCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)8:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    break;
                default:
                    e.KeyChar = (char)0;
                    break;
            }
        }

        private void fmIntroDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (ActiveControl is TextBox)
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void fmIntroDatos_Load(object sender, EventArgs e)
        {
            foreach (Control miControl in Controls)
            {
                if (miControl is TextBox)
                {
                    miControl.Text = "";
                }
            }
            //tbNombre.Focus();
        }

        private void fmIntroDatos_Shown(object sender, EventArgs e)
        {
            tbNombreMostra.Focus();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == "") return;
            String[] postArroba = tbEmail.Text.Split('@');
            if ((tbEmail.Text.IndexOf('@') < 0) || (tbEmail.Text.IndexOf('.') < 0))
            {
                try
                {
                    if (postArroba[1].IndexOf('.') < 0)
                    {
                        MessageBox.Show("Email invalido");
                        tbEmail.ForeColor = Color.Red;
                        tbEmail.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Email invalido");
                    tbEmail.ForeColor = Color.Red;
                    tbEmail.Focus();
                }
            }
        }

        private void tbContrasenya_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbContrasenya2_Validating(object sender, CancelEventArgs e)
        {
            if (tbContrasenya2.Text == "")
            {
                tbContrasenya.Text = "";
                return;
            }
            if (tbContrasenya.Text != tbContrasenya2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                tbContrasenya2.Focus();
            }
        }
        bool dniValido = true;
        private void tbDni_TextChanged(object sender, EventArgs e)
        {
            dniValido = true;
            String dni;
            char letra;
            char digi;
            bool esNumero = true;
            if (tbDni.Text == "") return;
            digi = (char)tbDni.Text[0];
            switch (digi)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    break;
                default:
                    esNumero = false;
                    break;
            }
            if ((tbDni.Text.Length == 9) && (esNumero))
            {
                letra = tbDni.Text[8];
                dni = tbDni.Text.Substring(0, 8);
                if (!calculaletranif(Convert.ToInt32(dni), letra))
                {
                    MessageBox.Show(letra + " Letra mal");
                    dniValido = false;
                    tbDni.Focus();
                    tbDni.Text = "";
                }
            }
            else
            {
                if ((tbDni.Text.Length == 9) && (!esNumero))
                {
                    if (!validacif(tbDni.Text))
                    {
                        MessageBox.Show("CIF no válido");
                        dniValido = false;
                        tbDni.Focus();
                        tbDni.Text = "";
                    }
                }
            }
        }

        private void tbDni_Validating(object sender, CancelEventArgs e)
        {
            if ((tbDni.Text.Length < 9) && (tbDni.Text.Length > 0))
            {
                MessageBox.Show("Debe tener 9 carácteres para ser válido");
                tbDni.Focus();
            }
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((tbDni.Text.Length > 0) && (tbDni.Text.Length < 8))
            {
                switch (e.KeyChar)
                {
                    case (char)8:
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        break;
                    default:
                        e.KeyChar = (char)0;
                        break;
                }
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tbDni.Text == "")
            {
                MessageBox.Show("FALTA EL DNI");
                tbDni.Focus();
            }
            if (!dniValido)
            {
                MessageBox.Show("DNI inválido");
                tbDni.Focus();
            }
            if (tbNombreMostra.Text == "")
            {
                MessageBox.Show("FALTA EL NOMBRE");
                tbNombreMostra.Focus();
            }
            DialogResult = DialogResult.OK;
        }

        private void btMenuPrincipal_Click(object sender, EventArgs e)
        {
            tbNombre.Text = tbNombreMostra.Text;
        }
    }
}
