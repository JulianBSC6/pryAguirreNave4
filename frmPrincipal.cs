using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAguirreNave4
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void juegoGalagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJuego pasar = new frmJuego();    
            pasar.Show();
        }
    }
}
