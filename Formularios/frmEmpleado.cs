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

            Busqueda_filtro.Text = "ID"; //Solucion chafas
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

        ErrorProvider errorProvider1 = new ErrorProvider();

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

                //Verificacion Nombre
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    errorProvider1.SetError(txt_nombre, "Por favor, ingrese el nombre correcto.");
                    verificado1 = false;
                }
                else
                {
                    errorProvider1.SetError(txt_nombre, "");
                }
                //Verificacion Apellido
                if (string.IsNullOrWhiteSpace(apellido))
                {
                    errorProvider1.SetError(txt_apellido, "Por favor, ingrese el apellido correcto.");
                    verificado1 = false;
                }
                else
                {
                    errorProvider1.SetError(txt_apellido, "");
                }
                //Verificacion UsuarioName (Nombre de usuario)
                if (string.IsNullOrWhiteSpace(usuarioName))
                {
                    errorProvider1.SetError(txt_usuario, "Por favor, ingrese un usuario correcto.");
                    verificado1 = false;
                }
                else
                {
                    errorProvider1.SetError(txt_usuario, "");
                }
                //Verificacion Correo
                if (string.IsNullOrWhiteSpace(correo))
                {
                    errorProvider1.SetError(txt_correo, "Por favor, ingrese un correo valido");
                    verificado1 = false;
                }
                else
                {
                    errorProvider1.SetError(txt_correo, "");
                }
                //Verificacion Contraseña
                if (string.IsNullOrWhiteSpace(contrasena))
                {
                    errorProvider1.SetError(txt_contra, "Por favor, ingrese una contraseña");
                    verificado1 = false;
                }
                else
                {
                    errorProvider1.SetError(txt_contra, "");
                }

                // Validar número de teléfono
                if (txt_telefono.Text.Length != 8 || !int.TryParse(txt_telefono.Text, out telefono))
                {
                    errorProvider1.SetError(txt_telefono,"Por favor, ingrese un número de teléfono válido de exactamente 8 dígitos.");
                    verificado2 = false;
                }
                else
                {
                    errorProvider1.SetError(txt_telefono, "");
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

                    errorProvider1.Clear();
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

                Empleados empleados = new Empleados();
                string contraseñaBaseDatos = empleados.ObtenerContraseña(id);

                string contrasena = txt_contra.Text;

                bool clave = false;
                if (string.IsNullOrWhiteSpace(contrasena))
                {
                    errorProvider1.SetError(txt_contra, "Ingrese una contraseña");
                }
                else if (contrasena == contraseñaBaseDatos) // Comparar la contraseña ingresada con la contraseña de la base de datos
                {
                    clave = true;
                    errorProvider1.Clear(); // Limpiar el error si la contraseña es correcta
                }
                else
                {
                    errorProvider1.SetError(txt_contra, "La contraseña ingresada no coincide con la contraseña actual");
                }

                if (clave == true)
                {
                    empleados.Update(id, nombre, apellido, usuarioName, correo, telefono, admin, contrasena);
                    MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    errorProvider1.Clear();
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


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textoBusqueda = txt_busqueda.Text.Trim().ToLower();
                string filtrarbusqueda = Busqueda_filtro.SelectedItem.ToString();

                // Mapeo de nombres de columnas a índices de columnas
                Dictionary<string, int> columnas = new Dictionary<string, int>
                {
                    { "ID", 0 },
                    { "Nombre", 1 },
                    { "Apellido", 2 },
                    { "Usuario", 3 },
                    { "Correo", 4 },
                    { "Telefono", 5 }
                };

                int ColumnaBusqueda = columnas.ContainsKey(filtrarbusqueda) ? columnas[filtrarbusqueda] : 0;

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    string valorCelda = row.Cells[ColumnaBusqueda].Value?.ToString().ToLower();

                    bool filaVisible = !string.IsNullOrEmpty(valorCelda) && valorCelda.Contains(textoBusqueda);

                    row.Visible = filaVisible;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Funciones para cerrar
        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmEmpleado_FormClosing(this, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void frmEmpleado_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }
    }
}
