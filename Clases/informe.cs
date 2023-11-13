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
                SELECT inf.id_informe AS ""Id Informe"", 
	                inf.fecha_informe AS ""Fecha Informe"", 
                    en.nombre_empleado AS ""Nombre de Empleado"", 
                    en.apellido_empleado AS ""Apellido de Empleado"", 
	                p.id_producto AS ""Id Producto"", 
	                p.nombre_producto AS ""Producto"", 
                    inf.descripcion_informe AS ""Descripcion"" 
                FROM informesinventario inf
                JOIN producto p ON p.id_producto = inf.id_producto_informe
                JOIN empleado en ON en.id_empleado = inf.id_empleado_informe;";

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
