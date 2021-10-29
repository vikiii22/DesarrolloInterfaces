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
            dlgAbrir.ShowDialog();


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
        string[] linea;
        int totalLineasImpresas;

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
            if(rtbEditor.SelectionLength > 0)
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
            ventanaDatos.lbTipo.Text = "Num de línea";
            ventanaDatos.lbDato.Text = "Número de línea";
            

            ventanaDatos.ShowDialog();
        }
    }
}
