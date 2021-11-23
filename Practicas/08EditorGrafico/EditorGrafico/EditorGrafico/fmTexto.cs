using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorGrafico
{
    public partial class fmTexto : Form
    {
        public Font miFuente;
        public SolidBrush colortexto;
        public fmTexto()
        {
            InitializeComponent();
        }

        private void btFuente_Click(object sender, EventArgs e)
        {
            colortexto = new SolidBrush(Color.Black);
            miFuente = new Font("Arial", 15);
            dlgFuente.Font = miFuente;
            if (dlgFuente.ShowDialog() == DialogResult.OK)
            {
                miFuente = dlgFuente.Font;
                colortexto.Color = dlgFuente.Color;
            }
        }
    }
}
