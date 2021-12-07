using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorGrafico
{
    public partial class EditorGrafico : Form
    {
        fmTexto ventanaTexto=new fmTexto();
        fmTamanyo ventanaTamanyo = new fmTamanyo();
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
            fmTexto ventanaTexto;
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

        private void itTamanyoDibujo_Click(object sender, EventArgs e)
        {
            ventanaTamanyo = new fmTamanyo();
            ventanaTamanyo.Text = "Tamaño de Dibujo en Pixeles";
            ventanaTamanyo.lbIz.Text = "Ancho";
            ventanaTamanyo.lbDer.Text = "Alto";
            ventanaTamanyo.tbIzq.Text = Convert.ToString(pbEditorGrafico.Width);
            ventanaTamanyo.tbDer.Text = Convert.ToString(pbEditorGrafico.Height);
            if (ventanaTamanyo.ShowDialog() == DialogResult.OK)
            {
                pbEditorGrafico.Width = int.Parse(ventanaTamanyo.tbIzq.Text);
                pbEditorGrafico.Height = int.Parse(ventanaTamanyo.tbDer.Text);
                Bitmap fondo = new Bitmap(pbEditorGrafico.Width, pbEditorGrafico.Height);
                Unir(fondo);
            }
            tsl1.Text = "Tamaño del dibujo: " + Convert.ToString(pbEditorGrafico.Width + " X " + Convert.ToString(pbEditorGrafico.Height));
            ventanaTamanyo.Dispose();
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

        private void tsbTexto_Click(object sender, EventArgs e)
        {
            accion = "Texto";
            desmarca();
            tsbTexto.Checked = true;
            //itTexto.Checked = true;
            ventanaTexto.Location = new Point(Left + 30, Top + 170);
            if (ventanaTexto.ShowDialog() == DialogResult.OK)
            {
                mifuente = ventanaTexto.miFuente;
                colorTexto.Color = ventanaTexto.colortexto.Color;
                mitexto = ventanaTexto.tbTexto.Text;
            }
        }

        private void itAbrir_Click(object sender, EventArgs e)
        {
            dlgAbrirDibujo.FileName = Text;
            if(dlgAbrirDibujo.ShowDialog()==DialogResult.OK && dlgAbrirDibujo.FileName.Length > 0)
            {
                Inicializar();
                Graphics g2 = Graphics.FromImage(mibmp);
                pbEditorGrafico.Image = Image.FromFile(dlgAbrirDibujo.FileName);

                g2.DrawImage(pbEditorGrafico.Image, new Point(0, 0));
                Text = dlgAbrirDibujo.FileName;
                g2.Dispose();
            }
        }

        private void Unir(Bitmap fondo)
        {
            Graphics g = Graphics.FromImage(fondo);
            g.DrawImage(mibmp, 0, 0);
            mibmp = new Bitmap(fondo);
            g.Dispose();
            fondo.Dispose();
        }

        private void itGuardar_Click(object sender, EventArgs e)
        {
            dlgGuardar.FileName = Text;
            if (dlgGuardar.ShowDialog() == DialogResult.OK && dlgGuardar.FileName.Length > 0)
            {
                Bitmap fondo = new Bitmap(mibmp.Width, mibmp.Height);
                Graphics g = Graphics.FromImage(fondo);
                g.FillRectangle(new SolidBrush(pbEditorGrafico.BackColor), 0, 0, mibmp.Width, mibmp.Height);
                g.Dispose();
                Unir(fondo);
                fondo.Dispose();

                if (dlgAbrirDibujo.FilterIndex == 1)
                {
                    mibmp.Save(dlgGuardar.FileName, ImageFormat.Bmp);
                }
                else
                {
                    mibmp.Save(dlgGuardar.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void itLinea1_Click(object sender, EventArgs e)
        {
            desmarcaMenu(itTipoLinea.DropDownItems);
            ToolStripMenuItem elemento = sender as ToolStripMenuItem;
            int miTag = Convert.ToInt32(elemento.Tag);
            elemento.Checked = true;
            switch (miTag)
            {
                case 1:
                    lapiz.DashStyle = DashStyle.Dash;
                    break;
                case 2:
                    lapiz.DashStyle = DashStyle.DashDot;
                    break;
                case 3:
                    lapiz.DashStyle = DashStyle.Dot;
                    break;
                case 4:
                    lapiz.DashStyle = DashStyle.DashDotDot;
                    break;
                case 5:
                    lapiz.DashStyle = DashStyle.Solid;
                    break;
            }
        }

        private void itRelleno1_Click(object sender, EventArgs e)
        {
            desmarcaMenu(itTipoRelleno.DropDownItems);
            rellenando = true;
            ToolStripMenuItem elemento = sender as ToolStripMenuItem;
            int miTag = Convert.ToInt32(elemento.Tag);
            elemento.Checked = true;
            switch (miTag)
            {
                case 1:
                    estilorelleno = new HatchBrush(HatchStyle.Vertical, lapiz.Color, relleno.Color);
                    break;
                case 2:
                    estilorelleno = new HatchBrush(HatchStyle.Cross, lapiz.Color, relleno.Color);
                    break;
                case 3:
                    estilorelleno = new HatchBrush(HatchStyle.Horizontal, lapiz.Color, relleno.Color);
                    break;
                case 4:
                    estilorelleno = new HatchBrush(HatchStyle.ForwardDiagonal, lapiz.Color, relleno.Color);
                    break;
                case 5:
                    estilorelleno = new HatchBrush(HatchStyle.ZigZag, lapiz.Color, relleno.Color);
                    break;
                case 6:
                    estilorelleno = new HatchBrush(HatchStyle.Plaid, lapiz.Color, relleno.Color);
                    break;
                case 7:
                    estilorelleno = new HatchBrush(HatchStyle.Percent20, lapiz.Color, relleno.Color);
                    break;
                case 8:
                    rellenando = false;
                    relleno = new SolidBrush(Color.FromArgb(255, 255, 255));
                    tsbColorRelleno.Image = Properties.Resources.brocha;
                    break;
            }
        }

        private void itGrosorLineaGoma_Click(object sender, EventArgs e)
        {
            ventanaTamanyo = new fmTamanyo();
            ventanaTamanyo.Text = "Grosor de Línea y Goma en puntos";
            ventanaTamanyo.lbIz.Text = "Grosor Línea";
            ventanaTamanyo.lbDer.Text = "Grosor Goma";

            ventanaTamanyo.tbIzq.Text = Convert.ToString(lapiz.Width);
            ventanaTamanyo.tbDer.Text = Convert.ToString(goma.Width);
            Single copia = goma.Width;
            if (ventanaTamanyo.ShowDialog() == DialogResult.OK)
            {
                lapiz.Width = int.Parse(ventanaTamanyo.tbIzq.Text);
                goma.Width = int.Parse(ventanaTamanyo.tbDer.Text);
                if (!tsbGoma.Checked && copia != goma.Width)
                {
                    MessageBox.Show("Los cambios de grosor no se aplicarán hasta que elijas goma");
                }
            }
            tsl2.Text = "Grosor Línea: " + lapiz.Width.ToString();
            tsl3.Text = "Grosor goma: " + goma.Width.ToString();
        }

        private void itColorRelleno_Click(object sender, EventArgs e)
        {
            if (!rellenando)
            {
                MessageBox.Show("Elige tipo relleno en Estilo");
            }
            dlgColores.Color = relleno.Color;
            if (dlgColores.ShowDialog() == DialogResult.OK)
            {
                CreaCuadroBoton();
                tsbColorRelleno.Image = CuadradoBoton;
                relleno.Color = dlgColores.Color;
                if(rellenando && !itSolido.Checked)
                {
                    itVerticales.PerformClick();
                }
            }
        }

        public void CreaCuadroBoton()
        {
            Bitmap btemp = new Bitmap(15, 15);
            Graphics gtemp = Graphics.FromImage(btemp);
            gtemp.FillRectangle(new SolidBrush(dlgColores.Color), 0, 0, 16, 16);
            CuadradoBoton = new Bitmap(btemp);
            gtemp.Dispose();
            btemp.Dispose();
        }

        private void tsbColorLapiz_Click(object sender, EventArgs e)
        {
            dlgColores.Color = lapiz.Color;
            if (dlgColores.ShowDialog() == DialogResult.OK)
            {
                CreaCuadroBoton();
                tsbColorLapiz.Image = CuadradoBoton;
                lapiz.Color = dlgColores.Color;
            }
        }

        private void tsbColorDeFondo_Click(object sender, EventArgs e)
        {
            dlgColores.Color = lapiz.Color;
            if (dlgColores.ShowDialog() == DialogResult.OK)
            {
                CreaCuadroBoton();
                tsbColorDeFondo.Image = CuadradoBoton;
                pbEditorGrafico.BackColor = dlgColores.Color;
                goma = new Pen(pbEditorGrafico.BackColor, 10);
            }
        }

        private void itG1_Click(object sender, EventArgs e)
        {
            if(lapiz.Width>0 && lapiz.Width <7 && sender is ToolStripMenuItem)
            {
                ToolStripMenuItem elemento = sender as ToolStripMenuItem;
                //elemento.Checked = true;
                lapiz.Width = Convert.ToSingle(elemento.Tag);
                tsl2.Text = "Grosor Línea: " + lapiz.Width.ToString();
            }
        }

        private void tsbGrosor_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem miGrosor in tsbGrosor.DropDownItems)
            {
                if (Convert.ToSingle(miGrosor.Tag) == lapiz.Width)
                {
                    miGrosor.Checked = true;
                }
                else
                {
                    miGrosor.Checked = false;
                }
            }
        }

        private void tsbRectangulo_Click(object sender, EventArgs e)
        {
            //Repetir en cada acción
            accion = "Rectangulo";
            CrearCursorLapiz();
            desmarca();
            tsbRectangulo.Checked = true;
            //itSolidoLinea.Checked = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
