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
    public partial class fmDatos : Form
    {
        fmEditor ventanaEditor;
        public fmDatos()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbDato_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            ventanaEditor = new fmEditor();
            int linea = Convert.ToInt32(tbDato.Text);
            if ((linea < 0) || (linea > ventanaEditor.rtbEditor.Text.Length))
            {
                linea = 0;
            }
            Close();
            ventanaEditor.rtbEditor.SelectionStart = linea;
            ventanaEditor.rtbEditor.Focus();
        }
    }
}
