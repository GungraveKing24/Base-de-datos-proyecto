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
        private frmEmpleado frmEmpleado;
        private frmInventario frmInventario;
        private frmProveedores frmProveedor;
        private frmInforme FormularioInforme;
        private frmEntradas frmEntradas;
        private frmSalidas frmSalida;

        public frmMain()
        {
            InitializeComponent();
            LoadButtonDescriptions();
        }



        //descripcion de botones
        private void LoadButtonDescriptions()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_empleados, "Aqui se encuentra el control de registro para empleados (solo administradores).");
            toolTip1.SetToolTip(btn_inventario, "Aqui se puede modificar el inventario.");
            toolTip1.SetToolTip(btn_proveedores, "Las solicitudes de llenado de stock y procesamientos de proveedores que hay (solo administradores).");
            toolTip1.SetToolTip(btn_entradas, "Aqui es donde se hace el pedido de stock al proveedor (solo administradores).");
            toolTip1.SetToolTip(btn_salidas, "Aqui se puede simular el quitarle producto stock a un producto.");
            toolTip1.SetToolTip(btn_informes, "Para poder crear un informe en CSV use este boton.");
            toolTip1.SetToolTip(btn_salir, "Sirve para cerrar todo el programa.");   
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
            this.Hide();
            // Verificar si ya se ha creado una instancia de frmInforme
            if (frmEmpleado == null || frmEmpleado.IsDisposed)
            {
                // Si no existe, crear una nueva instancia
                frmEmpleado = new frmEmpleado();

                // Configurar el estado inicial de frmInforme si es necesario
                // ...

                // Mostrar frmInforme
                frmEmpleado.Show();
            }
            else
            {
                // Si ya existe, simplemente mostrarlo
                frmEmpleado.Show();
            }
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Verificar si ya se ha creado una instancia de frmInforme
            if (frmProveedor == null || frmProveedor.IsDisposed)
            {
                // Si no existe, crear una nueva instancia
                frmProveedor = new frmProveedores();
                frmProveedor.Show();
            }
            else
            {
                // Si ya existe, simplemente mostrarlo
                frmProveedor.Show();

                frmProveedor.ReloadData();
                frmProveedor.CargarDatosReposicion();
            }
        }

        private void btn_inventario_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // Verificar si ya se ha creado una instancia de frmInforme
            if (frmInventario == null || frmInventario.IsDisposed)
            {
                // Si no existe, crear una nueva instancia
                frmInventario = new frmInventario();
                frmInventario.Show();
            }
            else
            {
                // Si ya existe, simplemente mostrarlo
                frmInventario.Show();

                frmInventario.ReloadData();
                frmInventario.CargarDatos();
            }
        }

        private void btn_entradas_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Verificar si ya se ha creado una instancia de frmInforme
            if (frmEntradas == null || frmEntradas.IsDisposed)
            {
                // Si no existe, crear una nueva instancia
                frmEntradas = new frmEntradas();
                frmEntradas.Show();                
            }
            else
            {
                // Si ya existe, simplemente mostrarlo
                frmEntradas.Show();

                frmEntradas.ReloadData();
                frmEntradas.CargarDatos();
            }
        }

        private void btn_salidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Verificar si ya se ha creado una instancia de frmInforme
            if (frmSalida == null || frmSalida.IsDisposed)
            {
                // Si no existe, crear una nueva instancia
                frmSalida = new frmSalidas();

                // Configurar el estado inicial de frmInforme si es necesario
                // ...

                // Mostrar frmInforme
                frmSalida.Show();

                frmSalida.ReloadData();
                frmSalida.CargarDatos();
            }
            else
            {
                // Si ya existe, simplemente mostrarlo
                frmSalida.Show();
            }
        }

        private void btn_informes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // Verificar si ya se ha creado una instancia de frmInforme
            if (FormularioInforme == null || FormularioInforme.IsDisposed)
            {
                // Si no existe, crear una nueva instancia
                FormularioInforme = new frmInforme();

                // Configurar el estado inicial de frmInforme si es necesario
                // ...

                // Mostrar frmInforme
                FormularioInforme.Show();
            }
            else
            {
                // Si ya existe, simplemente mostrarlo
                FormularioInforme.Show();
            }
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
