using Base_de_datos;
using Base_de_datos.Clases;
using Base_de_datos.Formularios;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Base_de_datos.Clases.Inventario;
using static Base_de_datos.Formularios.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Machote_Admin_Bases_D
{
    public partial class frmInventario : Form
    {
        readonly conexion GetConexion = new conexion(); //Llamar la clase conexion

        public frmInventario()
        {
            InitializeComponent();
            CargarDatos();
    
            //Cargar los combobox con datos
            categoriaBox(); 
            provedorbox();

            bloquear();
        }

        public void ReloadData()
        {
            dgvProductos.Rows.Clear();
        }

        private void bloquear()
        {
            Login login = new Login();
            bool admin = login.Admin();

            if (admin)
            {
                txt_administrador.Text = "1";
                panel_inventario.Visible = true;
            }
            else 
            {
                panel_inventario.Visible = false;
                txt_administrador.Text = "0";
                this.Width = 850;
                this.Height = 400;
            }
        }

        //metodo cargar datos
        public void CargarDatos()
        {
            try
            {
                dgvProductos.DataSource = null;
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT p.id_producto, p.nombre_producto,  p.categoria, st.cantidadstock,  p.precio_entrada, p.precio_salida, st.fecha_stock, p.descripcion ,pr.nombre_proveedor, pr.id_proveedor FROM producto p JOIN stock st ON p.id_producto = st.id_productostock JOIN proveedor pr ON p.id_proveedorproducto = pr.id_proveedor";
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
                            string  descripcion = reader.GetString(7);
                            string nombre_proveedor = reader.GetString(8);
                            int ID_Proveedor = reader.GetInt32(9);


                            int rowIndex = dgvProductos.Rows.Add(ID, Nombre, categoria, CantidadStock,  PrecioEntrada, PrecioSalida, FechaStock, descripcion, nombre_proveedor, ID_Proveedor);

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

        private void categoriaBox()
        {
            string connectionString = GetConexion.conectar();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();

                // Aquí ejecutarás la consulta y poblarás el ComboBox

                string query = "SELECT categoria FROM producto GROUP BY categoria;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Verifica si hay filas en el resultado
                        if (reader.HasRows)
                        {
                            // Itera a través de las filas y agrega los datos al ComboBox
                            while (reader.Read())
                            {
                                string nombre = reader.GetString(0);
                                cmb_categoria.Items.Add(nombre);
                            }
                        }
                    }
                }
            }
        }

        private void provedorbox()
        {
            string connectionString = GetConexion.conectar();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Aquí ejecutarás la consulta y poblarás el ComboBox

                string query = "SELECT id_proveedor, nombre_proveedor FROM proveedor;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Verifica si hay filas en el resultado
                        if (reader.HasRows)
                        {
                            // Itera a través de las filas y agrega los datos al ComboBox
                            while (reader.Read())
                            {
                                int idProveedor = reader.GetInt32(0);
                                string nombreProveedor = reader.GetString(1);
                                cmb_proveedor.Items.Add(nombreProveedor);

                                // Asocia el ID del proveedor al nombre del proveedor en un diccionario
                                // para poder recuperar el ID cuando se seleccione un proveedor en el ComboBox
                                proveedorIds.Add(nombreProveedor, idProveedor);
                            }
                        }
                    }
                }
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

        private void Guardar()
        {
            try
            {
                ErrorProvider errorProvider = new ErrorProvider();

                //Datos para productos
                string nombreProducto = txt_nombre.Text;
                string descripcion = txt_descripcion.Text;
                string categoria = cmb_categoria.Text;
                double precio_entrada = Convert.ToDouble(txt_pEntrada.Text);
                double precio_Salida = Convert.ToDouble(txt_pSalida.Text);
                string proveedor = cmb_proveedor.Text;
                int id_proveedor = Convert.ToInt32(txt_id_proveedor.Text);

                //stock
                int cantidadstock = (int)nudStock.Value;

                //Datos para stock
                int stock = Convert.ToInt32(nudStock.Value);

                //Dato compartido
                DateTime fecha_stock = DateTime.Now;

                //dato movimiento inventario
                string tipo_movimiento = "Agregado";

                Inventario inventario = new Inventario();
                DatosInventario datosInventario = new DatosInventario
                {
                    //productos
                    nombre_producto = nombreProducto,
                    descripcion = descripcion,
                    precio_entrada = precio_entrada,
                    precio_salida = precio_Salida,
                    fecha_ingreso = fecha_stock,
                    categoria = categoria,
                    id_proveedor = id_proveedor,

                    //datos para sotck
                    cantidadstock = cantidadstock,
                    fecha_stock = fecha_stock,

                    //datos para movimiento inventario
                    tipo_movimiento = tipo_movimiento
                };
                inventario.guardar(datosInventario);
                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Eliminar()
        {
            int id_producto = Convert.ToInt32(txt_id.Text);

            try
            {
                Inventario inventario = new Inventario();
                inventario.EliminarProducto(id_producto);
                MessageBox.Show("Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificar()
        {
            try
            {
                int id_producto = Convert.ToInt32(txt_id.Text);
                string nombre = txt_nombre.Text;
                string categoria = cmb_categoria.Text;
                double precioE = Convert.ToDouble(txt_pEntrada.Text);
                double precioS = Convert.ToDouble(txt_pSalida.Text);
                int proveedor = Convert.ToInt32(txt_id_proveedor.Text);
                string descripcion = txt_descripcion.Text;

                Inventario inventario = new Inventario();
                inventario.modificar(nombre, categoria, precioE, precioS, proveedor, descripcion, id_producto);
                MessageBox.Show("Producto modificado correctamente!!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiador()
        {
            txt_id.Clear();
            txt_nombre.Clear();
            txt_pEntrada.Clear();
            txt_pSalida.Clear();
            txt_descripcion.Clear();
            txt_id_proveedor.Clear();
        }

        //botones crud
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Guardar();
            dgvProductos.Rows.Clear();
            CargarDatos();
            limpiador();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar();
            dgvProductos.Rows.Clear();
            CargarDatos();
            limpiador();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Eliminar();
                dgvProductos.Rows.Clear();
                CargarDatos();
            }
        }


        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                DataGridViewRow row = dgvProductos.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                txt_id.Text = Convert.ToString(row.Cells[0].Value);
                txt_nombre.Text = Convert.ToString(row.Cells[1].Value);
                cmb_categoria.Text = Convert.ToString(row.Cells[2].Value);
                nudStock.Text = Convert.ToString(row.Cells[3].Value);
                txt_pEntrada.Text = Convert.ToString(row.Cells[4].Value);
                txt_pSalida.Text = Convert.ToString(row.Cells[5].Value);
                cmb_proveedor.Text = Convert.ToString(row.Cells[8].Value);
                txt_descripcion.Text = Convert.ToString(row.Cells[7].Value);
                txt_id_proveedor.Text = Convert.ToString(row.Cells[9].Value);
                
            }
        }

        private void cmb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si el ComboBox tiene un elemento seleccionado
            if (cmb_proveedor.SelectedItem != null)
            {
                // Obtiene el nombre del proveedor seleccionado
                string nombreProveedor = cmb_proveedor.SelectedItem.ToString();

                // Recupera el ID del proveedor del diccionario usando el nombre del proveedor como clave
                if (proveedorIds.TryGetValue(nombreProveedor, out int idProveedor))
                {
                    // Muestra el ID del proveedor en el TextBox
                    txt_id_proveedor.Text = idProveedor.ToString();
                }
            }
        }
        //El diccionario contiene el combobox de proveedores con su ID, ejemplo (name proveedor, ID)
        private Dictionary<string, int> proveedorIds = new Dictionary<string, int>();

        //buscador
        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            string ColumnaBusqueda = txt_buscador.Text.Trim().ToLower();
            try
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
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

        //Botones funciones no explicar
        private void btn_modificar_MouseHover(object sender, EventArgs e)
        {
            label5.Hide();
            nudStock.Hide();
        }

        private void btn_agregar_MouseHover(object sender, EventArgs e)
        {
            label5.Show();
            nudStock.Show();
        }

        private void btn_eliminar_MouseHover(object sender, EventArgs e)
        {
            label5.Show();
            nudStock.Show();
        }

        //Botones para cerrar
        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmInventario_FormClosing(this, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void frmInventario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmInventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiador();
        }
    }
}
