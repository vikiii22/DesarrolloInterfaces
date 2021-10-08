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
    public partial class fmEdicion : Form
    {
        fmIntroDatos ventanaDatos = new fmIntroDatos();
        public fmEdicion()
        {
            InitializeComponent();
        }

        private void tbEuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btCambiar.PerformClick();
                //btCambiar.Focus();
            }
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
                case ',':
                    break;
                default:
                    e.KeyChar = (char)0;
                    break;
            }
        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            Single total, formatea;

            try
            {
                if (Convert.ToSingle(tbPesetas.Text) > 0)
                {
                    formatea = Convert.ToSingle(tbPesetas.Text);
                    total = Convert.ToSingle(tbPesetas.Text) / 166.386f; //La f es un float
                    tbEuros.Text = total.ToString("#,###,##0.00");
                    tbPesetas.Text = formatea.ToString("#,###,###,##0");
                }
                else
                {
                    formatea = Convert.ToSingle(tbEuros.Text);
                    total = Convert.ToSingle(tbEuros.Text) * 166.386f;
                    tbPesetas.Text = total.ToString("#,###,###,##0");
                    tbEuros.Text = formatea.ToString("#,###,##0.00");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tbEuros_Click(object sender, EventArgs e)
        {
            tbEuros.Text = "0";
            tbPesetas.Text = "0";

            TextBox miTextBox = (TextBox)sender;
            miTextBox.SelectAll();
        }

        private void tbEuros_TextChanged(object sender, EventArgs e)
        {
            btCambiar.Enabled = true;
        }

        private void btIntDatos_Click(object sender, EventArgs e)
        {
            //ventanaDatos = new fmIntroDatos();
            //ventanaDatos.ShowDialog();
            //ventanaDatos.Dispose();
            ventanaDatos.tbNombre = tbNombrePrincipal;
            tbNombrePrincipal.Text = "";

            if (ventanaDatos.ShowDialog() == DialogResult.OK)
            {
                pnDatos.Visible = true;
                lbNombrePrincipal.Text = ventanaDatos.tbNombreMostra.Text;
                laDireccion.Text = ventanaDatos.tbDireccion.Text;
                laLocalidad.Text = ventanaDatos.tbLocalidad.Text;
                laTelefono.Text = ventanaDatos.tbTelefono.Text;
                laEmail.Text = ventanaDatos.tbEmail.Text;
                laCodigoPostal.Text = ventanaDatos.tbCodigoPostal.Text;
                laDNI.Text = ventanaDatos.tbDni.Text;
                //tbNombrePrincipal.Text = ventanaDatos.tbNombreMostra.Text;
            }
            else
            {
                pnDatos.Visible = false;
            }
        }

        private void pnDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
