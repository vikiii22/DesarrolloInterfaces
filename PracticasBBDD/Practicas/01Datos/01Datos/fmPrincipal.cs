using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Datos
{
    public partial class fmPrincipal : Form
    {
        fmComandos ventanaComandos;
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void btComandos_Click(object sender, EventArgs e)
        {
            ventanaComandos = new fmComandos();
            ventanaComandos.ShowDialog();
            ventanaComandos.Dispose();
        }

        private void btAutomatico_Click(object sender, EventArgs e)
        {
            fmAutomatico ventanaAuto = new fmAutomatico();
            ventanaAuto.ShowDialog();
            ventanaAuto.Dispose();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            fmConsultasFiltros ventanaFiltros = new fmConsultasFiltros();
            ventanaFiltros.ShowDialog();
            ventanaFiltros.Dispose();
        }
    }
}
