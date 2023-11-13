using System;
using System.Windows.Forms;
using System.IO;
using MySqlConnector; 
using Machote_Admin_Bases_D;
using System.Linq;

namespace Base_de_datos.Formularios
{
    public partial class frmInforme : Form
    {
        public frmInforme()
        {
            InitializeComponent();
            CargarDatosEnDataGridView();
        }

        public void ReloadData()
        { 
            dgvInformes.Rows.Clear();
        }


        private void btnCrearInforme_Click_4(object sender, EventArgs e)
        {
            CrearArchivoCSV();
        }

        public void CargarDatosEnDataGridView()
        {
            dgvInformes.DataSource = null;
            Informe informes = new Informe();
            dgvInformes.DataSource = informes.ObtenerInformes();
        }

        private void CrearArchivoCSV()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string getpath = saveFileDialog.FileName;
                string filePath = getpath;

                if (dgvInformes.Rows.Count > 0)
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        int columnCount = dgvInformes.ColumnCount;
                        for (int i = 0; i < columnCount; i++)
                        {
                            sw.Write(dgvInformes.Columns[i].HeaderText);
                            if (i < columnCount - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dgvInformes.Rows)
                        {
                            for (int i = 0; i < columnCount; i++)
                            {
                                if (row.Cells[i].Value != null)
                                    sw.Write(row.Cells[i].Value.ToString());
                                if (i < columnCount - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Archivo CSV creado exitosamente en " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Funciones de cerrar
        private void frmInforme_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmInforme_FormClosing(this, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void frmInforme_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }
        }
    }
}
