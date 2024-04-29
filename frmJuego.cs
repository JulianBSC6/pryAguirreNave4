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
        public frmJuego()
        {
            InitializeComponent();
            Nave = new clsNave(Alien, Alien2, Alien3, pctNave, lblPuntaje, this, timer1);
        }
        //Int32 x;
        //void Enemigo()
        //{
        //    Random random = new Random();

        //    if (Alien.Top >= 500)
        //    {
        //        x = random.Next(0, 800);
        //        Alien.Location = new Point(x, 0);

        //    }
        //    else
        //    {
        //        Alien.Top += 15;
        //    }
        //}
        //void Municion()
        //{
        //    PictureBox Municion = new PictureBox();
        //    Municion.SizeMode = PictureBoxSizeMode.StretchImage;
        //    Municion.Size = new System.Drawing.Size(40, 40);
        //    Municion.Image = Properties.Resources.laser;
        //    Municion.Tag = "Laser";
        //    Municion.Left = pictureBox1.Left + 15;
        //    Municion.Top = pictureBox1.Top - 30;
        //    this.Controls.Add(Municion);
        //    Municion.BringToFront();
        //}

        //void Movimiento()
        //{
        //    foreach (Control x in this.Controls)
        //    {
        //        if (x is PictureBox && x.Tag == "Laser")
        //        {
        //            x.Top -= 30;
        //            if (x.Top < 60 )
        //            {
        //                this.Controls.Remove(x);
        //            }
        //        }
        //    }
        //}
        //Int32 Puntos;
        //void Puntaje()
        //{
        //    foreach (Control j in this.Controls)
        //    {
        //        foreach (Control i in this.Controls)
        //        {
        //            if (j is PictureBox && j.Tag == "Laser")
        //            {
        //                if (i is PictureBox && i.Tag == "Alien")
        //                {
        //                    if (j.Bounds.IntersectsWith(i.Bounds))
        //                    {
        //                        i.Top = -100;
        //                        ((PictureBox)j).Image = Properties.Resources.explosion;

        //                        Puntos++;
        //                        lblPuntaje.Text = Puntos.ToString();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            Nave.frmJuego_KeyPress(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Nave.timer1_Tick(sender, e);
            
        }
    }
}
