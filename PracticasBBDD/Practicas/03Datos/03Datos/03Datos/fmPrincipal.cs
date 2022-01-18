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

namespace _03Datos
{
    public partial class fmPrincipal : Form
    {
        fmActualizar VentanaActualizar = new fmActualizar();

        public static OleDbConnection conexion;
        //fmActualizar ventanaActualizar;
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void fmPrincipal_Load(object sender, EventArgs e)
        {
            string conecta=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\datos\bd_paises.mdb;";
            conexion = new OleDbConnection(conecta);
            try
            {
                conexion.Open();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM paises ORDER BY id", conexion);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            lvDatos.Items.Clear();
            for (int i=0; i<tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["id"].ToString());
                elementos.SubItems.Add(filas["nombre"].ToString());
                elementos.SubItems.Add(filas["capital"].ToString());
                elementos.SubItems.Add(filas["continente"].ToString());
                elementos.SubItems.Add(filas["poblacion"].ToString());
                elementos.SubItems.Add(filas["pib"].ToString());
                elementos.SubItems.Add("0");
                lvDatos.Items.Add(elementos);
            }
        }

        private void btAnyadir_Click(object sender, EventArgs e)
        {
            string numFilas = "SELECT TOP 1 ID FROM paises ORDER BY ID DESC ";
            OleDbCommand comando1 = new OleDbCommand(numFilas, conexion);
            int numfil = (int)comando1.ExecuteScalar();
            VentanaActualizar.tbId.Text = Convert.ToString(numfil + 1);
            VentanaActualizar.tbCapital.Text = "";
            VentanaActualizar.cbContinente.Text = "";
            VentanaActualizar.tbPIB.Text = "0";
            VentanaActualizar.tbPoblacion.Text = "0";
            VentanaActualizar.tbNPais.Text = "";
            VentanaActualizar.ponercontinentes();
            if (VentanaActualizar.ShowDialog() == DialogResult.OK)
            {
                string insertar = "INSERT INTO paises(id,nombre,capital,continente,poblacion,pib) ";
                insertar = insertar + "VALUES ('" + VentanaActualizar.tbId.Text + "','"
                + VentanaActualizar.tbNPais.Text + "','"
                + VentanaActualizar.tbCapital.Text + "','"
                + VentanaActualizar.cbContinente.Text + "','"
                + VentanaActualizar.tbPoblacion.Text + "','" + VentanaActualizar.tbPIB.Text + "')";
                OleDbCommand comando = new OleDbCommand(insertar, conexion);
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Datos Guardados correctamente");
                btMostrar.PerformClick();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lvDatos.SelectedIndices.Count > 0)
            {
                ListView.SelectedListViewItemCollection seleccionado = lvDatos.SelectedItems;
                foreach (ListViewItem elemento in seleccionado)
                {
                    int mid = Convert.ToInt32(elemento.SubItems[0].Text);
                    string consulta = "select * from paises where Id = @mid; ";
                    OleDbCommand comando = new OleDbCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@mid", mid);
                    OleDbDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        VentanaActualizar.ponercontinentes();
                        VentanaActualizar.tbId.Text = Convert.ToString(lector.GetInt32(0));
                        VentanaActualizar.tbNPais.Text = lector.GetString(1);
                        VentanaActualizar.tbCapital.Text = lector.GetString(2);
                        VentanaActualizar.cbContinente.Text = lector.GetString(3);
                        VentanaActualizar.tbPoblacion.Text = Convert.ToString(lector.GetInt32(4));
                        VentanaActualizar.tbPIB.Text = Convert.ToString(lector.GetInt32(5));
                        if (VentanaActualizar.ShowDialog() == DialogResult.OK)
                        {
                            mid = Convert.ToInt32(VentanaActualizar.tbId.Text);
                            string modificar = "UPDATE paises ";
                            modificar = modificar + " SET id ='" + VentanaActualizar.tbId.Text + "',nombre='"
                            + VentanaActualizar.tbNPais.Text + "',capital='"
                            + VentanaActualizar.tbCapital.Text + "'";
                            modificar = modificar + ",continente ='" + VentanaActualizar.cbContinente.Text + "',poblacion='"
                            + VentanaActualizar.tbPoblacion.Text
                            + "',pib='" + VentanaActualizar.tbPIB.Text + "' ";
                            modificar = modificar + "where Id = @mid; ";
                            OleDbCommand comando2 = new OleDbCommand(modificar, conexion);
                            comando2.Parameters.AddWithValue("@mid", mid);
                            try
                            {
                                comando2.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            MessageBox.Show("Datos Guardados correctamente");
                        }
                    }
                    btMostrar.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Elige un Pais");
            }

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            fmConsultar ventanaConsultar = new fmConsultar();
            ventanaConsultar.ShowDialog();
        }
    }
}
