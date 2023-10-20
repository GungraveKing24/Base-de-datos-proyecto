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

        private string nombre;
        private string apellido;
        private string usuarioName;
        private string correo;
        private string password;
        private int telefono;
        private string admin;
        private string fechaFormateada;
        private string contrasena;

        //Verificar datos
        public void verificar_nombre()
        {
            try
            {

                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                usuarioName = txt_usuario.Text;
                correo = txt_correo.Text;
                password = txt_contra.Text;
                telefono = Convert.ToInt32(txt_telefono.Text);

                // Verificar el estado del checkbox
                bool administrador = chk_admin.Checked;
                string comprovaradmin;
                if (administrador == true)
                {
                    comprovaradmin = "1";
                }
                else
                {
                    comprovaradmin = "0";
                }

                admin = comprovaradmin;

                // Obtener la fecha actual y formatearla
                DateTime fecha = DateTime.Now;
                fechaFormateada = fecha.ToString("yyyy-MM-dd");

                // Otras operaciones con las variables si es necesario
                contrasena = txt_contra.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrEmpty(usuarioName) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_telefono.TextLength > 8)
                {
                    MessageBox.Show("Numero muy largo");
                    return;
                }
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

        private void Agregar()
        {
            verificar_nombre();
            Empleados empleados = new Empleados();
            empleados.insertar(nombre, apellido, usuarioName, correo, telefono, admin, fechaFormateada, contrasena);
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
