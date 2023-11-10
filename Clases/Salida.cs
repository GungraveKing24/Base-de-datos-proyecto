using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos.Clases
{
    internal class Salida
    {
        conexion Conectar = new conexion();

        public class DatosSalida
        {
            public int id_movimiento { get; set; }
            public DateTime fecha_movimiento { get; set; }
            public int cantidad_movimientoS { get; set; }
            public string tipo_movimiento { get; set; }
            public int id_productomovimiento { get; set; }
        }

        public void disminuir(DatosSalida Datos)
        {
            string connectionString = Conectar.conectar();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryTabla1 = "Update stock SET cantidadstock = cantidadstock - @cantidadstock WHERE id_stock = @id_stock;";
                        //id_movimiento, fecha_movimiento, cantidad_movimiento, tipo_movimiento, id_productomovimiento
                        string queryTabla2 = "Update movimiento_inventario SET fecha_movimiento =@fecha_movimiento, tipo_movimiento = @tipo_movimiento WHERE id_movimiento = @id_movimiento";

                        using (MySqlCommand cmd1 = new MySqlCommand(queryTabla1, connection, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@cantidadstock", Datos.cantidad_movimientoS);
                            cmd1.Parameters.AddWithValue("@id_stock", Datos.id_productomovimiento);
                            cmd1.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd2 = new MySqlCommand(queryTabla2, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@fecha_movimiento", Datos.fecha_movimiento);
                            cmd2.Parameters.AddWithValue("@tipo_movimiento", Datos.tipo_movimiento);
                            cmd2.Parameters.AddWithValue("@id_movimiento", Datos.id_movimiento);
                            cmd2.ExecuteNonQuery();
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
    }
}
