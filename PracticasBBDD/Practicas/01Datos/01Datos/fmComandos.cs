using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Datos
{
    public partial class fmComandos : Form
    {
        public fmComandos()
        {
            InitializeComponent();
        }

        private void telefonosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telefonosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);

        }

        private void fmComandos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_telefonosDataSet.telefonos' Puede moverla o quitarla según sea necesario.
            this.telefonosTableAdapter.Fill(this.bd_telefonosDataSet.telefonos);
        }

        private void btPrimero_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveFirst();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MovePrevious();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveNext();
        }

        private void btUltimo_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveLast();
        }

        private void mostrarPosicion()
        {
            int iTotal = telefonosBindingSource.Count;
            int iPos;

            if (iTotal == 0) {
                laPosicion.Text = "0 de 0";
            }
            else
            {
                iPos = telefonosBindingSource.Position + 1;
                laPosicion.Text = iPos.ToString() + " de " + iTotal.ToString();
            }
        }

        private void dgvTelefonos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            mostrarPosicion();
        }
    }
}
