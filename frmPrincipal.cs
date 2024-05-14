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
            frmJugador pasar = new frmJugador();    
            pasar.Show();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFirma pasar = new frmFirma();
            pasar.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsBD conexion = new clsBD();
            conexion.ConectarBDEstado(lblEstadoConexion);
        }
    }
}
