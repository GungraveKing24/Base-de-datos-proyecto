using Base_de_datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machote_Admin_Bases_D
{
    public partial class frmInventario : Form
    {
        readonly conexion GetConexion = new conexion(); //Llamar la clase conexion

        public frmInventario()
        {
            InitializeComponent();
            CargarDatos();
        }

        //metodo cargar datos
        private void CargarDatos()
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT p.id_producto, p.nombre_producto, p.precio_entrada, p.precio_salida, p.categoria, st.id_stock, st.cantidadstock, st.fecha_stock " +
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
                            double PrecioEntrada = reader.GetDouble(2);
                            double PrecioSalida = reader.GetDouble(3);
                            string categoria = reader.GetString(4);
                            int Stock = reader.GetInt32(5);
                            int CantidadStock = reader.GetInt32(6);
                            DateTime FechaStock = reader.GetDateTime(7);


                            int rowIndex = dgvProductos.Rows.Add(ID, Nombre, PrecioEntrada, PrecioSalida, categoria, Stock, CantidadStock, FechaStock);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void Invertario_Load(object sender, EventArgs e)
        {
        }

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
