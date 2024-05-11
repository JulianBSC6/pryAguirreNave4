namespace pryAguirreNave4
{
    partial class frmJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Alien3 = new System.Windows.Forms.PictureBox();
            this.Alien2 = new System.Windows.Forms.PictureBox();
            this.Alien = new System.Windows.Forms.PictureBox();
            this.pctNave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Alien3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puntos:";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.Color.White;
            this.lblPuntaje.Location = new System.Drawing.Point(17, 49);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(52, 23);
            this.lblPuntaje.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Alien3
            // 
            this.Alien3.Image = global::pryAguirreNave4.Properties.Resources.alien3;
            this.Alien3.Location = new System.Drawing.Point(469, 34);
            this.Alien3.Name = "Alien3";
            this.Alien3.Size = new System.Drawing.Size(126, 82);
            this.Alien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Alien3.TabIndex = 3;
            this.Alien3.TabStop = false;
            this.Alien3.Tag = "Alien";
            // 
            // Alien2
            // 
            this.Alien2.Image = global::pryAguirreNave4.Properties.Resources.alien2;
            this.Alien2.Location = new System.Drawing.Point(297, 34);
            this.Alien2.Name = "Alien2";
            this.Alien2.Size = new System.Drawing.Size(90, 51);
            this.Alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Alien2.TabIndex = 2;
            this.Alien2.TabStop = false;
            this.Alien2.Tag = "Alien";
            // 
            // Alien
            // 
            this.Alien.Image = global::pryAguirreNave4.Properties.Resources.alien;
            this.Alien.Location = new System.Drawing.Point(86, 34);
            this.Alien.Name = "Alien";
            this.Alien.Size = new System.Drawing.Size(84, 38);
            this.Alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Alien.TabIndex = 1;
            this.Alien.TabStop = false;
            this.Alien.Tag = "Alien";
            // 
            // pctNave
            // 
            this.pctNave.Image = global::pryAguirreNave4.Properties.Resources.pngwing_com;
            this.pctNave.Location = new System.Drawing.Point(323, 460);
            this.pctNave.Name = "pctNave";
            this.pctNave.Size = new System.Drawing.Size(86, 64);
            this.pctNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctNave.TabIndex = 0;
            this.pctNave.TabStop = false;
            this.pctNave.Tag = "Nave";
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alien3);
            this.Controls.Add(this.Alien2);
            this.Controls.Add(this.Alien);
            this.Controls.Add(this.pctNave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego Galaga";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmJuego_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Alien3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctNave;
        private System.Windows.Forms.PictureBox Alien;
        private System.Windows.Forms.PictureBox Alien2;
        private System.Windows.Forms.PictureBox Alien3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Timer timer1;
    }
}