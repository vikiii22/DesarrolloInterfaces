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

namespace Examen
{
    public partial class fmExamen : Form
    {
        public fmExamen()
        {
            InitializeComponent();
        }

        private void fmExamen_Load(object sender, EventArgs e)
        {
            lbAlmacenes1.Items.Clear();
            try
            {
                StreamReader archivo = new StreamReader(@".\Principal\" + cbAlmacenes1.Text + ".txt");
                while (archivo.Peek() >= 0)
                {
                    lbAlmacenes1.Items.Add(Convert.ToString(archivo.ReadLine()));
                }
                archivo.Close();
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
            }

            lbAlmacenes2.Items.Clear();
            try
            {
                StreamReader archivo2 = new StreamReader(@".\Secundario\" + cbAlmacenes2.Text + ".txt");
                while (archivo2.Peek() >= 0)
                {
                    lbAlmacenes2.Items.Add(Convert.ToString(archivo2.ReadLine()));
                }
                archivo2.Close();
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
            }
        }
        
        private void cbAlmacenes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAlmacenes1.Items.Clear();
            try
            {
                StreamReader archivo = new StreamReader(@".\Principal\" + cbAlmacenes1.Text + ".txt");
                while (archivo.Peek() >= 0)
                {
                    lbAlmacenes1.Items.Add(Convert.ToString(archivo.ReadLine()));
                }
                archivo.Close();
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
            }
        }

        private void btEnviarTodo1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbAlmacenes1.Items.Count; i++)
            {
                lbAlmacenes2.Items.Add(lbAlmacenes1.Items[i]);
            }
        }

        private void btPasar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbAlmacenes1.Items.Count; i++)
            {
                if (lbAlmacenes1.GetSelected(i))
                {
                    lbAlmacenes2.Items.Add(lbAlmacenes1.Items[i]);
                    lbAlmacenes1.Items.RemoveAt(i);
                }
            }
        }

        private void lbAlmacenes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAlmacenes2.SelectedIndex >= 0)
            {
                btPasar2.Enabled = true;
                btElimina2.Enabled = true;
            }
            else
            {
                btElimina2.Enabled = false;
            }
        }

        private void cbOrdena1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOrdena1.Checked)
            {
                lbAlmacenes1.Sorted = true;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAnyadir_Click(object sender, EventArgs e)
        {
            tbNuevo.SelectAll();
            if (tbNuevo.Text == "")
            {
                MessageBox.Show("Introduce nombre");
                tbNuevo.Focus();
            }
            else
            {
                if (lbAlmacenes1.SelectedIndex < 0)
                {
                    MessageBox.Show("Elige posición en la lista");
                }
                else
                {
                    if (lbAlmacenes1.Items.IndexOf(tbNuevo.Text) == -1)
                    {
                        lbAlmacenes1.Items.Insert(lbAlmacenes1.SelectedIndex, tbNuevo.Text);
                    }
                    else
                    {
                        MessageBox.Show("Existe");
                        tbNuevo.Focus();
                    }
                }
            }
        }

        private void lbAlmacenes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAlmacenes1.SelectedIndex >= 0)
            {
                btPasar1.Enabled = true;
                btElimina.Enabled = true;
            }
            else
            {
                btElimina.Enabled = false;
            }
        }

        private void cbAlmacenes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAlmacenes2.Items.Clear();
            try
            {
                StreamReader archivo = new StreamReader(@".\Secundario\" + cbAlmacenes2.Text + ".txt");
                while (archivo.Peek() >= 0)
                {
                    lbAlmacenes2.Items.Add(Convert.ToString(archivo.ReadLine()));
                }
                archivo.Close();
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
            }
        }

        private void btEnviarTodo2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbAlmacenes2.Items.Count; i++)
            {
                lbAlmacenes1.Items.Add(lbAlmacenes2.Items[i]);
            }
        }

        private void cbOrdena2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOrdena2.Checked)
            {
                lbAlmacenes2.Sorted = true;
            }
        }

        private void btPasar2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbAlmacenes2.Items.Count; i++)
            {
                if (lbAlmacenes2.GetSelected(i))
                {
                    lbAlmacenes1.Items.Add(lbAlmacenes2.Items[i]);
                    lbAlmacenes2.Items.RemoveAt(i);
                }
            }
        }

        private void btNuevo2_Click(object sender, EventArgs e)
        {
            tbNuevo2.SelectAll();
            if (tbNuevo2.Text == "")
            {
                MessageBox.Show("Introduce nombre");
                tbNuevo.Focus();
            }
            else
            {
                if (lbAlmacenes2.SelectedIndex < 0)
                {
                    MessageBox.Show("Elige posición en la lista");
                }
                else
                {
                    if (lbAlmacenes2.Items.IndexOf(tbNuevo2.Text) == -1)
                    {
                        lbAlmacenes2.Items.Insert(lbAlmacenes2.SelectedIndex, tbNuevo2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Existe");
                        tbNuevo2.Focus();
                    }
                }
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter miArchivo = new StreamWriter(@".\Principal\" + cbAlmacenes1.Text + ".txt");
                foreach (object lista in lbAlmacenes1.Items)
                {
                    miArchivo.WriteLine(lista.ToString());
                }
                miArchivo.Close();
                MessageBox.Show("Guardado");
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
            }
        }

        private void btGuarda2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter miArchivo = new StreamWriter(@".\Secundario\" + cbAlmacenes2.Text + ".txt");
                foreach (object lista in lbAlmacenes2.Items)
                {
                    miArchivo.WriteLine(lista.ToString());
                }
                miArchivo.Close();
                MessageBox.Show("Guardado");
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
            }
        }

        private void btAcercaDe_Click(object sender, EventArgs e)
        {
            fmAcercaDe ventanaAcercaDe = new fmAcercaDe();
            ventanaAcercaDe.ShowDialog();
        }

        private void btElimina_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lbAlmacenes1.Items.Count)
            {
                if (lbAlmacenes1.GetSelected(i))
                {
                    lbAlmacenes1.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btElimina2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lbAlmacenes2.Items.Count)
            {
                if (lbAlmacenes2.GetSelected(i))
                {
                    lbAlmacenes2.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void tbNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btAnyadir.PerformClick();
            }
        }

        private void tbNuevo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btNuevo2.PerformClick();
            }
        }

        private void tbNuevo_TextChanged(object sender, EventArgs e)
        {
            if (tbNuevo.Text != "")
            {
                btAnyadir.Enabled = true;
            }
            else
            {
                btAnyadir.Enabled = false;
            }
        }

        private void tbNuevo2_TextChanged(object sender, EventArgs e)
        {
            if (tbNuevo2.Text != "")
            {
                btNuevo2.Enabled = true;
            }
            else
            {
                btNuevo2.Enabled = false;
            }
        }

        /* He intentado el drag drop pero no me ha funcionado, lo dejo comentado
         * private void lbAlmacenes1_DragDrop(object sender, DragEventArgs e)
         {
             ListBox miListBox = (ListBox)sender;
             if (e.Data.GetDataPresent(DataFormats.FileDrop))
             {
                 string[] ficheros = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                 foreach (var fichero in ficheros)
                 {
                     StreamReader miArchivo = new StreamReader(fichero, Encoding.Default);
                     while (miArchivo.Peek() >= 0)
                     {
                         miListBox.Items.Add(Convert.ToString(miArchivo.ReadLine()));
                     }
                     miArchivo.Close();
                 }
             }
             else
             {
                 if (e.Data.GetDataPresent(DataFormats.Text))
                 {
                     if (sender == lbAlmacenes1 && lbAlmacenes2.SelectedIndex > -1)
                     {
                         anyadeListBox(lbAlmacenes1, lbAlmacenes2);
                         borraListBox(lbAlmacenes2);
                     }
                     if (sender == lbAlmacenes2 && lbAlmacenes1.SelectedIndex > -1)
                     {
                         anyadeListBox(lbAlmacenes2, lbAlmacenes1);
                         borraListBox(lbAlmacenes1);
                     }
                 }
             }
         }

         private void borraListBox(ListBox lbBorra)
         {
             int i = 0;
             while (i < lbBorra.Items.Count)
             {
                 if (lbBorra.GetSelected(i))
                 {
                     lbBorra.Items.RemoveAt(i);
                 }
                 else
                 {
                     i++;
                 }
             }
         }

         private void anyadeListBox(ListBox lbAcopla, ListBox lbArrastra)
         {
             for (int i = 0; i < lbArrastra.Items.Count; i++)
             {
                 if (lbArrastra.GetSelected(i))
                 {
                     lbAcopla.Items.Add(lbArrastra.Items[i]);
                 }
             }
         }

         private void lbAlmacenes1_MouseDown(object sender, MouseEventArgs e)
         {
             if (lbAlmacenes1.SelectedIndex >= 0)
             {
                 lbAlmacenes2.DoDragDrop(lbAlmacenes1.SelectedItem, DragDropEffects.All);//Indica operación de arrastre.
             }
         }

         private void lbAlmacenes2_MouseDown(object sender, MouseEventArgs e)
         {
             if (lbAlmacenes2.SelectedIndex >= 0)
             {
                 lbAlmacenes1.DoDragDrop(lbAlmacenes2.SelectedItem, DragDropEffects.All);
             }
         }*/
    }
}
