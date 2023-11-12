using MySqlConnector;
using System;
using System.Data;

public class Informe
{
    private string connectionString = "Server=localhost;Database=mecare;Uid=root;Pwd=852456;";

    public DataTable ObtenerInformes()
    {
        DataTable informesTable = new DataTable();

        try
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                string consulta = @"
                    SELECT 
                        p.id_producto AS 'Id Producto',
                        p.nombre_producto AS 'Nombre Producto',
                        e.nombre_empleado AS 'Nombre Empleado',
                        e.apellido_empleado AS 'Apellido Empleado',
                        p.precio_entrada AS 'Precio Entrada',
                        pr.fecha_reposicion AS 'Fecha de Reposición',
                        s.cantidad_reposicion AS 'Cantidad Stock'
                    FROM producto p
                    JOIN informesinventario i ON p.id_producto = i.id_producto_informe
                    JOIN empleado e ON i.id_empleado_informe = e.id_empleado
                    JOIN pedido_reposicion s ON p.id_producto = s.id_productopedido
                    JOIN pedido_reposicion pr ON p.id_producto = pr.id_productopedido;";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(informesTable);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener los informes: " + ex.Message);
        }

        return informesTable;
    }

}
