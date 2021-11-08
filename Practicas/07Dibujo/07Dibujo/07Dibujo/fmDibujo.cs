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
                ((Bitmap)pbEditor.Image).SetPixel(e.X, e.Y, Color.Black/*Color.FromArgb(rojo, verde, azul*/);
            }
        }

        private void fmDibujo_Load(object sender, EventArgs e)
        {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);

            imEditor = Graphics.FromImage(mig);
        }

        private void btCambiaColor_Click(object sender, EventArgs e)
        {
            if (!pnColores.Enabled) {
                btCambiaColor.Text = "No Probar Colores";
                pnColores.Enabled = true;
            }
            else
            {
                pnColores.Enabled = false;
                btCambiaColor.Text = "Prueba de colores";
            }
        }
    }
}
