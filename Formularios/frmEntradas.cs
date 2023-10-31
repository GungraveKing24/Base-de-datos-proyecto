using Machote_Admin_Bases_D;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos.Formularios
{
    public partial class frmEntradas : Form
    {

        readonly conexion GetConexion = new conexion(); //Llamar la clase conexion
        public frmEntradas()
        {
            InitializeComponent();
            CargarDatos();
            CargarDatosT2();
        }

        private void CargarDatos()
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT p.id_producto, p.nombre_producto, p.precio_salida, p.fecha_ingreso, st.cantidadstock, p.id_proveedorproducto " +
                                    "FROM producto p " +
                                    "JOIN stock st ON p.id_producto = st.id_productostock";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(0);
                            string Nombre = reader.GetString(1);
                            double PrecioSalida = reader.GetDouble(2);
                            DateTime FechaIngreso = reader.GetDateTime(3);
                            int CantidadStock = reader.GetInt32(4);
                            int ID_Proveedor = reader.GetInt32(5);

                            int rowIndex = dtvproductos.Rows.Add(ID, Nombre, PrecioSalida, FechaIngreso,  CantidadStock, ID_Proveedor);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void CargarDatosT2()
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id_pedido_reposicion, p.id_producto, pr.fecha_reposicion, pr.cantidad_reposicion, pr.estadodepedido, p.fecha_caducidad " +
                                   "FROM producto p " +
                                   "JOIN pedido_reposicion pr ON p.id_producto = pr.id_productopedido";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID_pr = reader.GetInt32(0);
                            int ID_p = reader.GetInt32(1);
                            DateTime FechaReposicion= reader.GetDateTime(2);
                            int Cantidad = reader.GetInt32(3);
                            string Estado = reader.GetString(4);
                            DateTime FechaCaducidad = reader.GetDateTime(5);
                        

                            int rowIndex = dgvPedidos.Rows.Add(ID_pr, ID_p, FechaReposicion, Cantidad, Estado, FechaCaducidad);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Close();
        }
    }
}
