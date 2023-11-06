﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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

        public class Empleado
        {
            public int id_empleado { get; set; }
            public string nombre_empleado { get; set; }
        }

        public class movimiento_inventario
        {
            public int id_movimiento { get; set; }
            public DateTime fecha_movimiento { get; set; }
            public int cantidad_movimiento { get; set; }
            public string tipo_movimiento { get; set; }
            public int id_productomovimiento { get; set; }
        }

        public void guardar(Empleado empleado, movimiento_inventario movimiento)
        {
            string connectionString = conexion.conectar();

          
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryTabla1 = "INSERT INTO tabla1 (columna1, columna2) VALUES (@valor1, @valor2)";
                        string queryTabla2 = "INSERT INTO tabla2 (columna3, columna4) VALUES (@valor3, @valor4)";
                        string queryTabla3 = "INSERT INTO tabla2 (columna5, columna6) VALUES (@valor5, @valor6)";

                        using (MySqlCommand cmd1 = new MySqlCommand(queryTabla1, connection, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@valor1", empleado.id_empleado);
                            cmd1.Parameters.AddWithValue("@valor2", empleado.nombre_empleado);
                            cmd1.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd2 = new MySqlCommand(queryTabla2, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@valor3", movimiento.id_movimiento);
                            cmd2.Parameters.AddWithValue("@valor4", movimiento.fecha_movimiento);
                            cmd2.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd3 = new MySqlCommand(queryTabla3, connection, transaction))
                        {
                            cmd3.Parameters.AddWithValue("@valor3", movimiento.id_movimiento);
                            cmd3.Parameters.AddWithValue("@valor4", movimiento.fecha_movimiento);
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
