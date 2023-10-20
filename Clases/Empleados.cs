using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos.Clases
{
    internal class Empleados
    {
        conexion Conectar = new conexion();

        public class Empleado
        {
            public string nombre { get; set;}
            public string apellido { get; set;}
            public string nombre_usuario { get; set;}
            public string Correo { get; set;}
            public int telefono { get; set;}
            public bool Administrador { get; set;}
            public DateTime fecha { get; set;}
            public string password { get; set;}
        }

        public void insertar(Empleado empleado)
        {
            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO juego (juego, estado, runN, rejugando, DatosAdicionales, Calificacion, foto) " +
                                   "VALUES (@juego, @estado, @runN, @rejugando, @datosAdicionales, @calificacion, @foto);";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", empleado.nombre);
                    command.Parameters.AddWithValue("@apellido", empleado.apellido);
                    command.Parameters.AddWithValue("@", empleado.nombre_usuario);


                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente en la base de datos.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar los datos en la base de datos.");
                    }
                }
            catch (Exception ex)
            {
                throw ex;
                    
            }

            // DateTime fecha = DateTime.Now;
        }
    }
}
