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
using static Base_de_datos.Clases.Inventario;

namespace Base_de_datos.Formularios
{
    public partial class Login : Form
    {
        readonly conexion GetConexion = new conexion();

        //Un bool que permite obtener un parametro para detectar los usuario administradores de los normales
        public static bool GetAdmin { get; private set; }

        //Declarar frmmain como variable
        private frmMain FormularioMain;

        public Login()
        {
            InitializeComponent();
        }

        // Variable de clase para almacenar id_empleado
        public static int IdEmpleado { get; private set; }

        //Resultado del tipo de login al usuario

        public bool login()
        {
            bool exito = false;

            string username = TextBoxUsuario.Text;
            string password = TextBoxContraseña.Text;
            string connectionString = GetConexion.conectar();
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT id_empleado, nombre_usuario, administrador, contraseña FROM empleado WHERE nombre_usuario = @username AND contraseña = @contraseña";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@contraseña", password);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IdEmpleado = Convert.ToInt32(reader["id_empleado"]);
                    // Credenciales válidas, obtén el valor de "administrador"
                    bool esAdmin = Convert.ToBoolean(reader["administrador"]);

                    if (esAdmin == true)
                    {
                        MessageBox.Show("Inicio de sesión exitoso como administrador");
                        // Haz lo que necesites hacer si es un administrador
                        GetAdmin = true;
                    }
                    else if (esAdmin == false)
                    {
                        MessageBox.Show("Inicio de sesión exitoso como usuario regular");
                        // Haz lo que necesites hacer si es un usuario regular
                        GetAdmin = false;
                    }

                    exito = true;
                }
                else
                {
                    // Credenciales incorrectas, muestra un mensaje de error
                    MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return exito;
        }

        //Obtener el nombre para usarlo en el informe
        public string loginName()
        {
            string nombreUser = TextBoxUsuario.Text;

            return nombreUser;
        }

        public void Campos_usuario_regular()
        {
            //Formularios
            frmMain FormularioMain = new frmMain();
            frmInventario FormularioInventario = new frmInventario();

            //Main formulario
            FormularioMain.btn_empleados.Enabled = false;
            FormularioMain.btn_inventario.Enabled = true;
            FormularioMain.btn_proveedores.Enabled = false;
            FormularioMain.btn_entradas.Enabled = false;
            FormularioMain.btn_salidas.Enabled = true;
            FormularioMain.btn_informes.Enabled = true;
            FormularioMain.txt_administrador.Text= "0";

            //Formulario Inventario
            FormularioInventario.panel_inventario.Visible = false;
            FormularioInventario.Refresh();

            FormularioMain.Show();
            this.Hide();
        }

        public void Campos_usuario_admin()
        {
            //Formularios
            frmMain FormularioMain = new frmMain();
            frmInventario FormularioInventario = new frmInventario();

            //Main formulario
            FormularioMain.btn_empleados.Enabled = true;
            FormularioMain.btn_inventario.Enabled = true;
            FormularioMain.btn_proveedores.Enabled = true;
            FormularioMain.btn_entradas.Enabled = true;
            FormularioMain.btn_salidas.Enabled = true;
            FormularioMain.btn_informes.Enabled = true;
            FormularioMain.txt_administrador.Text = "1";

            //Formulario Inventario
            FormularioInventario.panel_inventario.Visible = true;

            FormularioMain.Show();
            this.Hide();
        }

        //Boton login
        private void button1_Click(object sender, EventArgs e)
        {
            bool resultadoLogin = login();

            // Ahora puedes utilizar el valor "resultadoLogin" según sea necesario
            if (resultadoLogin)
            {
                if (GetAdmin == false)
                {
                    Campos_usuario_regular();
                }
                else if (GetAdmin == true)
                {
                    Campos_usuario_admin();
                }
            }
            else
            {
                //nada
            }
        }

        private void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
