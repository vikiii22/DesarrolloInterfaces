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
        public fmPrincipal()
        {
            InitializeComponent();
        }

        fmComandos ventanaComandos;
        fmAutomatico ventanaAutomatico;
        fmConsultasFiltros ventanaConsultasFiltros;
        fmAcercaDe ventanaAcercaDe;

        private void btComandos_Click(object sender, EventArgs e)
        {
            ventanaComandos = new fmComandos();
            ventanaComandos.ShowDialog();
            ventanaComandos.Dispose();
        }

        private void btAutomatico_Click(object sender, EventArgs e)
        {
            ventanaAutomatico = new fmAutomatico();
            ventanaAutomatico.ShowDialog();
            ventanaAutomatico.Dispose();
        }

        private void btConsultasFiltros_Click(object sender, EventArgs e)
        {
            ventanaConsultasFiltros = new fmConsultasFiltros();
            ventanaConsultasFiltros.ShowDialog();
            ventanaConsultasFiltros.Dispose();
        }

        private void btAcercaDe_Click(object sender, EventArgs e)
        {
            ventanaAcercaDe = new fmAcercaDe();
            ventanaAcercaDe.ShowDialog();
            ventanaAcercaDe.Dispose();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
