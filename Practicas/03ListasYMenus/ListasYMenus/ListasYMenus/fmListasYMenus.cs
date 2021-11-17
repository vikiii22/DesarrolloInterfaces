using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasYMenus
{
    public partial class fmListasYMenus : Form
    {
        fmAcercaDe ventanaAcercaDe;
        public fmListasYMenus()
        {
            InitializeComponent();
        }

        private void btMostrarMas_Click(object sender, EventArgs e)
        {
            if (listBoxAlumnos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un alumno");
            }
            else
            {
                //MessageBox.Show("El primero de la lista es " + listBoxAlumnos.Items[0]);
                MessageBox.Show("El seleccionado es: " + listBoxAlumnos.Items[listBoxAlumnos.SelectedIndex] + " ocupa la posición " + Convert.ToString(listBoxAlumnos.SelectedIndex + 1));
            }
        }

        private void btMostrarTodos_Click(object sender, EventArgs e)
        {
            string mostrarTodos = "Numero\tNombre\n";
            for (int i = 0; i <= listBoxAlumnos.Items.Count - 1; i++)
            {
                mostrarTodos = mostrarTodos + (i + 1) + " \t" + listBoxAlumnos.Items[i] + "\n";
            }
            MessageBox.Show(mostrarTodos);
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            listBoxAlumnos.Sorted = true;
            listBoxAlumnos.Sorted = false;
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            pnActualiza.Visible = !pnActualiza.Visible;
            lbNuevo.Enabled = !lbNuevo.Enabled;
            tbNuevo.Enabled = !tbNuevo.Enabled;

            if (pnActualiza.Visible)
            {
                btActualizar.BackColor = Color.Green;
                btActualizar.ForeColor = Color.Black;
            }
            else
            {
                btActualizar.BackColor = Color.DarkRed;
                btActualizar.ForeColor = Color.White;
            }
        }

        private void btAnyadir_Click(object sender, EventArgs e)
        {
            if (tbNuevo.Text == "")
            {
                MessageBox.Show("Tienes que poner un nombre");
            }
            else
            {
                if (listBoxAlumnos.Items.IndexOf(tbNuevo.Text) > -1)
                {
                    MessageBox.Show("El nombre ya existe.");
                }
                else
                {
                    listBoxAlumnos.Items.Add(tbNuevo.Text);
                }
            }
            tbNuevo.SelectAll();
            tbNuevo.Focus();
        }

        private void tbNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btAnyadir.PerformClick();
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (listBoxAlumnos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un alumno");
            }
            else
            {
                //listBoxAlumnos.Items.Remove(listBoxAlumnos.Items[listBoxAlumnos.SelectedIndex]);
                listBoxAlumnos.Items.RemoveAt(listBoxAlumnos.SelectedIndex);
            }
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            tbNuevo.SelectAll();
            if (tbNuevo.Text == "")
            {
                MessageBox.Show("Introduce nombre");
                tbNuevo.Focus();
            }
            else
            {
                if (listBoxAlumnos.SelectedIndex < 0)
                {
                    MessageBox.Show("Elige posición en la lista");
                }
                else
                {
                    if (listBoxAlumnos.Items.IndexOf(tbNuevo.Text) == -1)
                    {
                        listBoxAlumnos.Items.Insert(listBoxAlumnos.SelectedIndex, tbNuevo.Text);
                    }
                    else
                    {
                        MessageBox.Show("El alumno ya existe");
                        tbNuevo.Focus();
                    }
                }
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbNuevo.Text == "")
            {
                MessageBox.Show("Ingresa nombre");
                tbNuevo.Focus();
            }
            else
            {
                if (listBoxAlumnos.Items.IndexOf(tbNuevo.Text) == -1)
                {
                    MessageBox.Show(tbNuevo.Text + " No existe");
                }
                else
                {
                    listBoxAlumnos.SelectedIndex = listBoxAlumnos.Items.IndexOf(tbNuevo.Text);
                }
            }
            tbNuevo.Focus();
        }

        private void btFlechaArriba_Click(object sender, EventArgs e)
        {
            int index = listBoxAlumnos.SelectedIndex;
            if (listBoxAlumnos.SelectedIndex > 0)
            {
                listBoxAlumnos.Items.Insert(listBoxAlumnos.SelectedIndex - 1, listBoxAlumnos.SelectedItem);
                listBoxAlumnos.Items.RemoveAt(listBoxAlumnos.SelectedIndex);
                listBoxAlumnos.SelectedIndex = index - 1;
            }
        }

        private void btFlechaAbajo_Click(object sender, EventArgs e)
        {
            int index = listBoxAlumnos.SelectedIndex;
            if (listBoxAlumnos.SelectedIndex < listBoxAlumnos.Items.Count - 1)
            {

                listBoxAlumnos.Items.Insert(listBoxAlumnos.SelectedIndex + 2, listBoxAlumnos.SelectedItem);
                listBoxAlumnos.Items.RemoveAt(listBoxAlumnos.SelectedIndex);
                listBoxAlumnos.SelectedIndex = index + 1;
            }
        }

        private void itAcercaDe_Click(object sender, EventArgs e)
        {
            ventanaAcercaDe = new fmAcercaDe();
            ventanaAcercaDe.ShowDialog();
        }

        private void itNuevo_Click(object sender, EventArgs e)
        {
            listBoxAlumnos.Items.Clear();
        }

        private void itSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmListasYMenus_Load(object sender, EventArgs e)
        {
            comboBoxGrupos.SelectedIndex = 0;
            btAbrir.PerformClick();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {//@ actúa como prefijo de un elemento de código que el compilador interpreta como identificador
                StreamWriter miArchivo = new StreamWriter(@".\cursos\" + comboBoxGrupos.Text + ".txt");
                foreach (object lista in listBoxAlumnos.Items)
                {
                    miArchivo.WriteLine(lista.ToString());
                }
                miArchivo.Close();
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
            }
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            listBoxAlumnos.Items.Clear();
            try
            {
                StreamReader miArchivo = new StreamReader(@".\cursos\" + comboBoxGrupos.Text + ".txt");
                while (miArchivo.Peek() >= 0)
                {
                    listBoxAlumnos.Items.Add(Convert.ToString(miArchivo.ReadLine()));
                }
                miArchivo.Close();
            }
            catch(Exception miError)
            {
                MessageBox.Show(miError.Message);
            }
        }

        private void tbNuevo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
