using Base_de_datos;
using Base_de_datos.Clases;
using Base_de_datos.Formularios;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Base_de_datos.Clases.Inventario;
using static Base_de_datos.Clases.Proveedor;

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

            int idEmpleado = Login.IdEmpleado;
            bool empleado = Login.GetAdmin;
            txt_id_empleado.Text = idEmpleado.ToString();  
            txt_administrador.Text = empleado.ToString();
        }

        private void CargarDatosProveedor()
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id_proveedor, nombre_proveedor, telefono_proveedor, correoelectronico_proveedor, ciudad_proveedor " +
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

                            int rowIndex = dgvProveedores.Rows.Add(ID, NombrePro, Telefono_proveedor, Correo_proveedor, Ciudad);

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
                    string query = "SELECT pe.id_pedido_reposicion, p.nombre_proveedor, pr.nombre_producto, pe.fecha_reposicion, pe.cantidad_reposicion, pe.estadodepedido, pr.id_producto, st.id_stock, ifi.descripcion_informe, p.id_proveedor FROM proveedor p JOIN producto pr ON p.id_proveedor = pr.id_proveedorproducto JOIN pedido_reposicion pe ON pe.id_productopedido = pr.id_producto JOIN stock st ON st.id_productostock = pr.id_producto JOIN informesinventario ifi ON ifi.id_producto_informe = pr.id_producto;";
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
                            string descripcion = reader.GetString(8);
                            int id_proveedor = reader.GetInt32(9);

                            int rowIndex = dgvProveedoresRepocision.Rows.Add(ID, NombreProveedor, NombreProducto, Fecha_reposicion, cantidad, estado, id_producto, id_stock, descripcion, id_proveedor);

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
                MessageBox.Show("El pedido fue rachazado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El rechazo a fallado" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AceptarPedido()
        {
            try
            {
                //para stock
                int id_stock = Convert.ToInt32(txt_id_stock.Text);
                int cantidad = Convert.ToInt32(txt_cantidad.Text);

                //Compartidos
                DateTime Fecha_Actual = DateTime.Now;

                //Para poner que a sido aceptado
                string stockestado = "Aceptado";
                int idpedido_repo = Convert.ToInt32(txt_id_Reposicion.Text);

                //informe inventario
                int id_producto = Convert.ToInt32(txt_id_Producto.Text);
                int id_empleado = Convert.ToInt32(txt_id_empleado.Text);

                //datos para la descripcion del informe
                Proveedor proveedor = new Proveedor();
                string nombre_producto = txt_nombre_producto.Text;
                int id_proveedor = Convert.ToInt32(txt_id_proveedor.Text);

                string nombreEmpleado = proveedor.ObtenerNombreEmpleado(id_empleado); // Supongamos que tienes el ID del empleado
                string nombreProveedor = proveedor.ObtenerNombreProveedor(id_proveedor);
                string descripcion_informe = "El producto reabastecido fue: " + nombre_producto + "en la fecha: " + Fecha_Actual + "con una cantidad total de: " + cantidad + " por el proveedor:" + nombreProveedor + "En el turno de: " + nombreEmpleado;
                
                // Create an instance of the Proveedor class

                // Create a DatosStock object and set its properties
                DatosStock datosStock = new DatosStock
                {
                    //dato para rellenar el stock
                    id_stock = id_stock,
                    cantidadstock = cantidad,

                    //Dato para informe
                    descripcion_informe = descripcion_informe,
                    id_producto_informe = id_producto,
                    id_empleado_informe = id_empleado,
                        
                    //Dato compartido
                    fecha_actual = Fecha_Actual,

                    //Dato pedido resctock aceptado
                    estado_pedido = stockestado,
                    id_pedido_reposicion = idpedido_repo
                };

                // Call the Aceptado method with the DatosStock object as a parameter
                proveedor.Aceptado(datosStock);
                MessageBox.Show("Pedido aceptado y procesado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue aceptado debido a un fallo " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //para añadir usuario
        private void agregar_usuario()
        {
            try
            {
                string nombre_proveedor = txt_nombre.Text;
                int telefono_proveedor = Convert.ToInt32(txt_telefono.Text);
                string correo = txt_correo.Text;
                string ciudad = txt_ciudad.Text;
                
                Proveedor proveedor = new Proveedor();
                proveedor.UsuarioAdd(nombre_proveedor, telefono_proveedor, correo, ciudad);
                MessageBox.Show("El proveedor fue agregado con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo una falla al agregar un proveedor" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Close();
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            AceptarPedido();
            dgvProveedoresRepocision.Rows.Clear();
            CargarDatosReposicion();
        }

        private void Btn_rechazar_Click(object sender, EventArgs e)
        {
            rechazo();
            dgvProveedoresRepocision.Rows.Clear();
            CargarDatosReposicion();
        }

        //Metodos para crear los proveedores

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            agregar_usuario();
            dgvProveedores.Rows.Clear();
            CargarDatosProveedor();
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
                txt_cantidad.Text = Convert.ToString(row.Cells[4].Value);

                txt_id_Producto.Text = Convert.ToString(row.Cells[6].Value);
                txt_id_stock.Text = Convert.ToString(row.Cells[7].Value);
                txt_descripcion.Text = Convert.ToString(row.Cells[8].Value);
                txt_id_proveedor.Text = Convert.ToString(row.Cells[9].Value);

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
                else if (row.Cells[5].Value != null && row.Cells[5].Value?.ToString() == "Rechazado")
                {
                    chk_estado.Enabled = true;
                    chk_estado.Checked = false;
                    Btn_aceptar.Enabled = false;
                    Btn_rechazar.Enabled = false;
                } 
            }
        }

        //Funciones para cerrar
        private void Btn_terminar_Click(object sender, EventArgs e)
        {
            frmProveedores_FormClosing(this, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void btn_terminado_Click_1(object sender, EventArgs e)
        {
            frmProveedores_FormClosing(this, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void frmProveedores_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmProveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }
    }
}
