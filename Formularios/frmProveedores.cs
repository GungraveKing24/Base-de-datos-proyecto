using Base_de_datos;
using Base_de_datos.Clases;
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
            CargarDatosProveedor();
            CargarDatosReposicion();
        }
        private void CargarDatosProveedor()
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

        private void CargarDatosReposicion()
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT pe.id_pedido_reposicion, p.nombre_proveedor, pr.nombre_producto, pe.fecha_reposicion, pe.cantidad_reposicion, pe.estadodepedido, pr.id_producto, st.id_stock FROM proveedor p Join producto pr ON p.id_proveedor = pr.id_proveedorproducto  JOIN pedido_reposicion pe ON pe.id_productopedido = pr.id_producto JOIN stock st ON st.id_productostock = pr.id_producto;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(0);
                            string NombreProveedor = reader.GetString(1);
                            string NombreProducto = reader.GetString(2);
                            DateTime Fecha_reposicion = reader.GetDateTime(3);
                            int cantidad = reader.GetInt32(4);
                            string estado = reader.GetString(5);
                            int id_producto = reader.GetInt32(6);
                            int id_stock = reader.GetInt32(7);


                            int rowIndex = dgvProveedoresRepocision.Rows.Add(ID, NombreProveedor, NombreProducto, Fecha_reposicion, cantidad, estado, id_producto, id_stock);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo rechazo
        private void rechazo()
        {
            int idpedido_repo = Convert.ToInt32(txt_id_Reposicion.Text);
            string estado = "Rechazado";
            try
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Rechazado(idpedido_repo, estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AceptarPedido()
        {
            try
            {
                Proveedor proveedor = new Proveedor();
                //proveedor.Aceptado();
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            AceptarPedido();
        }

        private void Btn_rechazar_Click(object sender, EventArgs e)
        {
            rechazo();
        }

        private void dgvProveedoresRepocision_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {

        }

        private void dgvProveedoresRepocision_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedoresRepocision.CurrentRow != null)
            {
                DataGridViewRow row = dgvProveedoresRepocision.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                txt_id_Reposicion.Text = Convert.ToString(row.Cells[0].Value);
                txt_nombre_proveedor.Text = Convert.ToString(row.Cells[1].Value);
                txt_nombre_producto.Text = Convert.ToString(row.Cells[2].Value);

                txt_id_Producto.Text = Convert.ToString(row.Cells[6].Value);
                txt_id_stock.Text = Convert.ToString(row.Cells[7].Value);



                if (row.Cells[5].Value != null && row.Cells[5].Value?.ToString() == "Completado")
                {
                    chk_estado.Enabled = true;
                    chk_estado.Checked = true;
                    Btn_aceptar.Enabled = false;
                    Btn_rechazar.Enabled = false;
                }
                if (row.Cells[5].Value != null && row.Cells[5].Value?.ToString() == "Pendiente")
                {
                    chk_estado.Enabled = false;
                    chk_estado.Checked = false;
                    Btn_aceptar.Enabled = true;
                    Btn_rechazar.Enabled = true;
                }
                else
                {
                    chk_estado.Enabled = true;
                    chk_estado.Checked = false;
                    Btn_aceptar.Enabled = false;
                    Btn_rechazar.Enabled = false;
                }

            }
        }

        private void Btn_terminar_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Close();
        }
    }
}
