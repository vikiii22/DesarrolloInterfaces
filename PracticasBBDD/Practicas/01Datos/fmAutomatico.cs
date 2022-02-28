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
    public partial class fmAutomatico : Form
    {
        bool edicion = false;
        public fmAutomatico()
        {
            InitializeComponent();
        }

        private void telefonosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "")
            {
                MessageBox.Show("Falta nombre");
                nombreTextBox.Focus();
            }
            else
            {
                try
                {
                    this.Validate();
                    this.telefonosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);
                    bindingNavigatorAddNewItem.Enabled = true;
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show(ex.Message);                  
                }
                edicion = false;
            }
        }

        private void fmAutomatico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_telefonosDataSet.telefonos' Puede moverla o quitarla según sea necesario.
            this.telefonosTableAdapter.Fill(this.bd_telefonosDataSet.telefonos);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (bd_telefonosDataSet.HasChanges())
            {
                telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
            }

            DataTable miTabla = bd_telefonosDataSet.telefonos;
            DataRowCollection cFilas = miTabla.Rows;
            DataRow Fila;
            Fila = miTabla.Rows[miTabla.Rows.Count - 1];
            int nuevoId = Convert.ToInt32(Fila[0]);
            nuevoId++;

            try
            {
                idTextBox.Text = Convert.ToString(nuevoId);
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }

            bindingNavigatorAddNewItem.Enabled = false;
            nombreTextBox.Focus();
            edicion = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;

            edicion = false;
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que deseas borrar a ? " + nombreTextBox.Text, "Borrar datos", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                bindingNavigatorDeleteItem.PerformClick();
            }
        }

        private void fmAutomatico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edicion)
            {
                if (MessageBox.Show("¿Desea grabar los cambios pendientes?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    this.Validate();
                    this.telefonosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);
                }
            }
        }

        private void observacionesTextBox_Click(object sender, EventArgs e)
        {
            edicion = true;
        }
    }
}
