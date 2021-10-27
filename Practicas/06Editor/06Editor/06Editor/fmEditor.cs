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

        private void tamanyoEstado() {
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

            foreach (FontFamily misFuentes in FontFamily.Families) {
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
            stEstadoEditor.Items[3].Text = fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
            stEstadoEditor.Items[4].Text = fecha.Hour + ":" + fecha.Minute + ":" + fecha.Second;
        }

        private void itNuevo_Click(object sender, EventArgs e)
        {
            stEstadoEditor.Items[0].Text = "Generando un documento nuevo, guardando el anterior si procede.";
            if (rtbEditor.Modified) {
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
    }
}
