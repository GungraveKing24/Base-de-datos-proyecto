using Base_de_datos;
using Base_de_datos.Clases;
using Machote_Admin_Bases_D;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Base_de_datos.Clases.Salida;

namespace Base_de_datos.Formularios
{
    public partial class frmSalidas : Form
    {
        readonly conexion GetConexion = new conexion(); //Llamar la clase conexion
        public frmSalidas()
        {
            InitializeComponent();
            CargarDatos();

            tipemovement();
        }

        private void CargarDatos()      //movimiento inventario
        {
            try
            {
                string connectionString = GetConexion.conectar();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id_movimiento, fecha_movimiento, cantidad_movimiento, tipo_movimiento, id_productomovimiento " +
                                    "FROM movimiento_inventario  " +
                                    "JOIN producto ON id_producto = id_productomovimiento";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(0);
                            DateTime Fecha_movimiento = reader.GetDateTime(1);
                            int Cantidad = reader.GetInt32(2);
                            string Tipo_movimiento = reader.GetString(3);
                            int id_movimiento_producto = reader.GetInt32(4);

                            int rowIndex = dgvSalidas.Rows.Add(ID, Fecha_movimiento, Cantidad, Tipo_movimiento, id_movimiento_producto);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        //Combobox de tipo de movimiento
        private void tipemovement()
        {
            string connectionString = GetConexion.conectar();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();

                // Aquí ejecutarás la consulta y poblarás el ComboBox

                string query = "SELECT tipo_movimiento FROM movimiento_inventario GROUP BY tipo_movimiento;";
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
                                cmb_tipo_movimiento.Items.Add(nombre);
                            }
                        }
                    }
                }
            }
        }

        private int obtenerStock()
        {
            int stockObtenido = 0;
            string connectionString = GetConexion.conectar();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();

                string query = "SELECT cantidadstock FROM stock WHERE id_stock = @id;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Agrega el parámetro y su valor
                    cmd.Parameters.AddWithValue("@id", txt_idProducto.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Verifica si hay filas en el resultado
                        if (reader.HasRows)
                        {
                            // Itera a través de las filas
                            while (reader.Read())
                            {
                                // Obtén el valor de cantidadstock y asígnalo a la variable
                                stockObtenido = Convert.ToInt32(reader["cantidadstock"]);
                                // Puedes hacer algo más con el valor si es necesario
                            }
                        }
                    }
                }
            }

            return stockObtenido; // Devuelve el valor de cantidadstock
        }

        //Usar para reducir
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_id.Text);
                int id_producto = Convert.ToInt32(txt_idProducto.Text);
                DateTime fecha_movimiento = DateTime.Now; 
                string tipo = cmb_tipo_movimiento.Text;
                int cantidad = Convert.ToInt32(nudCantSalida.Value);

                int verificarstock = obtenerStock();
                if (cantidad < verificarstock)
                {
                    Salida salida = new Salida();
                    DatosSalida Dsalida = new DatosSalida
                    {
                        id_movimiento = id,
                        id_productomovimiento = id_producto,
                        fecha_movimiento = fecha_movimiento,
                        tipo_movimiento = tipo,
                        cantidad_movimientoS = cantidad
                    };
                    salida.disminuir(Dsalida);
                    MessageBox.Show("El stock ha sido disminuido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cantidad > verificarstock)
                {
                    MessageBox.Show("Esta intentando disminuir más halla del limite de stock existente" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la resta de datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvSalidas.Rows.Clear();
            CargarDatos();
        }

        private void dgvSalidas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSalidas.CurrentRow != null)
            {
                DataGridViewRow row = dgvSalidas.CurrentRow;

                // Obtener los valores de las celdas de la fila seleccionada
                txt_id.Text = Convert.ToString(row.Cells[0].Value);
                nudCantSalida.Text = Convert.ToString(row.Cells[2].Value);
                cmb_tipo_movimiento.Text = Convert.ToString(row.Cells[3].Value);
                txt_idProducto.Text = Convert.ToString(row.Cells[4].Value);
            }
        }

        //funciones de cerrado
        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmSalidas_FormClosing(this, new FormClosingEventArgs(CloseReason.UserClosing, true));
        }

        private void frmSalidas_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmSalidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }
    }
}
