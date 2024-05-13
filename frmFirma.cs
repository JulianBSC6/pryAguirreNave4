using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pryAguirreNave4
{
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();
            Firma = new Bitmap(pctFirma.Width, pctFirma.Height);
            pctFirma.Image = Firma;
            punto = Point.Empty;
        }
        // Variable donde almaceno la firma
        private Bitmap Firma;
        private Point punto;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Preguntamos si existe firma
            if (Firma != null)
            {
                // aca dibuja la firma en el pct
                e.Graphics.DrawImage(Firma, Point.Empty);
            }
        }

        private void DibujarFirma(Point startPoint, Point endPoint)
        {
            using (Graphics Dibujar = Graphics.FromImage(Firma))
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    Dibujar.DrawLine(pen, startPoint, endPoint);
                }
            }
        }

        private void pictureBox1_Move(object sender, EventArgs e)
        {

        }
        // este es el evento del mouse
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (punto != Point.Empty)
                {
                    using (Graphics g = Graphics.FromImage(Firma))
                    {
                        g.DrawLine(Pens.Black, punto, e.Location);
                    }
                    pctFirma.Invalidate();
                }
                punto = e.Location;
            }
            else
            {
                punto = Point.Empty;
            }
        }
        //Guardar la imagen
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (Firma != null)
            //{
            //    using (SaveFileDialog guardar = new SaveFileDialog())
            //    {

            //        DateTime now = DateTime.Now;

            //        // Crear el nombre de archivo
            //        string fileName = $"{now:yyyyMMdd_HHmmss}.png";
            //        guardar.Filter = "Image Files (*.png)|*.png|All files (*.*)|*.*";
            //        if (guardar.ShowDialog() == DialogResult.OK)
            //        {
            //            Firma.Save(guardar.FileName, ImageFormat.Png);
            //            MessageBox.Show("La firma se guardo correctamente.");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Dibuje su firma para guardar.");
            //}

            if (Firma != null)
            {
                using (SaveFileDialog guardar = new SaveFileDialog())
                {
                    DateTime now = DateTime.Now;

                    // Crear el nombre de archivo
                    string fileName = $"{now:yyyy.MM.dd_HH:mm.ss}.png";

                    
                    DirectoryInfo info = new DirectoryInfo(@"../../" + "Firmas");
                    string ruta = info.FullName;

                    // Combinar la ruta de la carpeta con el nombre del archivo
                    string rutafinal = Path.Combine(ruta, fileName);

                    // Establecer el filtro del cuadro de diálogo de guardado
                    guardar.Filter = "Image Files (*.png)|*.png|All files (*.*)|*.*";

                    // Establecer la ruta de guardado predeterminada
                    guardar.InitialDirectory = ruta;

                    // Establecer el nombre de archivo predeterminado
                    guardar.FileName = fileName;

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Guardar la imagen en la ruta especificada
                            Firma.Save(rutafinal, ImageFormat.Png);
                            MessageBox.Show("La firma se guardó correctamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar la imagen: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dibuje su firma para guardar.");
            }
        }
    
        //inicializar la imagen de la firma
        private void frmFirma_Load(object sender, EventArgs e)
        {
            Firma = new Bitmap(pctFirma.Width, pctFirma.Height);
            pctFirma.Image = Firma;
        }

        private void pctFirma_Click(object sender, EventArgs e)
        {

        }
    }
}
