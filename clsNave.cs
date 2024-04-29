using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryAguirreNave4
{
    internal class clsNave
    {
        Int32 Puntos;
        private readonly PictureBox Alien;
        private readonly PictureBox Alien2;
        private readonly PictureBox Alien3;
        private readonly Label lblPuntaje;
        private readonly Form frmJuego;
        private readonly PictureBox pctNave;
        private readonly Timer timer1;

        public clsNave(PictureBox Alien, PictureBox Alien2, PictureBox Alien3, PictureBox pctNave, Label lblPuntaje, Form frmJuego, Timer timer1)
        {
            this.Alien = Alien;
            this.Alien2 = Alien2;
            this.Alien3 = Alien3;   
            this.lblPuntaje = lblPuntaje;
            this.frmJuego = frmJuego;
            this.timer1 = timer1;
            this.pctNave = pctNave;
            Puntos = 0;
        }
        
        public void Enemigo()
        {
            Random random = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            
                    if (Alien.Top >= 500 || Alien.Visible == false)
                    {
                        int x = random.Next(0, 800);
                        Alien.Location = new Point(x, 0);
                        Alien.Visible= true;
                    }
                    else
                    {
                        Alien.Top += 15;
                    }
                    if (Alien2.Top >= 500|| Alien2.Visible==false)
                    {
                        int y = random2.Next(0, 800);
                        Alien2.Location = new Point(y, 0);
                        Alien2.Visible= true;
                    }
                    else
                    {
                        Alien2.Top += 20;
                    }
                    if (Alien3.Top >= 500|| Alien3.Visible==false)
                    {
                        int z = random3.Next(0, 800);
                        Alien3.Location = new Point(z, 0);
                        Alien3.Visible= true;
                    }
                    else
                    {
                        Alien3.Top += 18;
                    }
            
        }

        public void Municion()
        {
            PictureBox Municion = new PictureBox();
            Municion.SizeMode = PictureBoxSizeMode.StretchImage;
            Municion.Size = new Size(40, 40);
            Municion.Image = Properties.Resources.laser;
            Municion.Tag = "Laser";
            Municion.Left = pctNave.Left + 15;
            Municion.Top = pctNave.Top - 30;
            frmJuego.Controls.Add(Municion);
            Municion.BringToFront();
        }
        public void CrearAliens()
        {
            PictureBox Alien = new PictureBox();
            Alien.SizeMode = PictureBoxSizeMode.StretchImage;
            Alien.Size = new Size(84, 38);
            Alien.Image = Properties.Resources.alien;
            frmJuego.Controls.Add(Alien);
            Alien.BringToFront();
            Alien.Name = "Alien";
        }

        

        public void Movimiento()
        {
            foreach (Control x in frmJuego.Controls)
            {
                if (x is PictureBox && x.Tag == "Laser")
                {
                    x.Top -= 60;
                    if (x.Top < 60)
                    {
                        frmJuego.Controls.Remove(x);
                    }
                }
            }
        }

        public void Puntaje()
        {
            foreach (Control Laser in frmJuego.Controls)
            {
                foreach (Control Alien in frmJuego.Controls)
                {
                    if (Laser is PictureBox && Laser.Tag == "Laser")
                    {
                        if (Alien is PictureBox && Alien.Tag == "Alien")
                        {
                            if (Laser.Bounds.IntersectsWith(Alien.Bounds))
                            {
                                //frmJuego.Controls.Remove(Alien);
                                Alien.Visible = false;
                                
                                //i.Top = -100;
                                ((PictureBox)Laser).Image = Properties.Resources.explosion;

                                Puntos++;
                                lblPuntaje.Text = Puntos.ToString();
                                frmJuego.Controls.Remove(Laser);

                            }
                        }
                    }
                }
            }
        }
        public void Colision()
        {
            foreach (Control Nave in frmJuego.Controls)
            {
                foreach (Control Alien in frmJuego.Controls)
                {
                    if (Nave is PictureBox && Nave.Tag == "Nave")
                    {
                        if (Alien is PictureBox && Alien.Tag == "Alien")
                        {
                            if (Nave.Bounds.IntersectsWith(Alien.Bounds))
                            {


                            }
                        }
                    }
                }
            }
        }
        public void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = pctNave.Location.X;
            int y = pctNave.Location.Y;
            if (e.KeyChar == 'a') x -= 10;
            if (e.KeyChar == 'd') x += 10;
            if (e.KeyChar == 'w') Municion();
            if (x >= 850) x = 0;
            if (x <= -20) x = 800;
            Point punto = new Point(x, y);
            pctNave.Location = punto;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Enemigo();
            Puntaje();
            Movimiento();
            
        }
    }
}
