using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Datos
{
    public partial class fmMaestroDetalle : Form
    {
        public fmMaestroDetalle()
        {
            InitializeComponent();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet);

        }

        private void fmMaestroDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Editorial' Puede moverla o quitarla según sea necesario.
            this.editorialTableAdapter.Fill(this.librosDataSet.Editorial);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Autor' Puede moverla o quitarla según sea necesario.
            this.autorTableAdapter.Fill(this.librosDataSet.Autor);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.librosDataSet.Libros);

            autorBindingSource.Sort = "CodigoAutor ASC";

        }

        private void dvgLibros_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            stlTotal.Text = "Total de libros del Autor: " + tbNombreAutor.Text + " " + Convert.ToString(dvgLibros.RowCount - 1);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataTable miTabla = librosDataSet.Libros;
            DataRow Fila = miTabla.Rows[miTabla.Rows.Count - 1];
            int codigoMayor = Convert.ToInt32(Fila[0]);
            foreach(DataRow unaFila in miTabla.Rows)
            {
                if (Convert.ToInt32(unaFila[0]) > codigoMayor)
                {
                    codigoMayor = Convert.ToInt32(unaFila[0]);
                }
            }
            codigoMayor++;
            try {
                Fila = miTabla.NewRow();
                dvgLibros.CurrentRow.Cells[0].Value = codigoMayor;
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que deseas borrar el libro? " + "", "Borrar datos", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                bindingNavigatorDeleteItem.PerformClick();
            }
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            this.librosBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet);
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            if (librosDataSet.HasChanges())
            {
                autorTableAdapter.Update(librosDataSet.Autor);
            }

            DataTable miTabla = librosDataSet.Autor;
            DataRow fila;
            fila = miTabla.Rows[miTabla.Rows.Count - 1];
            int nuevoId = Convert.ToInt32(fila[0]);
            nuevoId++;
            try
            {
                codigoAutorTextBox.Text = Convert.ToString(nuevoId);
            }catch(ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bindingNavigatorAddNewItem1.Enabled = true;
            tbNombreAutor.Focus();
        }

        private void bindingNavigatorDeleteItem1_MouseDown(object sender, MouseEventArgs e)
        {
            if (dvgLibros.Rows.Count > 1)
            {
                MessageBox.Show("Este autor tiene " + Convert.ToString(dvgLibros.Rows.Count) + " Libros. No se puede borrar");
                return;
            }
            DialogResult resultado = MessageBox.Show("Seguro que deseas borrar el autor?" + tbNombreAutor, "Borrar datos", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                bindingNavigatorDeleteItem1.PerformClick();
            }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem1.Enabled = true;
        }

        private void tsbGuardarAutor_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet);
            bindingNavigatorAddNewItem1.Enabled = true;
        }
    }
}

/** Relacion maestro detalle
 *conexion base datos y cambiamos path
 * Origen de datos > click derecho en bbdd > editar dataset
 * Elegir herramienta relation, arrastrar a la tabla detalle y rellenar datos en ventana
 * Por último arrastrar la tabla muestra en primer lugar, a continuacion la detalle y alinear.
 **/


/**Establecer tabla de referencia 
 * Agregar nueva columna en DataGrid
 * Rellenar las propiedades siguientes
 * DataPropertyName=CodigoEditorial de Libros
 * DataSource=EditorialBindingSource
 * DisplayName=Nombre de tabla editorial
 * ValueMember = CodigoEditorial de tabla editorial
 **/