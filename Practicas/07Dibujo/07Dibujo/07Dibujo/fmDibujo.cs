using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            stGrafico.Items[0].Text = Convert.ToString(e.X) + "         " + Convert.ToString(e.Y);

            pbEditor.Image = (Image)mig;
            if ((e.Button == MouseButtons.Left) && (e.X < pbEditor.Width && e.Y < pbEditor.Height && e.Y >= 0 && e.X >= 0))
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
            imEditor.DrawLine(grosor, 0, 80, pbEditor.Height * 2, 80);
        }

        private void fmDibujo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void fmDibujo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add && grosor.Width < 100)
            {
                grosor.Width++;
            }

            if (e.KeyCode == Keys.Subtract && grosor.Width > 1)
            {
                grosor.Width--;
            }

            tsl2.Text = "Grosor línea: " + grosor.Width.ToString();
        }

        private void btDemo_Click(object sender, EventArgs e)
        {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);
            pbEditor.Image = mig;
            imEditor = Graphics.FromImage(mig);
            pbDemo.Visible = true;
            pbDemo.Value = 5;
            foreach(ToolStripButton miBoton in tsBarraBotones.Items)
            {
                miBoton.PerformClick();
                pbEditor.Update();
                Thread.Sleep(1000);
                pbDemo.PerformStep();
                tspDemostracion.PerformStep();
            }
            //pbEditor.BackColor = Color.FromArgb(255 - traRojo.Value, 255 - traVerde.Value, 255 - traAzul.Value);
            pbDemo.Value = 100;
            tspDemostracion.Value = 100;
        }

        private void tsmNuevo_Click(object sender, EventArgs e)
        {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);
            pbEditor.Image = mig;
            imEditor = Graphics.FromImage(mig);

            traRojo.Value=0;
            traVerde.Value = 0;
            traAzul.Value=0;

            rojo = verde = azul = 0;
            traRojo_Scroll(sender, e);

            grosor.Width = 1;
            pbEditor.BackColor = Color.White;
            pbDemo.Value = 0;
            pbDemo.Visible = false;
            tspDemostracion.Value = 0;
            ckRelleno.Checked = false;
            tsl2.Text = "Grosor Línea: 2";
        }

        private void tsmAbrir_Click(object sender, EventArgs e)
        {
            dlgAbrirDibujo.FileName = Text;
            if(dlgAbrirDibujo.ShowDialog()==DialogResult.OK && dlgAbrirDibujo.FileName.Length > 0)
            {
                pbEditor.Image = Image.FromFile(dlgAbrirDibujo.FileName);
                imEditor.DrawImage(pbEditor.Image, new Point(0, 0));
                Text = dlgAbrirDibujo.FileName;
                pbEditor.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void tsmGuardar_Click(object sender, EventArgs e)
        {
            dlgGuardarDibujo.FileName = Text;
            if(dlgGuardarDibujo.ShowDialog()==DialogResult.OK && dlgGuardarDibujo.FileName.Length > 0)
            {
                pbEditor.Image.Save(dlgGuardarDibujo.FileName);
                Text = dlgGuardarDibujo.FileName;
            }
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmDibujo_Load(object sender, EventArgs e)
        {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);

            imEditor = Graphics.FromImage(mig);

            grosor = new Pen(Color.Black, 2);

            Text = "Dibujo 1";

            tsl2.Text = "Grosor línea: " + grosor.Width.ToString();

        }

        private void btCambiaColor_Click(object sender, EventArgs e)
        {
            if (!pnColores.Enabled)
            {
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

        private void tsbCuadrado_Click(object sender, EventArgs e)
        {
            pbEditor.Image = (Image)mig;

            SolidBrush relleno;
            if (ckRelleno.Checked)
            {
                relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
                imEditor.FillRectangle(relleno, new Rectangle(150, 1, 50, 50));
            }
            else
            {
                relleno = new SolidBrush(Color.FromArgb(255, 255, 255));
                imEditor.FillRectangle(relleno, new Rectangle(150, 1, 50, 50));
            }
            imEditor.DrawRectangle(grosor, 150, 1, 50, 50);
            relleno.Dispose();
        }

        private void tsbRectangulo_Click(object sender, EventArgs e)
        {
            pbEditor.Image = (Image)mig;
            SolidBrush relleno;
            if (ckRelleno.Checked)
            {
                relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
                imEditor.FillRectangle(relleno, new Rectangle(60, 1, 80, 60));
            }
            else
            {
                relleno = new SolidBrush(Color.FromArgb(255, 255, 255));
                imEditor.FillRectangle(relleno, new Rectangle(60, 1, 80, 60));
            }
            relleno.Dispose();
            imEditor.DrawRectangle(grosor, 60, 1, 80, 60);
        }

        private void tsbArco_Click(object sender, EventArgs e)
        {
            pbEditor.Image = (Image)mig;
            imEditor.DrawArc(grosor, 0, 85, 150, 50, 90, 180);//360 en ultimo lugar dibuja un circulo
        }

        private void tsbCirculo_Click(object sender, EventArgs e)
        {

            pbEditor.Image = (Image)mig;
            SolidBrush relleno;
            if (ckRelleno.Checked)
            {
                relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
                imEditor.FillEllipse(relleno, new Rectangle(1, 1, 50, 50));
            }
            else
            {
                relleno = new SolidBrush(Color.FromArgb(255, 255, 255));
                imEditor.FillEllipse(relleno, new Rectangle(1, 1, 50, 50));

            }
            imEditor.DrawEllipse(grosor, new Rectangle(1, 1, 50, 50));

        }

        private void tsbElipse_Click(object sender, EventArgs e)
        {
            pbEditor.Image = mig;
            SolidBrush relleno;
            if (ckRelleno.Checked)
            {
                relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
                imEditor.FillEllipse(relleno, new Rectangle(210, 1, 60, 40));
            }
            else
            {
                relleno = new SolidBrush(Color.FromArgb(255, 255, 255));
                imEditor.FillEllipse(relleno, new Rectangle(210, 1, 60, 40));
            }
            imEditor.DrawEllipse(grosor, new Rectangle(210, 1, 60, 40));
        }

        private void tsbPoligono_Click(object sender, EventArgs e)
        {
            pbEditor.Image = (Image)mig;
            Point[] vertices = { new Point(100,126),
                            new Point(150,100),
                            new Point(200, 126),
                            new Point(200, 174),
                            new Point(150, 200),
                            new Point(100, 174)};//174
                                                 // new Point(100, 250)};//174
            imEditor.DrawPolygon(grosor, vertices);
        }

        private void tsbCurvaAbierta_Click(object sender, EventArgs e)
        {
            pbEditor.Image = mig;
            Point[] vertices = { new Point(250, 126),
                                new Point(300, 100),
                                new Point(350, 126),
                                new Point(400, 100) };
            imEditor.DrawCurve(grosor, vertices);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAcercaDe ventanaAcercaDe = new fmAcercaDe();
            ventanaAcercaDe.ShowDialog();
        }

        private void tsbCurvaCerrada_Click(object sender, EventArgs e)
        {
            pbEditor.Image = mig;
            Point[] vertices = { new Point(220, 206),
                                new Point(270, 180),
                                new Point(320, 206),
                                new Point(370, 180) };

            imEditor.DrawClosedCurve(grosor, vertices);

        }

        private void tbTexto_Click(object sender, EventArgs e)
        {
            pbEditor.Image = mig;
            Font fuente = new Font("Arial", 15);
            SolidBrush relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
            imEditor.DrawString("Texto Incrustado En Gráfico", fuente, relleno, 50, 220);
            relleno.Dispose();
        }
    }
}
