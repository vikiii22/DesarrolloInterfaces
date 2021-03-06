using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formulario
{
    public partial class fmFormulario : Form
    {
        fmAcercaDe ventanaAcercaDe;

        public fmFormulario()
        {
            InitializeComponent();
            //Para que la ventanaNueva sea estática abría que crearla aquí.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //secuencia de creacion de eventos al inicio de la aplicacion
            /*
             Control.HandleCreated
             Control.BindingContextChanged
             Form.Load
             Control.VisibleChange
             Form.Activated
             Form.Shown

            Cuando se cierra una app, se generan los eventos de cierre del formulario principal en el orden indicado

            Form.Closing
            Form.FormClosing
            Form.Closed
            Form.FormClosed
            Form.Desactivated
             */
        }

        private void fmFormulario_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hola usuario");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // MessageBox.Show("Has hecho enter");
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Has hecho enter");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //labelMover.Font.Size++;

            float aumenta = labelMover.Font.Size;
            aumenta++;
            if (aumenta < 100)
            {
                labelTamanyo.Text = Convert.ToString(aumenta);
                btAumenta.Text = "Suma: " + Convert.ToString(aumenta);
                btDisminuye.Text = "Resta: " + Convert.ToString(aumenta);
                labelMover.Font = new Font("", aumenta, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void labelMover_Click(object sender, EventArgs e)
        {

        }

        private void btDisminuye_Click(object sender, EventArgs e)
        {
            float disminuye = labelMover.Font.Size;
            disminuye--;
            if (disminuye < 100 && disminuye > 0)
            {
                labelTamanyo.Text = Convert.ToString(disminuye);
                btAumenta.Text = "Suma: " + Convert.ToString(disminuye);
                btDisminuye.Text = "Resta: " + Convert.ToString(disminuye);
                labelMover.Font = new Font("", disminuye, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void btArriba_Click(object sender, EventArgs e)
        {
            labelMover.Top--;
            if (labelMover.Top <= -labelMover.Height)
            {
                labelMover.Top = Height - 44;
            }
            labelMover.Top = labelMover.Top - 2;
        }

        private void btAbajo_Click(object sender, EventArgs e)
        {
            labelMover.Top++;
            if (labelMover.Top >= Height - 40)
            {
                labelMover.Top = -40;
            }
            labelMover.Top = labelMover.Top + 2;
        }

        private void btDerecha_Click(object sender, EventArgs e)
        {
            //labelMover.Left++;
            if (labelMover.Left >= Width)
            {
                labelMover.Left = -labelMover.Width;
            }
            labelMover.Left = labelMover.Left + 2;
        }

        private void btIzquierda_Click(object sender, EventArgs e)
        {
            //labelMover.Left--;
            if (labelMover.Left <= -labelMover.Width)
            {
                labelMover.Left = Width;
            }
            labelMover.Left = labelMover.Left - 2;
        }

        private void btDelante_Click(object sender, EventArgs e)
        {
            labelMover.BringToFront();
        }

        private void btDetras_Click(object sender, EventArgs e)
        {
            labelMover.SendToBack();
        }

        private void btVisible_Click(object sender, EventArgs e)
        {
            if (panelBotones.Visible == true)
            {
                btVisible.Text = "Visible";
                panelBotones.Visible = false;
            }
            else
            {
                btVisible.Text = "No visible";
                panelBotones.Visible = true;
            }
            //panelBotones.Visible = !panelBotones.Visible;
        }

        private void btControlFor_Click(object sender, EventArgs e)
        {
            foreach (Control miControl in Controls)
            {
                if (miControl is Button)
                {
                    miControl.ForeColor = Color.Red;
                }
                MessageBox.Show(miControl.Name);
            }
            MessageBox.Show("Total controles en el formulario " + Controls.Count);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btControlPan(object sender, EventArgs e)
        {
            foreach (Control miControl in panelBotones.Controls)
            {
                if (miControl is Button)
                {
                    miControl.ForeColor = Color.Red;
                }
                MessageBox.Show(miControl.Name);
            }
            MessageBox.Show("Total controles en el Panel " + panelBotones.Controls.Count);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btUnoSender_Click(object sender, EventArgs e)
        {
            /*if (sender == btUnoSender) {
                MessageBox.Show("Es el uno");
            }*/

            Button miBoton = (Button)sender;
            MessageBox.Show("Es el botón " + miBoton.Text);
        }

        private void btAcerca_Click(object sender, EventArgs e)
        {
            ventanaAcercaDe = new fmAcercaDe();
            ventanaAcercaDe.ShowDialog();
            ventanaAcercaDe.Dispose();
        }

        /*private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        /**
         *Paso para crear proyecto multiformulario.
         *Incluir nuevo Form (menu proyecto/agregar windows form) y diseñarlo.
         * Definir el nuevo objeto ventana a nivel global para poder ser usado en diferentes funciones.
         * Construyo el objeto:
         *  -Si es estático en la función principal (initializecomponent) o en la definición.
         *  -Si es dinámico creo el objeto en el mismo evento que invoca al nuevo formulario
         * Muestro el nuevo formulario con el método showDialog si es modal o show si es flotante
         * Si es dinámico destruyo el objeto nueva ventana en el mismo evento donde se invoca.
         * Si es estático no se destruye hasta el final de la aplicación.
         */
    }
}
