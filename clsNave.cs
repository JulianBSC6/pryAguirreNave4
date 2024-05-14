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
        public Int32 Puntos;
        private readonly PictureBox Alien;
        private readonly PictureBox Alien2;
        private readonly PictureBox Alien3;
        private readonly System.Windows.Forms.Label lblPuntaje;
        private readonly Form frmJuego;
        private readonly PictureBox pctNave;
        private readonly Timer timer1;
        private Point UltimaPosicion;
        public string Nombre;
        
        

        public clsNave(PictureBox Alien, PictureBox Alien2, PictureBox Alien3, PictureBox pctNave, System.Windows.Forms.Label lblPuntaje, Form frmJuego, Timer timer1, String Name )
        {
            this.Alien = Alien;
            this.Alien2 = Alien2;
            this.Alien3 = Alien3;   
            this.lblPuntaje = lblPuntaje;
            this.frmJuego = frmJuego;
            this.timer1 = timer1;
            this.pctNave = pctNave;
            this.Nombre = Name;
            
            timer1.Interval = 1;
            timer1.Start();
            
        }
        
        public void Enemigo()
        {
            Random random = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            if (Puntos < 10)
            {
                

                if (Alien.Top >= 500 || Alien.Visible == false)
                {
                    int x = random.Next(0, 800);
                    Alien.Location = new Point(x, 0);
                    Alien.Visible = true;
                }
                else
                {
                    Alien.Top += 2;
                }
                if (Alien2.Top >= 500 || Alien2.Visible == false)
                {
                    int y = random2.Next(0, 800);
                    Alien2.Location = new Point(y, 0);
                    Alien2.Visible = true;
                }
                else
                {
                    Alien2.Top += 2;
                }
                if (Alien3.Top >= 500 || Alien3.Visible == false)
                {
                    int z = random3.Next(0, 800);
                    Alien3.Location = new Point(z, 0);
                    Alien3.Visible = true;
                }
                else
                {
                    Alien3.Top += 1;
                }
            }
            else
            {
                if (Alien.Top >= 500 || Alien.Visible == false)
                {
                    int x = random.Next(0, 800);
                    Alien.Location = new Point(x, 0);
                    Alien.Visible = true;
                }
                else
                {
                    Alien.Top += 3;
                }
                if (Alien2.Top >= 500 || Alien2.Visible == false)
                {
                    int y = random2.Next(0, 800);
                    Alien2.Location = new Point(y, 0);
                    Alien2.Visible = true;
                }
                else
                {
                    Alien2.Top += 3;
                }
                if (Alien3.Top >= 500 || Alien3.Visible == false)
                {
                    int z = random3.Next(0, 800);
                    Alien3.Location = new Point(z, 0);
                    Alien3.Visible = true;
                }
                else
                {
                    Alien3.Top += 2;
                }
            }
        }

        public void Municion()
        {
            
            if (Puntos > 10)
            {
                
                PictureBox Municion2 = new PictureBox();
                Municion2.SizeMode = PictureBoxSizeMode.StretchImage;
                Municion2.Size = new Size(20, 30);
                Municion2.Image = Properties.Resources.laser;
                Municion2.Tag = "Laser";
                Municion2.Left = pctNave.Left + 60;
                Municion2.Top = pctNave.Top - 30;
                frmJuego.Controls.Add(Municion2);
                Municion2.BringToFront();
            }
            
                PictureBox Municion = new PictureBox();
                Municion.SizeMode = PictureBoxSizeMode.StretchImage;
                Municion.Size = new Size(20, 30);
                Municion.Image = Properties.Resources.laser;
                Municion.Tag = "Laser";
                Municion.Left = pctNave.Left + 15;
                Municion.Top = pctNave.Top - 30;
                frmJuego.Controls.Add(Municion);
                Municion.BringToFront();
            
            
        }
        public void Municion2()
        {
           //no se usa
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
                    x.Top -= 20;
                    if (x.Top < 60)
                    {
                        frmJuego.Controls.Remove(x);
                    }
                }
            }
        }
        clsBD objDatos = new clsBD();
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
                                
                                UltimaPosicion = Laser.Location;

                                Puntos++;
                                lblPuntaje.Text = Puntos.ToString();
                                frmJuego.Controls.Remove(Laser);
                                Colision();
                                
                                


                            }
                        }
                    }
                }
            }
        }
        public void Colision()
        {

            PictureBox Explosion = new PictureBox();
            Explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            Explosion.Size = new Size(30, 30);
            Explosion.Image = Properties.Resources.explosion;
            Explosion.Location = UltimaPosicion;
            frmJuego.Controls.Add(Explosion);
            Explosion.BringToFront();
            Explosion.Name = "explosion";

            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += (sender, arges) =>
            {
                frmJuego.Controls.Remove(Explosion);
                Explosion.Dispose();
                timer.Stop();
            };
            timer.Start();
        }
        public void Perder()
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
                                frmPerdiste perder = new frmPerdiste();
                                perder.Show();
                                timer1.Stop();
                                //Puntaje
                               
                                perder.lblPuntajeFinal.Text = Puntos.ToString();

                                
                                

                                objDatos.CargarPuntaje(this.Nombre, Puntos);
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
            if (e.KeyChar == 'a') x -= 15;
            if (e.KeyChar == 'd') x += 15;
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
            Perder();
        }
    }
}
