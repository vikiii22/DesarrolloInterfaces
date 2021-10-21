using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05MiniEditor
{
    public partial class fmEditorTextos : Form
    {
        public fmEditorTextos()
        {
            InitializeComponent();
        }

        private void cbNegrita_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle negrita = new FontStyle();
            FontStyle subrayado = new FontStyle();
            FontStyle cursiva = new FontStyle();
            FontStyle tachado = new FontStyle();

            if (cbNegrita.Checked)
            {
                negrita = FontStyle.Bold;
            }
            if (cbSubrayado.Checked)
            {
                subrayado = FontStyle.Underline;
            }
            if (cbCursiva.Checked)
            {
                cursiva = FontStyle.Italic;
            }
            if (cbTachado.Checked)
            {
                tachado = FontStyle.Strikeout;
            }
            rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, negrita | subrayado | cursiva | tachado);
            rtbEditor.Focus();
        }

        private void rbIzquierda_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle izquierda = new FontStyle();
            FontStyle derecha = new FontStyle();
            FontStyle centro = new FontStyle();

            if (rbIzquierda.Checked)
            {
                rtbEditor.SelectionAlignment = HorizontalAlignment.Left;
            }
            if (rbDerecha.Checked)
            {
                rtbEditor.SelectionAlignment = HorizontalAlignment.Right;
            }
            if (rbCentrada.Checked)
            {
                rtbEditor.SelectionAlignment = HorizontalAlignment.Center;
            }
            rtbEditor.Focus();
        }

        private void cbTamanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Poner código para solo números
        }

        private void cbTamanio_TextChanged(object sender, EventArgs e)
        {
            FontStyle estilo = new FontStyle();
            estilo = rtbEditor.SelectionFont.Style;
            string fuente = rtbEditor.SelectionFont.Name;
            if (cbTamanio.Text != "")
            {
                rtbEditor.SelectionFont = new Font(fuente, Convert.ToInt32(cbTamanio.Text), estilo);
            }
            //rtbEditor.Focus();
        }

        private void fmEditorTextos_Load(object sender, EventArgs e)
        {
            foreach (FontFamily misFuentes in FontFamily.Families)
            {
                cbFuente.Items.Add(misFuentes.Name);
            }

            cbFuente.Text = "Microsoft Sans Serif";

            cbTamanio.Text = "8";
        }

        private void cbFuente_TextChanged(object sender, EventArgs e)
        {
            FontStyle estilo = new FontStyle();
            estilo = rtbEditor.SelectionFont.Style;
            float tamanyo = rtbEditor.SelectionFont.Size;

            string fuente = cbFuente.Text;
            rtbEditor.SelectionFont = new Font(fuente, tamanyo, estilo);
        }
    }
}
