using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrastrarYSoltar
{
    public partial class fmPapelera : Form
    {
        public ListBox miLb1;
        public ListBox miLb2;
        public fmPapelera()
        {
            InitializeComponent();
        }

        public void pasarDatos(int i)
        {
            string elemento = lbPapelera.Items[i].ToString();
            string[] listBoxOrigen = elemento.Split('-');
            if (listBoxOrigen[1].ToString() == "1")
            {
                miLb1.Items.Add(listBoxOrigen[0]);
                //MessageBox.Show(lbPapelera.Items[i] + " del 1");
            }
            else
            {
                miLb2.Items.Add(listBoxOrigen[0]);
                //MessageBox.Show(lbPapelera.Items[i] + " del 2");
            }
        }

        private void btVaciarPapelera_Click(object sender, EventArgs e)
        {
            lbPapelera.Items.Clear();
        }

        private void btRestaurarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbPapelera.Items.Count; i++)
            {
                pasarDatos(i);
            }
            lbPapelera.Items.Clear();
        }

        private void btRestaurarSeleccionados_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < lbPapelera.Items.Count; i++)
            {
                if (lbPapelera.GetSelected(i))
                {
                    pasarDatos(i);
                }
            }
            i = 0;
            while (i < lbPapelera.Items.Count)
            {
                if (lbPapelera.GetSelected(i))
                {
                    lbPapelera.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
