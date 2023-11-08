using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            public DateTime fecha_stock { get; set; }

            //Datos para pedido reposicion
            public int id_pedido_reposicion { get; set; }
            public string estado_pedido { get; set; }

            //Datos para informeinventario
            public DateTime fecha_reposicion { get; set;}
            public string descripcion_informe {  get; set; }
            public int id_producto_informe { get; set; }
            public int id_empleado_informe { get; set; }
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
                        string queryTabla1 = "Update stock SET cantidadstock = cantidadstock + @cantidadstock, Fecha_stock = @Fecha_stock WHERE id_stock = @id_stock";

                        string queryTabla2 = "INSERT INTO informesinventario (fecha_informe, descripcion_informe, id_producto_informe, id_empleado_informe) " +
                                             "VALUES (@fecha_informe, @descripcion_informe, @id_producto_informe, @id_empleado_informe)";

                        string queryTabla3 = "INSERT INTO tabla2 () VALUES ()";

                        using (MySqlCommand cmd1 = new MySqlCommand(queryTabla1, connection, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@cantidadstock",Datos.cantidadstock);
                            cmd1.Parameters.AddWithValue("@Fecha_stock", Datos.fecha_stock);
                            cmd1.Parameters.AddWithValue("@id_stock", Datos.id_stock);
                            cmd1.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd2 = new MySqlCommand(queryTabla2, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@fecha_reposicion", Datos.fecha_reposicion);
                            cmd2.Parameters.AddWithValue("@descripcion_informe", Datos.descripcion_informe);
                            cmd2.Parameters.AddWithValue("@id_producto_informe", Datos.id_producto_informe);
                            cmd2.Parameters.AddWithValue("@id_empleado_informe", Datos.id_empleado_informe);
                            cmd2.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd3 = new MySqlCommand(queryTabla3, connection, transaction))
                        {
                            //cmd3.Parameters.AddWithValue("@valor3", movimiento.id_movimiento);
                            //cmd3.Parameters.AddWithValue("@valor4", movimiento.fecha_movimiento);
                            cmd3.ExecuteNonQuery();
                        }

                        // Si llegas a este punto sin excepciones, la transacción se completa correctamente
                        transaction.Commit();
                        Console.WriteLine("Datos insertados en ambas tablas correctamente.");
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre una excepción, se revierte la transacción
                        transaction.Rollback();
                        Console.WriteLine("Error al insertar datos: " + ex.Message);
                    }
                }
            }
        }
    }
}
