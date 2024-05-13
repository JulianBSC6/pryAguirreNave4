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
    public partial class frmPerdiste : Form
    {
        
        public frmPerdiste()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmJuego))
                {
                    form.Close();
                    break; // Termina el bucle una vez que se cierra el formulario
                }
            }
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }
        

        private void frmPerdiste_Load(object sender, EventArgs e)
        {
            
            //lblPuntajeFinal.Text = Puntuacion.Puntos.ToString();
            
            
        }
    }
}
