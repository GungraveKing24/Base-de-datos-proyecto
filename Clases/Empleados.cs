using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos.Clases
{
    internal class Empleados
    {
        conexion Conectar = new conexion();

        public void insertar(string nombre, string apellido, string nombre_usuario, string Correo, int telefono, string Administrador, string fecha, string password)
        {
            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO empleado (nombre_empleado, apellido_empleado, nombre_usuario, correoelectronico_empleado, telefono_empleado, administrador, fecharegistro_empleado, contraseña) VALUES (@nombre_empleado, @apellido_empleado, @nombre_usuario, @correoelectronico_empleado, @telefono_empleado, @administrador, @fecharegistro_empleado, @contraseña)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre_empleado", nombre);
                    command.Parameters.AddWithValue("@apellido_empleado", apellido);
                    command.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    command.Parameters.AddWithValue("@correoelectronico_empleado", Correo);
                    command.Parameters.AddWithValue("@telefono_empleado", telefono);
                    command.Parameters.AddWithValue("@administrador", Administrador);
                    command.Parameters.AddWithValue("@fecharegistro_empleado", fecha);
                    command.Parameters.AddWithValue("@contraseña", password);


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
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // DateTime fecha = DateTime.Now;
        }
    }
}
