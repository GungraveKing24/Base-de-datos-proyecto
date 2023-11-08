using System;
using System.Windows.Forms;
using System.IO;
using MySqlConnector; 
using Machote_Admin_Bases_D;

namespace Base_de_datos.Formularios
{
    public partial class frmInforme : Form
    {
        public frmInforme()
        {
            InitializeComponent();
            CargarDatosEnDataGridView();
        }

        private void btn_terminado_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrearInforme_Click_4(object sender, EventArgs e)
        {
            CrearArchivoCSV();
        }

        private void CargarDatosEnDataGridView()
        {
            Informe informes = new Informe();
            dgvInformes.DataSource = informes.ObtenerInformes();
        }

        private void CrearArchivoCSV()
        {
            string filePath = "C:\\Users\\dabur\\OneDrive\\Escritorio\\archivo.csv";//Cambiar ruta hacia un archiv csv ya creado

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
}
