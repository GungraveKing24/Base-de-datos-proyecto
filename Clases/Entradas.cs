using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_datos.Clases
{
    internal class Entradas
    {
        //Clase obligatoria de conexion
        conexion Conectar = new conexion();

        public class EntradaAPedido
        {
            public DateTime fecha_reposicion {  get; set; }
            public DateTime fecha_caducidad { get; set; }
            public int cantidad_reposicion { get; set; }
            public string estadodepedido {  get; set; }
            public int id_producto_pedido { get; set; }
        }

        public void agregar(EntradaAPedido Datos)
        {
            try
            {
                string connectionString = Conectar.conectar();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO pedido_reposicion (fecha_reposicion, fecha_caducidad, cantidad_reposicion, estadodepedido, id_productopedido) VALUES" +
                        "(@fecha_reposicion ,@fecha_caducidad, @cantidad_reposicion, @estadodepedido, @id_productopedido)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fecha_reposicion", Datos.fecha_reposicion);
                    command.Parameters.AddWithValue("@fecha_caducidad", Datos.fecha_caducidad);
                    command.Parameters.AddWithValue("@cantidad_reposicion", Datos.cantidad_reposicion);
                    command.Parameters.AddWithValue("@estadodepedido", Datos.estadodepedido);
                    command.Parameters.AddWithValue("@id_productopedido", Datos.id_producto_pedido);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
