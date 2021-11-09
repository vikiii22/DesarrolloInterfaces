using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07Dibujo
{
    public partial class fmDibujo : Form
    {
        Bitmap mig;
        Graphics imEditor;
        int rojo, verde, azul = 0;
        Pen grosor;

        public fmDibujo()
        {
            InitializeComponent();
        }

        private void pbEditor_MouseMove(object sender, MouseEventArgs e)
        {
            pbEditor.Image = (Image)mig;
            if((e.Button==MouseButtons.Left)&&(e.X<pbEditor.Width && e.Y < pbEditor.Height && e.Y>=0 && e.X>=0))
            {
                ((Bitmap)pbEditor.Image).SetPixel(e.X, e.Y, Color.FromArgb(rojo, verde, azul));
            }
        }

        private void traRojo_Scroll(object sender, EventArgs e)
        {
            laPrueba.BackColor = Color.FromArgb(traRojo.Value, traVerde.Value, traAzul.Value);
            laPrueba.ForeColor = Color.FromArgb(255 - traRojo.Value, 255 - traVerde.Value, 255 - traAzul.Value);
        }

        private void btAplicar_Click(object sender, EventArgs e)
        {
            rojo = traRojo.Value;
            verde = traVerde.Value;
            azul = traAzul.Value;
            grosor.Color = Color.FromArgb(rojo, verde, azul);
        }

        private void tsbLinea_Click(object sender, EventArgs e)
        {
            pbEditor.Image = mig;
            imEditor.DrawLine(grosor, 0, 80, pbEditor.Height*2, 80);
        }

        private void fmDibujo_Load(object sender, EventArgs e)
        {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);

            imEditor = Graphics.FromImage(mig);

            grosor = new Pen(Color.Black, 2);

            Text = "Dibujo 1";
        }

        private void btCambiaColor_Click(object sender, EventArgs e)
        {
            if (!pnColores.Enabled) {
                btCambiaColor.Text = "No Probar Colores";
                pnColores.Enabled = true;
                btAplicar.Visible = true;
            }
            else
            {
                btAplicar.Visible = false;
                pnColores.Enabled = false;
                btCambiaColor.Text = "Prueba de colores";
            }
        }
    }
}
