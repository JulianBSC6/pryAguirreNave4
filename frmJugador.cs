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
    public partial class frmJugador : Form
    {
        public frmJugador()
        {
            InitializeComponent();
        }
        string Nombre;
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            this.Hide();
            frmJuego pasar = new frmJuego(Nombre);
            pasar.Show();
            
        }
    }
}
