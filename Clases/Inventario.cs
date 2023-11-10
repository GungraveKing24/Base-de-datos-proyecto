using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_datos.Clases
{
    internal class Inventario
    {
        conexion conectar = new conexion();

        //Esto es para añadir productos
        public class DatosInventario
        {
            //productos
            public string nombre_producto { get; set; }
            public string descripcion { get; set; }
            public double precio_entrada { get; set; }
            public double precio_salida { get; set; }
            public DateTime fecha_ingreso { get; set; }
            public string categoria { get; set; }
            public int id_proveedor { get; set; }

            //stock
            public int cantidadstock { get; set; }
            public DateTime fecha_stock { get; set; }

            //movimiento
            public string tipo_movimiento { get; set; }
        }

        public void guardar(DatosInventario Datos)
        {
            string connectionString = conectar.conectar();
            int idProductoInsertado;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insertar un nuevo registro en la tabla producto (id_producto es autoincremental)
                        using (MySqlCommand command = new MySqlCommand("INSERT INTO producto (nombre_producto, descripcion, precio_entrada, precio_salida, fecha_ingreso, categoria, id_proveedorproducto) VALUES (@nombre, @descripcion, @precio_entrada, @precio_salida, @fecha_ingreso, @categoria, @id_proveedorproducto); SELECT LAST_INSERT_ID();", connection, transaction))
                        {
                            // Configurar parámetros para el nuevo producto
                            command.Parameters.AddWithValue("@nombre", Datos.nombre_producto);
                            command.Parameters.AddWithValue("@descripcion", Datos.descripcion);
                            command.Parameters.AddWithValue("@precio_entrada", Datos.precio_entrada);
                            command.Parameters.AddWithValue("@precio_salida", Datos.precio_salida);
                            command.Parameters.AddWithValue("@fecha_ingreso", Datos.fecha_ingreso);
                            command.Parameters.AddWithValue("@categoria", Datos.categoria);
                            command.Parameters.AddWithValue("@id_proveedorproducto", Datos.id_proveedor);

                            // Obtener el ID del producto insertado
                            idProductoInsertado = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Insertar un nuevo registro en la tabla stock utilizando el ID del producto insertado
                        using (MySqlCommand command2 = new MySqlCommand("INSERT INTO stock (cantidadstock, fecha_stock, id_productostock) VALUES (@cantidadstock, @fecha_stock, @id_productostock);", connection, transaction))
                        {
                            // Configurar parámetros para el nuevo registro en stock
                            command2.Parameters.AddWithValue("@cantidadstock", Datos.cantidadstock);
                            command2.Parameters.AddWithValue("@fecha_stock", Datos.fecha_stock);
                            command2.Parameters.AddWithValue("@id_productostock", idProductoInsertado);

                            // Ejecutar la inserción en stock
                            command2.ExecuteNonQuery();
                        }

                        using (MySqlCommand command2 = new MySqlCommand("INSERT INTO movimiento_inventario (fecha_movimiento, cantidad_movimiento, tipo_movimiento, id_productomovimiento) VALUES (@fecha_movimiento, @cantidad_movimiento, @tipo_movimiento, @id_productomovimiento);", connection, transaction))
                        {
                            // Configurar parámetros para el nuevo registro en stock
                            command2.Parameters.AddWithValue("@fecha_movimiento", Datos.fecha_stock);
                            command2.Parameters.AddWithValue("@cantidad_movimiento", Datos.cantidadstock);
                            command2.Parameters.AddWithValue("@tipo_movimiento", Datos.tipo_movimiento);
                            command2.Parameters.AddWithValue("@id_productomovimiento", idProductoInsertado);

                            // Ejecutar la inserción en stock
                            command2.ExecuteNonQuery();
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre una excepción, revertir la transacción
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void EliminarProducto(int idProducto)
        {
            string connectionString = conectar.conectar();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    // Iniciar la transacción si es necesario
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Eliminar las entradas correspondientes en la tabla stock
                            string deleteStockQuery = "DELETE FROM stock WHERE id_productostock = @id_producto";
                            using (MySqlCommand deleteStockCommand = new MySqlCommand(deleteStockQuery, connection, transaction))
                            {
                                deleteStockCommand.Parameters.AddWithValue("@id_producto", idProducto);
                                deleteStockCommand.ExecuteNonQuery();
                            }

                            //elimiar de la tabla movimiento
                            string deletemovimientoQuery = "DELETE FROM movimiento_inventario WHERE id_productomovimiento = @id_producto";
                            using (MySqlCommand deletemovimientoCommand = new MySqlCommand(deletemovimientoQuery, connection, transaction))
                            {
                                deletemovimientoCommand.Parameters.AddWithValue("@id_producto", idProducto);
                                deletemovimientoCommand.ExecuteNonQuery();
                            }

                            //eliminar de la tabla pedido_reposicion
                            string deletepedidoQuery = "DELETE FROM pedido_reposicion WHERE id_productopedido = @id_producto";
                            using (MySqlCommand deletepedidoCommand = new MySqlCommand(deletepedidoQuery, connection, transaction))
                            {
                                deletepedidoCommand.Parameters.AddWithValue("@id_producto", idProducto);
                                deletepedidoCommand.ExecuteNonQuery();
                            }

                            // Eliminar el producto de la tabla producto
                            string deleteProductoQuery = "DELETE FROM producto WHERE id_producto = @id_producto";
                            using (MySqlCommand deleteProductoCommand = new MySqlCommand(deleteProductoQuery, connection, transaction))
                            {
                                deleteProductoCommand.Parameters.AddWithValue("@id_producto", idProducto);
                                deleteProductoCommand.ExecuteNonQuery();
                            }

                            // Confirmar la transacción
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Si ocurre una excepción, revertir la transacción
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void modificar(string nombre, string categoria, double precioE, double precioS, int proovedorid, string descripcion, int idProducto)
        {
            try 
            {
                string connectionString = conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE producto SET nombre_producto = @nombre_producto, descripcion = @descripcion, precio_entrada = @precio_entrada, precio_salida = @precio_salida, fecha_ingreso = @fecha_ingreso, categoria = @categoria, id_proveedorproducto = @id_proveedorproducto WHERE id_producto = @id_producto";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre_producto", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precio_entrada", precioE);
                    command.Parameters.AddWithValue("@precio_salida", precioS);
                    command.Parameters.AddWithValue("@fecha_ingreso", DateTime.Now); // Puedes establecer la fecha actual o modificar según sea necesario
                    command.Parameters.AddWithValue("@categoria", categoria);
                    command.Parameters.AddWithValue("@id_proveedorproducto", proovedorid);
                    command.Parameters.AddWithValue("@id_producto", idProducto);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }
    }
}
