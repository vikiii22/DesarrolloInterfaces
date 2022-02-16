using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repasandoConAlejandro
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
            this.tableAdapterManager.UpdateAll(this.librosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.librosDataSet.Libros);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Autor' Puede moverla o quitarla según sea necesario.
            this.autorTableAdapter.Fill(this.librosDataSet.Autor);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
