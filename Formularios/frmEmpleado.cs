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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Machote_Admin_Bases_D
{
    public partial class frmEmpleado : Form
    {
       
        public frmEmpleado()
        {
            InitializeComponent();
            CargarDatos();
            style();
            limpiar();
        }
        //Cargar Empleados
        conexion GetConexion = new conexion();

        private void CargarDatos()
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM empleado;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(0);
                            string Nombre = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            string apellido = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                            string usuario = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string correo = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            int telefono = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                            bool admin = reader.IsDBNull(6) ? false : reader.GetBoolean(6);
                            DateTime Fecha = reader.IsDBNull(7) ? DateTime.MinValue : reader.GetDateTime(7);
                            string contrasena = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);

                            int rowIndex = dgvProductos.Rows.Add(ID, Nombre, apellido, usuario, correo, telefono, admin, Fecha, contrasena);
                                
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        //Variables
        private string nombre;
        private string apellido;
        private string usuarioName;
        private string correo;
        private int telefono;
        private string admin;
        private string fechaFormateada;
        private string contrasena;

        //verificar la entrada de datos
        public bool verificar_datos()
        {
            bool verificacion = false;

            try
            {
                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                usuarioName = txt_usuario.Text;
                correo = txt_correo.Text;
                contrasena = txt_contra.Text;

                // Verificar el estado del checkbox
                bool administrador = chk_admin.Checked;
                admin = administrador ? "1" : "0";

                // Obtener la fecha actual y formatearla
                DateTime fecha = DateTime.Now;
                fechaFormateada = fecha.ToString("yyyy-MM-dd");

                bool verificado1 = true;
                bool verificado2 = true;

                System.Windows.Forms.TextBox TextBoxFocus = null;

                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Por favor, ingrese el nombre correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado1 = false;
                    TextBoxFocus = txt_nombre;
                }

                if (string.IsNullOrWhiteSpace(apellido))
                {
                    MessageBox.Show("Por favor, ingrese el apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado1 = false;
                    TextBoxFocus = txt_apellido;
                }

                if (string.IsNullOrEmpty(usuarioName))
                {
                    MessageBox.Show("Por favor, ingrese el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado1 = false;
                    TextBoxFocus = txt_usuario;
                }

                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("Por favor, ingrese el correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado1 = false;
                    TextBoxFocus = txt_correo;
                }

                if (string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado1 = false;
                    TextBoxFocus = txt_contra;
                }

                if (TextBoxFocus != null)
                {
                    TextBoxFocus.Focus();
                }


                // Validar número de teléfono
                if (txt_telefono.Text.Length > 8 || !int.TryParse(txt_telefono.Text, out telefono))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido de hasta 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado2 = false;

                }

                if (verificado1 && verificado2)
                {
                    verificacion = true;
                }
            }
            catch
            {
            }

            return verificacion;
        }

        private void Agregar()
        {
            try
            {
                bool verificacion = verificar_datos();

                if (verificacion)
                {
                    Empleados empleados = new Empleados();
                    empleados.insertar(nombre, apellido, usuarioName, correo, telefono, admin, fechaFormateada, contrasena);

                    MessageBox.Show("Datos insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    dgvProductos.Rows.Clear();
                    CargarDatos();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al insertar datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }

        private void modificar()
        {
            try
            {
                int id = Convert.ToInt32(txt_id.Text);
                string nombre = txt_nombre.Text;
                string apellido = txt_apellido.Text;
                string usuarioName = txt_usuario.Text;
                string correo = txt_correo.Text;
                int telefono = Convert.ToInt32(txt_telefono.Text);
                string admin;
                if (chk_admin.Checked)
                {
                    admin = "1";
                }
                else
                {
                    admin = "0";
                }
                
                string contrasena = txt_contra.Text;
                bool clave = false;
                if (string.IsNullOrWhiteSpace(contrasena))
                {
                    clave = false;
                }
                else
                {
                    clave = true;
                }

                if (clave == true)
                {
                    Empleados empleados = new Empleados();
                    empleados.Update(id, nombre, apellido, usuarioName, correo, telefono, admin, contrasena);
                    MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvProductos.Rows.Clear();
                    CargarDatos();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Error al modificar datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminar()
        {
            try
            {
                int id = Convert.ToInt32(txt_id.Text);
                Empleados empleados = new Empleados();


                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                      "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    empleados.Delete(id);
                    MessageBox.Show("Registro eliminado correctamente de la base de datos.");
                    dgvProductos.Rows.Clear();
                    CargarDatos();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Se cancelo la operacion", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void limpiar()
        {
            txt_id.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_usuario.Clear();
            txt_correo.Clear();
            txt_telefono.Clear();
            txt_contra.Clear();
            chk_admin.Checked = false;
        }

        //estilo
        private void style()
        {
            //Cambia el color de los encabezados de la tabla
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 33, 74);
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dgvProductos.EnableHeadersVisualStyles = false;

            //Cambia el color de las celdas de la tabla
            dgvProductos.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 26, 87);
            dgvProductos.DefaultCellStyle.ForeColor = Color.Gainsboro;
            dgvProductos.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#30141f");


            dgvProductos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textoBusqueda = txt_busqueda.Text.Trim().ToLower();
                string filtrarbusqueda = Busqueda_filtro.SelectedItem.ToString();
                int ColumnaBusqueda = 0;

                if (filtrarbusqueda == "ID")
                {
                    ColumnaBusqueda = 0;
                }

                else if (filtrarbusqueda == "Nombre")
                {
                    ColumnaBusqueda = 1;
                }

                else if (filtrarbusqueda == "Apellido")
                {
                    ColumnaBusqueda = 2;
                }

                else if (filtrarbusqueda == "Usuario")
                {
                    ColumnaBusqueda = 3;
                }

                else if (filtrarbusqueda == "Correo")
                {
                    ColumnaBusqueda = 4;
                }

                else if (filtrarbusqueda == "Telefono")
                {
                    ColumnaBusqueda = 5;
                }

                int busqueda = ColumnaBusqueda;
            
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    // Obtener el valor de la celda de la columna específica en cada fila
                    string valorCelda = row.Cells[busqueda].Value?.ToString().ToLower();

                    // Verificar si el valor de la celda contiene el texto de búsqueda
                    bool filaVisible = !string.IsNullOrEmpty(valorCelda) && valorCelda.Contains(textoBusqueda);

                    row.Visible = filaVisible; // Mostrar u ocultar la fila según el resultado de la búsqueda
                }
            }
            catch
            {
                // Maneja las excepciones si es necesario
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
                txt_apellido.Text = Convert.ToString(row.Cells[2].Value);
                txt_usuario.Text = Convert.ToString(row.Cells[3].Value);
                txt_correo.Text = Convert.ToString(row.Cells[4].Value);
                txt_telefono.Text = Convert.ToString(row.Cells[5].Value);

                if (row.Cells[6].Value != null && (bool)row.Cells[6].Value)
                {
                    chk_admin.Checked = true;
                }
                else
                {
                    chk_admin.Checked = false;
                }
            }
        }
    }
}
