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
    public partial class fmActualizar : Form
    {
        public fmActualizar()
        {
            InitializeComponent();
        }

        private void fmActualizar_Load(object sender, EventArgs e)
        {

        }

        public void ponercontinentes()
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT DISTINCT continente FROM paises", fmPrincipal.conexion);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            cbContinente.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                cbContinente.Items.Add(filas["continente"].ToString());
            }
            cbContinente.SelectedIndex = 0;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tbNPais.Text == "")
            {
                MessageBox.Show("FALTA EL NOMBRE");
                tbNPais.Focus();
                return;
            }
            if (tbId.Text == "")
            {
                MessageBox.Show("FALTA EL ID");
                tbNPais.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
