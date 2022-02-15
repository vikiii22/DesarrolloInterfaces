using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaestroDetalle2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet1);

        }

        private void autorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.autorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet1.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet1.Autor' Puede moverla o quitarla según sea necesario.
            this.autorTableAdapter.Fill(this.librosDataSet1.Autor);

        }

        private void autorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void autorBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }
    }
}
