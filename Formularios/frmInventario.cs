using Base_de_datos;
using Base_de_datos.Formularios;
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
                    string query = "SELECT p.id_producto, p.nombre_producto,  p.categoria, st.cantidadstock,  p.precio_entrada, p.precio_salida, st.fecha_stock, pr.nombre_proveedor FROM producto p JOIN stock st ON p.id_producto = st.id_productostock JOIN proveedor pr ON p.id_proveedorproducto = pr.id_proveedor";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(0);
                            string Nombre = reader.GetString(1);
                            string categoria = reader.GetString(2);
                            int CantidadStock = reader.GetInt32(3);
                            double PrecioEntrada = reader.GetDouble(4);
                            double PrecioSalida = reader.GetDouble(5);
                            DateTime FechaStock = reader.GetDateTime(6);
                            string ID_Proveedor = reader.GetString(7);


                            int rowIndex = dgvProductos.Rows.Add(ID, Nombre, categoria, CantidadStock,  PrecioEntrada, PrecioSalida, FechaStock, ID_Proveedor);

                            dgvProductos.CellFormatting += dgvProductos_CellFormatting;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProductos.Columns["cantidadstock"].Index)
            {
                int cantidadStock = -1;
                if (e.Value != null)
                    cantidadStock = Convert.ToInt32(e.Value);

                if (cantidadStock <= 5)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (cantidadStock > 6 && cantidadStock <= 19)
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                }
                if (cantidadStock >= 20)
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            txt_nombre.Text = login.loginName();
            
        }

        private void Invertario_Load(object sender, EventArgs e)
        {
        }

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
