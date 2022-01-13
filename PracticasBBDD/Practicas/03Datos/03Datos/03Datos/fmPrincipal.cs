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
    }
}
