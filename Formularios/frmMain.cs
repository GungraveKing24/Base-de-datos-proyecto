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
            this.FormClosing += frmMain_FormClosing;
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
            //login
            Login login = new Login();
            login.Close();
            Application.Exit();
        }

        //Botones de formularios
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

        private void btn_entradas_Click(object sender, EventArgs e)
        {
            frmEntradas frmEntrada = new frmEntradas();
            frmEntrada.Show();
            this.Hide();
        }

        private void btn_salidas_Click(object sender, EventArgs e)
        {
            frmSalidas frmSalida = new frmSalidas();
            frmSalida.Show();
            this.Hide();
        }

        private void btn_informes_Click_1(object sender, EventArgs e)
        {
            frmInforme FRMinforme = new frmInforme();
            FRMinforme.Show();
            this.Hide();
        }

        //Para Cerrar todo en el formulario
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre del formulario principal si el usuario elige "No".
            }
            else
            {
                // Cierra todos los formularios abiertos.
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this) // No cerrar el formulario principal nuevamente.
                    {
                        form.Close();
                    }
                }
            }
        }

    }
}
