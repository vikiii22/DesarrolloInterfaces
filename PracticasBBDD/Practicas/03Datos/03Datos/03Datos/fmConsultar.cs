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
    public partial class fmConsultar : Form
    {
        public fmConsultar()
        {
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PAISES ";
            sql = sql + "WHERE continente=@Europa or continente=@Asia or continente=@Africa ";
            sql += "or continente=@America or continente=@Oceania ORDER BY continente";
            OleDbCommand comando = new OleDbCommand(sql, fmPrincipal.conexion);
            comando.Parameters.AddWithValue("@Africa", cbAfrica.Checked ? "Africa" : "");
            comando.Parameters.AddWithValue("@Asia", cbAsia.Checked ? "Asia" : "");
            comando.Parameters.AddWithValue("@America", cbAmerica.Checked ? "America" : "");
            comando.Parameters.AddWithValue("@Europa", cbEuropa.Checked ? "Europa" : "");
            comando.Parameters.AddWithValue("@Oceania", cbOceania.Checked ? "Oceania" : "");
            OleDbDataReader lector = comando.ExecuteReader();
            lvConsultas.Items.Clear();
            while (lector.Read())
            {
                ListViewItem elementos = new ListViewItem(lector.GetInt32(0).ToString());
                elementos.SubItems.Add(lector.GetString(1));
                elementos.SubItems.Add(lector.GetString(2));
                elementos.SubItems.Add(lector.GetString(3));
                elementos.SubItems.Add(lector.GetInt32(4).ToString());
                elementos.SubItems.Add(lector.GetInt32(5).ToString());
                decimal pib = Convert.ToDecimal(lector.GetInt32(5)) * 1000000;
                decimal renta = pib / lector.GetInt32(4);
                elementos.SubItems.Add(renta.ToString("######"));
                lvConsultas.Items.Add(elementos);
            }
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM paises ";
            sql = sql + "WHERE nombre=@nombre";
            OleDbCommand comando = new OleDbCommand(sql, fmPrincipal.conexion);
            comando.Parameters.AddWithValue("@nombre", tbConsultaPais.Text);
            OleDbDataReader lector = comando.ExecuteReader();
            lvConsultas.Items.Clear();
            while (lector.Read())
            {
                ListViewItem elementos = new ListViewItem(lector.GetInt32(0).ToString());
                elementos.SubItems.Add(lector.GetString(1));
                elementos.SubItems.Add(lector.GetString(2));
                elementos.SubItems.Add(lector.GetString(3));
                elementos.SubItems.Add(lector.GetInt32(4).ToString());
                elementos.SubItems.Add(lector.GetInt32(5).ToString());
                decimal pib = Convert.ToDecimal(lector.GetInt32(5)) * 1000000;
                decimal renta = pib / lector.GetInt32(4);
                elementos.SubItems.Add(renta.ToString("######"));
                lvConsultas.Items.Add(elementos);
            }
        }
    }
}
