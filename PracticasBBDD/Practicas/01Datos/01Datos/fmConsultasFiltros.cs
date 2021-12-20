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
    public partial class fmConsultasFiltros : Form
    {
        public fmConsultasFiltros()
        {
            InitializeComponent();
        }

        private void telefonosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telefonosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);

        }

        private void fmConsultasFiltros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_telefonosDataSet.telefonos' Puede moverla o quitarla según sea necesario.
            this.telefonosTableAdapter.Fill(this.bd_telefonosDataSet.telefonos);

        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            string filtro = "";
            if (rbNombre.Checked)
            {
                filtro = filtro + "nombre ";
            }
            if (rbCodigo.Checked)
            {
                filtro = filtro + "id ";
            }
            if (ckOrdenar.Checked)
            {
                telefonosBindingSource.Sort = filtro + " ASC";
            }
            else
            {
                telefonosBindingSource.Sort = filtro + " DESC";
            }
        }
    }
}
