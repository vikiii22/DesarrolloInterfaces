using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Editor
{
    public partial class fmEditor : Form
    {
        FontStyle miEstilo = new FontStyle();
        string miFuente;
        float miTamanyo;
        Color miColor;

        string[] linea;
        int totalLineasImpresas;

        fmDatos ventanaDatos = new fmDatos();
        public fmEditor()
        {
            InitializeComponent();

            Application.Idle += AplicacionOciosa;
        }

        private void AplicacionOciosa(object sender, EventArgs e)
        {
            int linea = rtbEditor.GetLineFromCharIndex(rtbEditor.SelectionStart);
            int columna = rtbEditor.SelectionStart - rtbEditor.GetFirstCharIndexOfCurrentLine();
            stEstadoEditor.Items[1].Text = "Lin." + Convert.ToString(linea) + "    Col." + Convert.ToString(columna);
            stEstadoEditor.Items[2].Text = "Car. " + Convert.ToString(rtbEditor.SelectionStart);


            //bool haySeleccion = rtbEditor.SelectionStart;
        }

        private void tamanyoEstado()
        {
            stEstadoEditor.Items[0].Width = Width - 350;
            stEstadoEditor.Items[1].Width = 100;
            stEstadoEditor.Items[2].Width = 60;
            stEstadoEditor.Items[3].Width = 70;
            stEstadoEditor.Items[4].Width = 90;

        }

        private void fmEditor_Resize(object sender, EventArgs e)
        {
            tamanyoEstado();
        }

        private void fmEditor_Load(object sender, EventArgs e)
        {
            tamanyoEstado();

            foreach (FontFamily misFuentes in FontFamily.Families)
            {
                cbFuentes.Items.Add(misFuentes.Name);
            }

            Text = "Documento1";

            rtbEditor.ClearUndo();
            rtbEditor.Focus();

            itQuitarFormato.PerformClick();
            rtbEditor.Modified = false;
        }

        private void timeEditor_Tick(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            //stEstadoEditor.Items[3].Text = fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
            //stEstadoEditor.Items[4].Text = fecha.Hour + ":" + fecha.Minute + ":" + fecha.Second;
            stEstadoEditor.Items[3].Text = fecha.ToString("dd/MM/yyyy");
            stEstadoEditor.Items[4].Text = fecha.ToString("HH:mm:ss");
        }

        private void itNuevo_Click(object sender, EventArgs e)
        {
            stEstadoEditor.Items[0].Text = "Generando un documento nuevo, guardando el anterior si procede.";
            if (rtbEditor.Modified)
            {
                DialogResult resultado = MessageBox.Show("Hay cambios pendientes de guardar. Guardas?", "Guardar cambios", MessageBoxButtons.YesNoCancel);

                switch (resultado)
                {
                    case DialogResult.Yes:
                        itGuardar.PerformClick();
                        break;
                    case DialogResult.Cancel:
                        rtbEditor.Focus();
                        stEstadoEditor.Items[0].Text = "";
                        return;
                }
            }
            rtbEditor.Clear();
            Text = "Documento1";
            itQuitarFormato.PerformClick();
            rtbEditor.Modified = false;
            stEstadoEditor.Items[0].Text = "";
        }

        private void itAbrir_Click(object sender, EventArgs e)
        {
            //dlgAbrir.ShowDialog();
            stEstadoEditor.Items[0].Text = "Abriendo archivo de diferentes formatos";
            if (rtbEditor.Modified)
            {
                DialogResult resultado = MessageBox.Show("Hay cambios pendientes de guardar, guardas?", "Guardar cambios", MessageBoxButtons.YesNoCancel);

                switch (resultado)
                {
                    case DialogResult.Yes:
                        itGuardar.PerformClick();
                        break;
                    case DialogResult.Cancel:
                        rtbEditor.Focus();
                        return;
                }
            }
            if (dlgAbrir.ShowDialog() == DialogResult.OK && dlgAbrir.FileName.Length > 0)
            {
                if (dlgAbrir.FilterIndex == 1)
                {
                    rtbEditor.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    rtbEditor.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.RichText);
                }
                Text = dlgAbrir.FileName;
                rtbEditor.Modified = false;
            }
            stEstadoEditor.Items[0].Text = "";
            rtbEditor.Focus();
            itQuitarFormato.PerformClick();
        }

        private void itGuardar_Click(object sender, EventArgs e)
        {
            if (Text == "Documento1")
            {
                itGuardarComo.PerformClick();
            }
            else
            {
                rtbEditor.SaveFile(Text);
                rtbEditor.Modified = false;
                rtbEditor.Focus();
            }
        }

        private void itGuardarComo_Click(object sender, EventArgs e)
        {
            dlgGuardar.FileName = Text;
            if (dlgGuardar.ShowDialog() == DialogResult.OK && dlgGuardar.FileName.Length > 0)
            {
                if (dlgGuardar.FilterIndex == 1)
                {
                    rtbEditor.SaveFile(dlgGuardar.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    rtbEditor.SaveFile(dlgGuardar.FileName, RichTextBoxStreamType.RichText);
                    Text = dlgGuardar.FileName;
                    rtbEditor.Modified = false;
                }
            }
        }


        private void itImprimir_Click(object sender, EventArgs e)
        {
            dlgImprimir.AllowSomePages = true;
            if (dlgImprimir.ShowDialog() == DialogResult.OK)
            {
                string texto = rtbEditor.Text;
                char[] seps = { '\n', '\r' };
                linea = texto.Split(seps);
                totalLineasImpresas = 0;
                printDocEditor.Print();
            }
        }

        private void printDocEditor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float lineasPorPag;
            float pos_Y;
            float margenIzq = e.MarginBounds.Left;
            float margenSup = e.MarginBounds.Top;

            // Calcular el número de líneas por página
            Font fuente = rtbEditor.Font;
            float altoFuente = fuente.GetHeight(e.Graphics);
            lineasPorPag = e.MarginBounds.Height / altoFuente;

            // Contador de las líneas impresas en una página
            int lineasImpresasPorPag = 0;
            // Imprimir cada una de las líneas
            while (totalLineasImpresas < linea.Length && lineasImpresasPorPag < lineasPorPag)
            {
                pos_Y = margenSup + (lineasImpresasPorPag * altoFuente);
                e.Graphics.DrawString(linea[totalLineasImpresas], fuente, Brushes.Black, margenIzq, pos_Y, new StringFormat());
                lineasImpresasPorPag += 1;
                totalLineasImpresas += 1;
            }

            // Si quedan líneas por imprimir, siguiente página
            if (totalLineasImpresas < linea.Length)
                e.HasMorePages = true; // se invoca de nuevo a ImprimirDoc_PrintPage
            else
                e.HasMorePages = false; // finaliza la impresión
        }

        private void itDeshacer_Click(object sender, EventArgs e)
        {
            if (rtbEditor.CanUndo)
            {
                rtbEditor.Undo();
            }
        }

        private void itRehacer_Click(object sender, EventArgs e)
        {
            if (rtbEditor.CanRedo)
            {
                rtbEditor.Redo();
            }
        }

        private void itCortar_Click(object sender, EventArgs e)
        {
            rtbEditor.Cut();
        }

        private void itPegar_Click(object sender, EventArgs e)
        {
            rtbEditor.Paste();
        }

        private void itCopiar_Click(object sender, EventArgs e)
        {
            rtbEditor.Copy();
        }

        private void itBorrar_Click(object sender, EventArgs e)
        {
            if (rtbEditor.SelectionLength > 0)
            {
                rtbEditor.SelectedText = "";
            }
        }

        private void itSeleccionarTodo_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
        }

        private void itIrA_Click(object sender, EventArgs e)
        {
            ventanaDatos.Text = "Para ir a una línea concreta";
            ventanaDatos.lbTipo.Text = "Número";
            ventanaDatos.lbDato.Text = "Número de línea";


            ventanaDatos.ShowDialog();
        }


        private void tsbCopiarFormato_Click(object sender, EventArgs e)
        {
            if (tsbCopiarFormato.Checked) stEstadoEditor.Items[0].Text = "Vas a copiar formato a la nueva ubicación";
            else stEstadoEditor.Items[0].Text = "";

            miEstilo = rtbEditor.SelectionFont.Style;
            miFuente = rtbEditor.SelectionFont.Name;
            miTamanyo = rtbEditor.SelectionFont.Size;
            miColor = rtbEditor.SelectionColor;
        }

        private void rtbEditor_MouseDown(object sender, MouseEventArgs e)
        {
            stEstadoEditor.Items[0].Text = "Comprobar el botón de copiar formatos";

            if (tsbCopiarFormato.Checked)
            {
                rtbEditor.SelectionFont = new Font(miFuente, miTamanyo, miEstilo);
                rtbEditor.SelectionColor = miColor;
            }
        }

        private void itQuitarFormato_Click(object sender, EventArgs e)
        {
            //itIzquierda.Checked = true;
            tsbIzquierda.Checked = true;
            tsbNegrita.Checked = false;
            tsbCursiva.Checked = false;
            tsbSubrayado.Checked = false;
            tsbTachado.Checked = false;

            tsbCopiarFormato.Checked = false;
            FontStyle estilo = new FontStyle();
            rtbEditor.SelectionFont = new Font("Arial", 10, estilo);
            rtbEditor.SelectionColor = Color.Black;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Left;

            cbFuentes.SelectedIndex = cbFuentes.Items.IndexOf("Arial");
            cbTamanyo.Text = "10";
            rtbEditor.BackColor = Color.White;

            rtbEditor.SelectionRightIndent = 0;
            rtbEditor.SelectionIndent = 0;
            rtbEditor.SelectionBullet = false;
            //itVietas.Checked = false;
        }

        private void cbTamanyo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbTamanyo_TextChanged(object sender, EventArgs e)
        {
            miEstilo = new FontStyle();
            miEstilo = rtbEditor.SelectionFont.Style;
            string fuente = rtbEditor.SelectionFont.Name;
            if (cbTamanyo.Text != "")
            {
                rtbEditor.SelectionFont = new Font(fuente, Convert.ToInt32(Math.Truncate(Convert.ToDecimal(cbTamanyo.Text))), miEstilo);
            }
        }

        private void tsbNegrita_Click(object sender, EventArgs e)
        {
            FontStyle negrita = new FontStyle();
            FontStyle cursiva = new FontStyle();
            FontStyle subrayado = new FontStyle();
            FontStyle tachado = new FontStyle();

            if (tsbNegrita.Checked)
            {
                negrita = FontStyle.Bold;
            }

            if (tsbCursiva.Checked)
            {
                cursiva = FontStyle.Italic;
            }

            if (tsbSubrayado.Checked)
            {
                subrayado = FontStyle.Underline;
            }

            if (tsbTachado.Checked)
            {
                tachado = FontStyle.Strikeout;
            }

            rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, negrita | cursiva | subrayado | tachado);
            rtbEditor.Focus();
        }

        void desmarca()
        {
            tsbIzquierda.Checked = false;
            tsbCentro.Checked = false;
            tsbDerecha.Checked = false;
            //itIzquierda.Checked = false;
            //itCentro.Checked = false;
            //itDerecha.Checked = false;
        }

        private void tsbIzquierda_Click(object sender, EventArgs e)
        {
            desmarca();
            tsbIzquierda.Checked = true;
            //itIzquierda.Checked = true;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tsbCentro_Click(object sender, EventArgs e)
        {
            desmarca();
            tsbCentro.Checked = true;
            //itCentro...
            rtbEditor.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tsbDerecha_Click(object sender, EventArgs e)
        {
            desmarca();
            tsbDerecha.Checked = true;
            //itDerecha...
            rtbEditor.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void cbFuentes_Click(object sender, EventArgs e)
        {

        }

        private void cbFuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FontStyle estilo = new FontStyle();
                estilo = rtbEditor.SelectionFont.Style;
                string fuente = cbFuentes.Text;
                float tamanyo = rtbEditor.SelectionFont.Size;
                rtbEditor.SelectionFont = new Font(fuente, tamanyo, estilo);
            }
            catch
            {
                return;
            }
            rtbEditor.Focus();
        }

        private void tsbColores_Click(object sender, EventArgs e)
        {
            dlgColor.Color = rtbEditor.SelectionColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.SelectionColor = dlgColor.Color;
                rtbEditor.Modified = true;
            }

        }

        private void itBarraDeEstado_Click(object sender, EventArgs e)
        {
            itBarraDeEstado.Checked = !itBarraDeEstado.Checked;
            tsmBarraDeEstado.Checked = !tsmBarraDeEstado.Checked;
            stEstadoEditor.Visible = itBarraDeEstado.Checked;
        }

        private void itBarraDeHerramientasEstándar_Click(object sender, EventArgs e)
        {
            itBarraDeHerramientasEstándar.Checked = !itBarraDeHerramientasEstándar.Checked;
            tsmBarraHerramEstandar.Checked = !tsmBarraHerramEstandar.Checked;
            tsBarraEstandar.Visible = itBarraDeHerramientasEstándar.Checked;
        }

        private void itBarraDeHerramientasFormato_Click(object sender, EventArgs e)
        {
            itBarraDeHerramientasFormato.Checked = !itBarraDeHerramientasFormato.Checked;
            tsmBarraDeHerramFormato.Checked = !tsmBarraDeHerramFormato.Checked;
            tsBarraFormato.Visible = itBarraDeHerramientasFormato.Checked;
        }

        private void itFuentes_Click(object sender, EventArgs e)
        {
            dlgFuente.Color = rtbEditor.SelectionColor;
            dlgFuente.Font = rtbEditor.SelectionFont;

            if (dlgFuente.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.SelectionFont = dlgFuente.Font;
                rtbEditor.SelectionColor = dlgFuente.Color;
                cbFuentes.SelectedIndex = cbFuentes.Items.IndexOf(rtbEditor.SelectionFont.Name);
                cbTamanyo.Text = Convert.ToString(Math.Truncate(Convert.ToDecimal(dlgFuente.Font.Size)));
                tsbNegrita.Checked = rtbEditor.SelectionFont.Bold;
                tsbSubrayado.Checked = rtbEditor.SelectionFont.Underline;
                tsbTachado.Checked = rtbEditor.SelectionFont.Strikeout;
                tsbCursiva.Checked = rtbEditor.SelectionFont.Italic;
                rtbEditor.Modified = true;
            }
        }

        private void rtbEditor_SelectionChanged(object sender, EventArgs e)
        {
            //Si se borra el texto modificado los valores de los controles no cambian.
            //Hay que ponerlos con los valores del parrafo actual
            try
            {
                cbTamanyo.Text = Convert.ToString(Math.Truncate(rtbEditor.SelectionFont.Size));
                //itVietas.Checked = rtbEditor.SelectionBullet;
                tsbNegrita.Checked = rtbEditor.SelectionFont.Bold;
                tsbSubrayado.Checked = rtbEditor.SelectionFont.Underline;
                tsbTachado.Checked = rtbEditor.SelectionFont.Strikeout;
                tsbCursiva.Checked = rtbEditor.SelectionFont.Italic;
                cbFuentes.SelectedIndex = cbFuentes.Items.IndexOf(rtbEditor.SelectionFont.Name);
            }
            catch
            {
                return;
            }
            tsbIzquierda.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Left;
            tsbDerecha.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Right;
            tsbCentro.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Center;
            itIzquierda.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Left;
            itDerecha.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Right;
            itCentro.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Center;
        }
    }
}
