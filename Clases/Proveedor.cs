using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Base_de_datos.Clases.Inventario;

namespace Base_de_datos.Clases
{
    internal class Proveedor
    {
        conexion Conectar = new conexion();

        public void Rechazado(int id_pedido_reposicion, string estado_de_pedido)
        {
            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE pedido_reposicion SET estadodepedido = @estadodepedido WHERE id_pedido_reposicion = @id_pedido_reposicion;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@estadodepedido", estado_de_pedido);
                    command.Parameters.AddWithValue("@id_pedido_reposicion", id_pedido_reposicion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public class DatosStock
        {
            //Datos para actualizar stock en SUMA
            public int id_stock { get; set; }
            public int cantidadstock { get; set; }

            //Datos para informeinventario
            public string descripcion_informe {  get; set; }
            public int id_producto_informe { get; set; }
            public int id_empleado_informe { get; set; }

            //Dato compartido
            public DateTime fecha_actual {  get; set; }

            //Dato pedido de reposicion
            public string estado_pedido {  get; set; }
            public int id_pedido_reposicion { get; set; }
        }

        public void Aceptado(DatosStock Datos)
        {
            string connectionString = Conectar.conectar();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryTabla1 = "Update stock SET cantidadstock = cantidadstock + @cantidadstock, Fecha_stock = @Fecha_stock WHERE id_stock = @id_stock;";

                        string queryTabla2 = "INSERT INTO informesinventario (fecha_informe, descripcion_informe, id_producto_informe, id_empleado_informe) VALUES (@fecha_informe, @descripcion_informe, @id_producto_informe, @id_empleado_informe)";

                        string queryTabla3 = "UPDATE pedido_reposicion SET estadodepedido = @estadodepedido WHERE id_pedido_reposicion = @id_pedido_reposicion;";
                        using (MySqlCommand cmd1 = new MySqlCommand(queryTabla1, connection, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@cantidadstock",Datos.cantidadstock);
                            cmd1.Parameters.AddWithValue("@Fecha_stock", Datos.fecha_actual);
                            cmd1.Parameters.AddWithValue("@id_stock", Datos.id_stock);
                            cmd1.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd2 = new MySqlCommand(queryTabla2, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@fecha_informe", Datos.fecha_actual);
                            cmd2.Parameters.AddWithValue("@descripcion_informe", Datos.descripcion_informe);
                            cmd2.Parameters.AddWithValue("@id_producto_informe", Datos.id_producto_informe);
                            cmd2.Parameters.AddWithValue("@id_empleado_informe", Datos.id_empleado_informe);
                            cmd2.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd3 = new MySqlCommand(queryTabla3, connection, transaction))
                        {
                            cmd3.Parameters.AddWithValue("@estadodepedido", Datos.estado_pedido);
                            cmd3.Parameters.AddWithValue("@id_pedido_reposicion", Datos.id_pedido_reposicion);
                            cmd3.ExecuteNonQuery();
                        }

                        // Si llegas a este punto sin excepciones, la transacción se completa correctamente
                        transaction.Commit();
                        MessageBox.Show("Datos insertados en ambas tablas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre una excepción, se revierte la transacción
                        transaction.Rollback();
                        MessageBox.Show("Error al insertar datos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void UsuarioAdd(string nombre, int telefono, string correo, string ciudad)
        {
            conexion Conectar = new conexion();

            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO proveedor (nombre_proveedor, telefono_proveedor, correoelectronico_proveedor, ciudad_proveedor) VALUES (@nombre_proveedor, @telefono, @correo, @ciudad)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre_proveedor", nombre);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@ciudad", ciudad);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ObtenerNombreEmpleado(int idEmpleado)
        {
            string nombreEmpleado = string.Empty;
            conexion Conectar = new conexion();

            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id_empleado, nombre_empleado FROM empleado WHERE id_empleado = @id_empleado;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_empleado", idEmpleado);

                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreEmpleado = reader["nombre_empleado"].ToString();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return nombreEmpleado;
        }

        public string ObtenerNombreProveedor(int idProveedor)
        {
            string nombreProveedor = string.Empty;
            conexion Conectar = new conexion();

            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id_proveedor, nombre_proveedor FROM proveedor WHERE id_proveedor = @id_proveedor;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_proveedor", idProveedor);

                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreProveedor = reader["nombre_proveedor"].ToString();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return nombreProveedor;
        }
    }
}
