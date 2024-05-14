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
    public partial class frmJuego : Form
    {
        private clsNave Nave;
        public frmJuego(string NombreJugador)
        {
            InitializeComponent();
            string NJugador = NombreJugador;
            Nave = new clsNave(Alien, Alien2, Alien3, pctNave, lblPuntaje, this, timer1, NJugador);
            
        }
        

        
        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            Nave.frmJuego_KeyPress(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Nave.timer1_Tick(sender, e);
            
            
        }
        public Int32 puntajeFinal;
        
        private void frmJuego_Load(object sender, EventArgs e)
        {
            
        }
    }
}
