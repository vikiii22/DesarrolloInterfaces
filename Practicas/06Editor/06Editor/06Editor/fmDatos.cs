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
         
        }
    }
}
