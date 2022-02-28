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
            cbLetra.Text = "A";
            cbProvincia.Text = "Alicante";
            cbCiudad.Text = "Elche";

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

        private void btBuscar_Click(object sender, EventArgs e)
        {

            if (tbBuscar.Text != "")
            {
                telefonosBindingSource.Position = telefonosBindingSource.Find("nombre", tbBuscar.Text);
            }
        }

        private void ckFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFiltrar.Checked)
            {
                telefonosBindingSource.Filter = "provincia ='" + cbProvincia.Text + "'";
            }
            else
            {
                telefonosBindingSource.RemoveFilter();
            }
        }

        private void ckLetras_CheckedChanged(object sender, EventArgs e)
        {
            string orden = "";
            orden = "nombre LIKE '" + cbLetra.Text + "%'";
           // MessageBox.Show(orden);

            if (ckLetras.Checked)
            {
                telefonosBindingSource.Filter = orden;
            }
            else
            {
                telefonosBindingSource.RemoveFilter();
            }
        }

        private void ckCiudad_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCiudad.Checked)
            {
                telefonosBindingSource.Filter = "ciudad = '" + cbCiudad.Text + "'";
            }
            else
            {
                telefonosBindingSource.RemoveFilter();
            }
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
            }
        }

        private void telefonosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in telefonosDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void telefonosDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = telefonosDataGridView.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = telefonosDataGridView.SortedColumn;

            ListSortDirection direction;

            //if oldColumn is null , then the DataGridView is not sorted

            if (oldColumn != null)
            {
                //sort the column again , reversing the SortOrder.

                if (oldColumn == newColumn && telefonosDataGridView.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    //sort a new column and remove the old SortGlyph
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }
            //Sort the selected column 
            telefonosDataGridView.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void tbIdSeleccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
