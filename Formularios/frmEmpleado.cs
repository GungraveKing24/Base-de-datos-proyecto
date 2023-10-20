using Base_de_datos.Clases;
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
    public partial class frmEmpleado : Form
    {
       
        public frmEmpleado()
        {
            InitializeComponent();
        }

        //Variables
        private string nombre;
        private string apellido;
        private string usuarioName;
        private string correo;
        private string password;
        private int telefono;
        private string admin;
        private string fechaFormateada;
        private string contrasena;

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

                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrEmpty(usuarioName) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificado1 = false;
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                else
                {
                    MessageBox.Show("Error al insertar datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
    }
}
