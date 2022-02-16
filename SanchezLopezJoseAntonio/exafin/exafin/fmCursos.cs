using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exafin
{
    public partial class fmCursos : Form
    {
        fmAcercaDe ventanaAcercDe;
        public static OleDbConnection conexion;

        public fmCursos()
        {
            InitializeComponent();
        }

        private void cursosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cursosformDataSet);

        }

        private void cursosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cursosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cursosformDataSet);

        }

        private void fmCursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cursosformDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.cursosformDataSet.alumnos);
            // TODO: esta línea de código carga datos en la tabla 'cursosformDataSet.cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.cursosformDataSet.cursos);
            tscbNiveles.Text = "Todos";

            String conecta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\datos\cursosform.mdb;";
            conexion = new OleDbConnection(conecta);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tscbNiveles_Click(object sender, EventArgs e)
        {

        }

        private void tscbNiveles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbNiveles.Text == "Todos")
            {
                cursosBindingSource.RemoveFilter();
            }
            else
            {
                cursosBindingSource.Filter = "nivel ='" + tscbNiveles.Text + "'";
            }
        }

        private void lbMatriculados_BindingContextChanged(object sender, EventArgs e)
        {
            //lbMatriculados.Text = "Matriculados en el curso: " + alumnosBindingSource.Count;
        }

        private void btAcercaDe_Click(object sender, EventArgs e)
        {
            ventanaAcercDe = new fmAcercaDe();
            ventanaAcercDe.ShowDialog();
        }

        private void cursosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbMatriculados.Text = "Matriculados en el curso: " + alumnosBindingSource.Count;
        }

        int alumnos = 0;
        private void cursosDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            lbMatriculados.Text = "Matriculados en el curso: " + alumnosBindingSource.Count;
            int numeroAlumnosMatriculados = Convert.ToInt32(alumnosDataGridView.Rows.Count - 1);
            int edad = 0;
            string genero="";
            int mujeres = 0;
            int hombres = 0;

            for (int i = 0; i < numeroAlumnosMatriculados; i++) {
                genero = Convert.ToString(alumnosDataGridView.Rows[i].Cells[5].Value);
                edad += Convert.ToInt32(alumnosDataGridView.Rows[i].Cells[4].Value);
                

                if (genero.Equals("VARON")) {
                    hombres++;
                }
                if (genero.Equals("MUJER")) {
                    mujeres++;
                }
            }
            lbHombres.Text = "Hombres: " +hombres;
            lbMujeres.Text = "Mujeres: " + mujeres;
            lbEdadMedia.Text = "Edad media: " + edad/numeroAlumnosMatriculados;
            int diferencia = alumnos - numeroAlumnosMatriculados;
            lbVacantes.Text = "Vacantes: " + diferencia;

        }

        private void cursosDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            alumnos = Convert.ToInt32(cursosDataGridView.Rows[e.RowIndex].Cells[2].Value);
        }
    }
}
