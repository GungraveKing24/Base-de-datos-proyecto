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
                    string query = "INSERT INTO empleado (nombre_empleado, apellido_empleado, nombre_usuario, correoelectronico_empleado, telefono_empleado, administrador, fecharegistro_empleado, contraseña) VALUES (@nombre_empleado, @apellido_empleado, @nombre_usuario, @correoelectronico_empleado, @telefono_empleado, @administrador, @fecharegistro_empleado, @contraseña);";
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
                    command.ExecuteNonQuery();             
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void Update(int id, string nombre, string apellido, string nombre_usuario, string Correo, int telefono, string Administrador, string password)
        {
            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE empleado SET nombre_empleado = @nombre_empleado, apellido_empleado = @apellido_empleado, nombre_usuario = @nombre_usuario, correoelectronico_empleado = @correoelectronico_empleado, telefono_empleado = @telefono_empleado, administrador = @administrador, contraseña = @contraseña WHERE id_empleado = @id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre_empleado", nombre);
                    command.Parameters.AddWithValue("@apellido_empleado", apellido);
                    command.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                    command.Parameters.AddWithValue("@correoelectronico_empleado", Correo);
                    command.Parameters.AddWithValue("@telefono_empleado", telefono);
                    command.Parameters.AddWithValue("@administrador", Administrador);
                    command.Parameters.AddWithValue("@contraseña", password);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM empleado WHERE id_empleado = @id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ObtenerContraseña(int id)
        {
            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT contraseña FROM empleado WHERE id_empleado = @id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener el valor de la contraseña desde la base de datos
                            string contraseña = reader.GetString(0);
                            return contraseña;
                        }
                        else
                        {
                            // Si no se encuentra el empleado con el ID proporcionado, puedes manejarlo como consideres apropiado
                            return null; // O lanzar una excepción o devolver un valor predeterminado según tus necesidades
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
