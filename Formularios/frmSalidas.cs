using Base_de_datos;
using Machote_Admin_Bases_D;
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

namespace Base_de_datos.Formularios
{
    public partial class frmSalidas : Form
    {
        readonly conexion GetConexion = new conexion(); //Llamar la clase conexion
        public frmSalidas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()      //movimiento inventario
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id_movimiento, fecha_movimiento, cantidad_movimiento, tipo_movimiento " +
                                    "FROM movimiento_inventario  " +
                                    "JOIN producto  ON  id_producto = id_productomovimiento";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(0);
                            DateTime Fecha_movimiento = reader.GetDateTime(1);
                            int Cantidad = reader.GetInt32(2);
                            string Tipo_movimiento = reader.GetString(3);

                            int rowIndex = dgvSalidas.Rows.Add(ID, Fecha_movimiento, Cantidad, Tipo_movimiento);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
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
