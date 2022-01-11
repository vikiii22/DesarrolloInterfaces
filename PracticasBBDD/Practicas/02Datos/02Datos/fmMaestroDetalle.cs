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