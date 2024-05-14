using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pryAguirreNave4
{
    internal class clsBD
    {
        public void ConectarBDEstado(Label lblEstado)
        {
            try
            {

                string CadenaConexion = "server=localhost;port=3306;database=juegorol;uid=root;password=";

                MySqlConnection conectar = new MySqlConnection(CadenaConexion);
                conectar.Open();
                lblEstado.Text = "Conectado";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        static void ConectarBD()
        {
            try
            {

                string CadenaConexion = "server=localhost;port=3306;database=juegorol;uid=root;password=";

                MySqlConnection conectar = new MySqlConnection(CadenaConexion);
                conectar.Open();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        public void CargarPuntaje(string Nombre, Int32 Puntaje)
        {
            try
            {
                string CadenaConexion = "server=localhost;port=3306;database=juegorol;uid=root;password=";

                MySqlConnection conectar = new MySqlConnection(CadenaConexion);
                conectar.Open();

                // Query para insertar un dato de texto en la tabla
                string query = "INSERT INTO jugadas (Nombre, Puntaje) VALUES (@Nombre, @Puntaje)";

                using (MySqlCommand command = new MySqlCommand(query, conectar))
                {
                    // Asignar el valor de variables
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Puntaje", Puntaje);

                    // Ejecutar el comando
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
