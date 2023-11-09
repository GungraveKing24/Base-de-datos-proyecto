namespace Base_de_datos.Formularios
{
    partial class frmInforme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            this.btnCrearInforme = new System.Windows.Forms.Button();
            this.btn_terminado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformes
            // 
            this.dgvInformes.AllowUserToAddRows = false;
            this.dgvInformes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInformes.ColumnHeadersHeight = 29;
            this.dgvInformes.Location = new System.Drawing.Point(12, 12);
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.RowHeadersVisible = false;
            this.dgvInformes.RowHeadersWidth = 51;
            this.dgvInformes.RowTemplate.Height = 24;
            this.dgvInformes.Size = new System.Drawing.Size(889, 415);
            this.dgvInformes.TabIndex = 0;
            // 
            // btnCrearInforme
            // 
            this.btnCrearInforme.Location = new System.Drawing.Point(121, 433);
            this.btnCrearInforme.Name = "btnCrearInforme";
            this.btnCrearInforme.Size = new System.Drawing.Size(198, 84);
            this.btnCrearInforme.TabIndex = 1;
            this.btnCrearInforme.Text = "Crear Informe";
            this.btnCrearInforme.UseVisualStyleBackColor = true;
            this.btnCrearInforme.Click += new System.EventHandler(this.btnCrearInforme_Click_4);
            // 
            // btn_terminado
            // 
            this.btn_terminado.BackColor = System.Drawing.Color.IndianRed;
            this.btn_terminado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_terminado.Location = new System.Drawing.Point(577, 433);
            this.btn_terminado.Name = "btn_terminado";
            this.btn_terminado.Size = new System.Drawing.Size(198, 84);
            this.btn_terminado.TabIndex = 4;
            this.btn_terminado.Text = "Terminado";
            this.btn_terminado.UseVisualStyleBackColor = false;
            this.btn_terminado.Click += new System.EventHandler(this.btn_terminado_Click);
            // 
            // frmInforme
            // 
            this.ClientSize = new System.Drawing.Size(920, 526);
            this.Controls.Add(this.btn_terminado);
            this.Controls.Add(this.btnCrearInforme);
            this.Controls.Add(this.dgvInformes);
            this.Name = "frmInforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInforme_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dgvInformes;
        private System.Windows.Forms.Button btnCrearInforme;
        private System.Windows.Forms.Button btn_terminado;
    }
}