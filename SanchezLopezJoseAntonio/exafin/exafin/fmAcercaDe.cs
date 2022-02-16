using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exafin
{
    public partial class fmAcercaDe : Form
    {
        public fmAcercaDe()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
