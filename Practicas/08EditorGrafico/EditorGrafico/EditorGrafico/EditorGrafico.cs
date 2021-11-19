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
            tsl4.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
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

        private void pbEditorGrafico_MouseUp(object sender, MouseEventArgs e)
        {
            if (pulsado)
                Dibujar2();
            pulsado = false;
            //Aqui reinicializamos a puntos para que no se unan las lineas al volver a dibujar 
            puntos = new Point[0];
            //Marcamos como transparente  para que al cambiar de fondo no se vea lo que borramos 
            mibmp.MakeTransparent(pbEditorGrafico.BackColor);
            //ponemos la imagen dibujada como fondo  para que el trabajo de dibujar sea mas rapido. 
            pbEditorGrafico.Image = mibmp;
        }

        string mitexto;
        Bitmap CuadradoBoton;

        private void tsbLinea_Click(object sender, EventArgs e)
        {
            //Repetir en cada acción
            accion = "Linea";
            CrearCursorLapiz();
            desmarca();
            tsbLinea.Checked = true;
            //itSolidoLinea.Checked = true;
        }

        private void tsbLapiz_Click(object sender, EventArgs e)
        {
            accion = "Lapiz";
            CrearCursorLapiz();
            desmarca();
            tsbLapiz.Checked = true;
            //itLapiz.Checked = true;
        }

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

            tsbLapiz.Checked = true;  //para que funcione esto hay que desmarcar todo antes
            /*itLapiz.Checked = true;
            itLinea5.Checked = true;
            itSinRelleno.Checked = true;

            tsbColorlapiz.Image = Properties.Resources.colorlapiz;
            tsbColorFondo.Image = Properties.Resources.colorfondo;
            tsbColorRelleno.Image = Properties.Resources.brocha;*/

            tsl2.Text = "Grosor Linea: " + lapiz.Width.ToString(); //label status strip
            tsl3.Text = "Grosor Goma: " + goma.Width.ToString();
        }

        private void tsbGoma_Click(object sender, EventArgs e)
        {
            accion = "Goma";
            CrearCursorGoma();
            desmarca();
            tsbGoma.Checked = true;
            //itGoma.Checked = true;
        }

        private void tsbBorrarSeleccion_Click(object sender, EventArgs e)
        {
            accion = "BorrarSeleccion";
            CrearCursorGoma();
            desmarca();
            tsbBorrarSeleccion.Checked = true;
            //itBorrarSeleccion.Checked = true;
        }

        private void EditorGrafico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                if (accion == "Goma")
                {
                    if (goma.Width < 100)
                    {
                        goma.Width++;
                        CrearCursorGoma();
                    }
                }
                else
                {
                    if (lapiz.Width < 100)
                    {
                        lapiz.Width++;
                    }
                }
            }
            if (e.KeyCode == Keys.Subtract)
            {
                if (accion == "Goma")
                {
                    if (goma.Width > 10)
                    {
                        goma.Width--;
                        CrearCursorGoma();
                    }
                }
                else
                {
                    if (lapiz.Width > 1)
                    {
                        lapiz.Width--;
                    }
                }
            }
            tsl2.Text = "Grosor Línea: " + lapiz.Width.ToString();
            tsl3.Text = "Grosor Goma: " + goma.Width.ToString();
        }

        private void Dibujar()
        {
            Graphics g1 = pbEditorGrafico.CreateGraphics();
            Graphics g2 = Graphics.FromImage(mibmp);
            Image mimage = null;
            //if (accion != "BorrarSeleccion")
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
                    //SolidBrush rellenoborra = new SolidBrush(pbEditorGrafico.BackColor);  //Color.White); pbEdigrafi.BackColor;
                    Pen lapizBorra = new Pen(Color.Black, 1);
                    lapizBorra.DashStyle = DashStyle.Custom;
                    lapizBorra.DashPattern = new float[] { 8, 8 };

                    //g1.FillRectangle(rellenoborra, new Rectangle(OrigenX, OrigenY, Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g1.DrawRectangle(lapizBorra, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
            }
            g1.Dispose();
            g2.Dispose();
            //if (accion != "BorrarSeleccion")
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
                    g2.FillRectangle(rellenoborra, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    break;
            }
            g2.Dispose();
        }

        public void CrearCursorLapiz()
        {
            IntPtr intPrCursor = Properties.Resources.lapizcortoNuevo1.GetHicon();
            pbEditorGrafico.Cursor = new Cursor(intPrCursor);
        }

        private void desmarca()
        {
            foreach (ToolStripButton boton in tsLateral.Items)
            {
                boton.Checked = false;
            }
            tsbLapiz.Checked = false;
            tsbGoma.Checked = false;
            desmarcaMenu(itFiguras.DropDownItems);
            /*itGoma.Checked = false;
            itBorrarSeleccion.Checked = false;*/

        }

        private void desmarcaMenu(ToolStripItemCollection listaMenu)
        {
            foreach (ToolStripItem miItem in listaMenu)
            {
                ((ToolStripMenuItem)miItem).Checked = false;
            }
        }

        private void CrearCursorGoma()
        {
            int diametroG = Convert.ToInt32(goma.Width);
            Bitmap Goma = new Bitmap(diametroG, diametroG);

            Graphics gGoma = Graphics.FromImage(Goma);
            gGoma.FillRectangle(Brushes.Magenta, 0, 0, diametroG, diametroG);
            SolidBrush rellenoborra = new SolidBrush(pbEditorGrafico.BackColor);
            gGoma.FillEllipse(rellenoborra, 0, 0, diametroG - 1, diametroG - 1); //Brushes.White
            gGoma.DrawEllipse(new Pen(Color.Black, 1), 0, 0, diametroG - 1, diametroG - 1);
            Goma.MakeTransparent(Color.Magenta);
            gGoma.Dispose();
            IntPtr intprCursorGoma = Goma.GetHicon();
            pbEditorGrafico.Cursor = new Cursor(intprCursorGoma);
        }
    }
}
