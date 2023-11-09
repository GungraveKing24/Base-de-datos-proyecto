using Base_de_datos.Clases;
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
using static Base_de_datos.Clases.Entradas;
using static Base_de_datos.Clases.Inventario;

namespace Base_de_datos.Formularios
{
    public partial class frmEntradas : Form
    {

        readonly conexion GetConexion = new conexion(); //Llamar la clase conexion
        public frmEntradas()
        {
            InitializeComponent();

            //Tablas de vista
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
                    string query = "SELECT id_pedido_reposicion, p.id_producto, pr.fecha_reposicion, pr.cantidad_reposicion, pr.estadodepedido, pr.fecha_caducidad " +
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

        private void Agregar()
        {
            //Datos para el pedido informe
            int id_producto = Convert.ToInt32(txt_idProducto.Text);
            int cantidadStock = (int)nudStock.Value;
            string estadopedido = "Pendiente";
            DateTime fecha_actual = DateTime.Now;
            DateTime fecha_caducidad = dateTimeFCaducidad.Value;

            try
            {
                Entradas EntradasRepo = new Entradas();
                EntradaAPedido entradas = new EntradaAPedido
                {
                    cantidad_reposicion = cantidadStock,
                    estadodepedido = estadopedido,
                    fecha_reposicion = fecha_actual,
                    fecha_caducidad = fecha_caducidad,
                    id_producto_pedido = id_producto
                };
                EntradasRepo.agregar(entradas);
                MessageBox.Show("Pedido agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Agregar();
            
            //Limpia las tablas
            dgvPedidos.Rows.Clear();
            dtvproductos.Rows.Clear();

            //llama las tablas
            CargarDatos();
            CargarDatosT2();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ColumnaBusqueda = txt_id.Text;
                foreach (DataGridViewRow row in dgvPedidos.Rows)
                {
                    string valorCelda = row.Cells[0].Value?.ToString().ToLower();

                    bool filaVisible = !string.IsNullOrEmpty(valorCelda) && valorCelda.Contains(ColumnaBusqueda);

                    row.Visible = filaVisible;
                }
            }
            catch
            {
            }
        }

        private void dtvproductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtvproductos.CurrentRow != null)
            {
                DataGridViewRow row = dtvproductos.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                txt_idProducto.Text = Convert.ToString(row.Cells[0].Value);
            }
        }

        //Opcion de cerrar formulario
        private void frmEntradas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre del formulario principal si el usuario elige "No".
            }
            else
            {
                // Muestra el formulario frmMain y oculta frmEmpleado
                frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.Show();
                }
                this.Hide();
            }
        }
    }
}
