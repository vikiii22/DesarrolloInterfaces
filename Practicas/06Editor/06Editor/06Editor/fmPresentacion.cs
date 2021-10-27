using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Editor
{
    public partial class fmPresentacion : Form
    {
        public fmPresentacion()
        {
            InitializeComponent();
        }

        private void fmPresentacion_Load(object sender, EventArgs e)
        {
            Timer miTimer = new Timer();
            miTimer.Tick += miTimer_Tick;
            miTimer.Interval = 2000;
            miTimer.Enabled = true;
            miTimer.Start();
        }

        private void miTimer_Tick(Object sender, EventArgs e)
        {
            Close();
        }
    }
}
