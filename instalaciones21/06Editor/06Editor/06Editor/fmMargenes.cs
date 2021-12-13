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
    public partial class fmMargenes : Form
    {
        public fmMargenes()
        {
            InitializeComponent();
        }

        private void cbIzquierdo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIzquierdo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
