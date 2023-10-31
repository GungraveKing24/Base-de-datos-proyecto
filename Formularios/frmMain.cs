using Base_de_datos;
using Base_de_datos.Formularios;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            frmInventario inventarioForm = new frmInventario();
            inventarioForm.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Formulario de inventario
            frmInventario formularioInventario = new frmInventario();
            formularioInventario.Close();
            //Formulario de empleado
            frmEmpleado frmEmpleado = new frmEmpleado();
            formularioInventario.Close();
            //formulario provedores
            frmProveedores frmPro = new frmProveedores();
            frmPro.Close();
            //formulario productos
            VistaProducto frmvistaproducto = new VistaProducto();
            frmvistaproducto.Close();
            //login
            Login login = new Login();
            login.Close();
            Application.Exit();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            frmEmpleado empleadoForm = new frmEmpleado();
            empleadoForm.Show();
            this.Hide();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            frmProveedores proveedoresForm = new frmProveedores();
            proveedoresForm.Show();
            this.Hide();
        }

        private void btn_inventario_Click_1(object sender, EventArgs e)
        {
            frmInventario frmInventario = new frmInventario();
            frmInventario.Show();
            this.Hide();
        }
    }
}
