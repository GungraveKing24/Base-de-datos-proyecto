using Base_de_datos;
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

namespace Machote_Admin_Bases_D
{
    public partial class frmProveedores : Form
    {
        readonly conexion GetConexion = new conexion(); //Llamar la clase conexion

        public frmProveedores()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id_proveedor, nombre_proveedor, telefono_proveedor, correoelectronico_proveedor, ciudad_proveedor, descripcion " +
                                    "FROM proveedor p ";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(0);
                            string NombrePro = reader.GetString(1);
                            string Telefono_proveedor = reader.GetString(2);
                            string Correo_proveedor = reader.GetString(3);
                            string Ciudad = reader.GetString (4);
                            string descripcion = reader.GetString(5);
                

                            int rowIndex = dgvProveedores.Rows.Add(ID, NombrePro, Telefono_proveedor, Correo_proveedor, Ciudad, descripcion);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Close();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
