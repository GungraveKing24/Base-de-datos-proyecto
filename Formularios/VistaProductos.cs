using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos
{
    public partial class VistaProducto : Form
    {
        readonly conexion GetConexion = new conexion();

        public VistaProducto()
        {
            InitializeComponent();
            LoadData();
            
        }


        //cargar datos
        private void LoadData()
        {
           
            string connectionString = GetConexion.conectar();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT p.id_producto, p.nombre_producto, p.precio_entrada, p.precio_salida, p.categoria, st.id_stock, st.cantidadstock, st.fecha_stock " +
                                "FROM producto p " +
                                "JOIN stock st ON p.id_producto = st.id_productostock";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                DatagridStock.DataSource = dataTable;

                // Asociar el evento CellFormatting
                DatagridStock.CellFormatting += DatagridStock_CellFormatting;
            }
            
        }

        private void DatagridStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DatagridStock.Columns["cantidadstock"].Index)
            {
                int cantidadStock = -1;
                if (e.Value != null)
                    cantidadStock = Convert.ToInt32(e.Value);

                if (cantidadStock <= 10)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (cantidadStock > 10 && cantidadStock <= 19)
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                }
                if (cantidadStock >= 20)
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }


        //Boton Conexion
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = GetConexion.conectar();
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Conexión exitosa a la base de datos MySQL.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}