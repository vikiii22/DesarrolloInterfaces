using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorGrafico
{
    public partial class EditorGrafico : Form
    {
        public EditorGrafico()
        {
            InitializeComponent();
        }

        private void EditorGrafico_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        bool pulsado, rellenando;
        Point[] puntos;
        int actualX, actualY, OrigenX, OrigenY;
        Pen lapiz, goma;
        SolidBrush relleno, colorTexto;
        HatchBrush estilorelleno;
        Bitmap mibmp;
        string accion; // Tipos Figura { Linea, Lapiz, Goma, Rectangulo, Circulo, Elipse, Texto, BorrarSeleccion }
        Font mifuente;

        private void EditorGrafico_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pulsado = true;
                OrigenX = e.X;
                OrigenY = e.Y;
                actualX = e.X;
                actualY = e.Y;
            }
        }

        private void agregarPunto(Point punto)
        {
            Point[] temp = new Point[puntos.Length + 1];
            puntos.CopyTo(temp, 0);
            puntos = temp;
            puntos[puntos.Length - 1] = punto;
        }

        private void EditorGrafico_MouseMove(object sender, MouseEventArgs e)
        {
            //tsl4.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
            if (pulsado)
            {
                if (accion == "Lapiz" || accion == "Goma")
                {
                    agregarPunto(new Point(e.X, e.Y));
                    Dibujar();
                }
                else
                {
                    Dibujar();
                    Color copiacolor = lapiz.Color;
                    if (pulsado && (lapiz.Color != pbEditorGrafico.BackColor))
                    {
                        lapiz.Color = Color.FromArgb(255 - lapiz.Color.R, 255 - lapiz.Color.G, 255 - lapiz.Color.B);// pbEdigrafi.BackColor;
                        Dibujar();
                    }
                    actualX = e.X;
                    actualY = e.Y;
                    lapiz.Color = copiacolor;
                    Dibujar();
                }
            }
        }

        string mitexto;
        Bitmap CuadradoBoton;

        private void Inicializar()
        {
            accion = "Lapiz";
            puntos = new Point[0];
            lapiz = new Pen(Color.Black, 1);
            colorTexto = new SolidBrush(Color.FromArgb(0, 0, 0));
            goma = new Pen(Color.White, 10);  //Color.White
            relleno = new SolidBrush(Color.FromArgb(255, 255, 255));//
            mibmp = new Bitmap(pbEditorGrafico.Width, pbEditorGrafico.Height);
            pbEditorGrafico.Image = mibmp;
            pbEditorGrafico.BackColor = Color.White;
            CrearCursorLapiz();
            rellenando = false;

            /*tsbLapiz.Checked = true;  //para que funcione esto hay que desmarcar todo antes
            itLapiz.Checked = true;
            itLinea5.Checked = true;
            itSinRelleno.Checked = true;

            tsbColorlapiz.Image = Properties.Resources.colorlapiz;
            tsbColorFondo.Image = Properties.Resources.colorfondo;
            tsbColorRelleno.Image = Properties.Resources.brocha;

            tsl2.Text = "Grosor Linea: " + lapiz.Width.ToString(); //label status strip
            tsl3.Text = "Grosor Goma: " + goma.Width.ToString();*/
        }

        private void Dibujar()
        {
            Graphics g1 = pbEditorGrafico.CreateGraphics();
            Graphics g2 = Graphics.FromImage(mibmp);
            Image mimage = null;
            if (accion != "BorrarSeleccion")
                mimage = pbEditorGrafico.Image;

            switch (accion)
            {
                case "Linea":
                    g1.DrawLine(lapiz, OrigenX, OrigenY, actualX, actualY);
                    break;
                case "Rectangulo":
                    if (rellenando)
                        if (itSolidoLinea.Checked)
                            g1.FillRectangle(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        else
                            g1.FillRectangle(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g1.DrawRectangle(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Lapiz":
                    if (puntos.Length > 1)
                    {
                        g1.DrawLines(lapiz, puntos);
                        g2.DrawLines(lapiz, puntos);
                    }
                    break;
                case "Goma":
                    if (puntos.Length > 1)
                    {
                        g1.DrawLines(goma, puntos);
                        g2.DrawLines(goma, puntos);
                    }
                    break;
                case "Circulo":
                    int radio = Convert.ToInt32(Math.Truncate(Math.Sqrt(Math.Pow((OrigenX - actualX), 2) + Math.Pow((OrigenY - actualY), 2))));
                    if (rellenando)
                        if (itSolidoLinea.Checked)
                            g1.FillEllipse(relleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                        else
                            g1.FillEllipse(estilorelleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    g1.DrawEllipse(lapiz, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    break;
                case "Elipse":
                    if (rellenando)
                        if (itSolidoLinea.Checked)
                            g1.FillEllipse(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        else
                            g1.FillEllipse(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g1.DrawEllipse(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Texto":
                    g1.DrawString(mitexto, mifuente, colorTexto, actualX, actualY - 10);
                    break;
                case "BorrarSeleccion":
                    SolidBrush rellenoborra = new SolidBrush(pbEditorGrafico.BackColor);  //Color.White); pbEdigrafi.BackColor;
                    g1.FillRectangle(rellenoborra, new Rectangle(OrigenX, OrigenY, Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    break;
            }
            g1.Dispose();
            g2.Dispose();
            if (accion != "BorrarSeleccion")
                pbEditorGrafico.Image = mimage;
        }

        private void Dibujar2()
        {
            Graphics g2 = Graphics.FromImage(mibmp);
            switch (accion)
            {
                case "Linea":
                    g2.DrawLine(lapiz, OrigenX, OrigenY, actualX, actualY);
                    break;
                case "Rectangulo":
                    if (rellenando)
                        if (itSolidoLinea.Checked)
                        {
                            g2.FillRectangle(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        }
                        else
                        {
                            g2.FillRectangle(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        }
                    g2.DrawRectangle(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Elipse":
                    if (rellenando)
                        if (itSolidoLinea.Checked)

                            g2.FillEllipse(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        else
                            g2.FillEllipse(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g2.DrawEllipse(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Circulo":
                    //teorema de pitagoras
                    int radio = Convert.ToInt32(Math.Truncate(Math.Sqrt(Math.Pow((OrigenX - actualX), 2) + Math.Pow((OrigenY - actualY), 2))));
                    if (rellenando)
                        if (itSolidoLinea.Checked)
                            g2.FillEllipse(relleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                        else
                            g2.FillEllipse(estilorelleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    g2.DrawEllipse(lapiz, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    break;
                case "Texto":
                    g2.DrawString(mitexto, mifuente, colorTexto, actualX, actualY - 10);
                    break;
                case "BorrarSeleccion":
                    SolidBrush rellenoborra = new SolidBrush(pbEditorGrafico.BackColor);// Color.White);
                    g2.FillRectangle(rellenoborra, new Rectangle(OrigenX, OrigenY, Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    break;
            }
            g2.Dispose();
        }

        public void CrearCursorLapiz()
        {
            IntPtr intPrCursor = Properties.Resources.lapizcortoNuevo1.GetHicon();
            pbEditorGrafico.Cursor = new Cursor(intPrCursor);
        }
    }
}
