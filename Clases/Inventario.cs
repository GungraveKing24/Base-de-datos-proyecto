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
        conexion conexion = new conexion();

        public class Datos_Stock
        {
            //datos del stock
            int id_stock { get; set; }
            int cantidadStock { get; set; }
            public string descripcion { get; set; }
            int id_productostock { get; set; }
        }

        public class Datos_Producto
        {
            int id_producto { get; set; }
            string nombre_producto { get; set; }
            string descripcion { get; set; }
            double precio_entrada { get; set; }
            double precio_salida { get; set; }
            DateTime Fecha_ingreso { get; set; }
            int id_proveedorproducto { get; set; }
        }

        public class Datos_Pedido_Repocision
        {
            int id_pedido { get; set; }
            DateTime Fecha_Repocicion { get; set; }
            int Cantidad_Reposicion { get; set; }
            string Estado_Pedido { get; set; }
            int id_productopedido { get; set; }
        }

        public class informe_Inventario
        {
            int id_informe { get; set; }
            DateTime fecha_informe { get; set; }
            string descripcion_informe { get; set; }
            int id_producto_informe { get; set; }
            int id_empleado_informe { get; set; }
        }

        public class empleado
        {
            int id_empleado { get; set; }
            string nombre_empleado { get; set; }
        }

        public class movimiento_inventario
        {
            int id_movimiento { get; set; }
            DateTime fecha_movimiento { get; set; }
            int cantidad_movimiento { get; set; }
            string tipo_movimiento { get; set; }
            int id_productomovimiento {  get; set; }
        }

        public void guardar() 
        {
            string connectionString = conexion.conectar();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Aquí realizarás las operaciones de inserción en las tablas
            }
        }
    }
}
