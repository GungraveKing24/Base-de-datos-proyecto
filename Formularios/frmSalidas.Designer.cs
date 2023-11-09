namespace Base_de_datos.Formularios
{
    partial class frmSalidas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_terminado = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.id_productomovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCantSalida = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_terminado);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Location = new System.Drawing.Point(32, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 118);
            this.panel1.TabIndex = 35;
            // 
            // btn_terminado
            // 
            this.btn_terminado.BackColor = System.Drawing.Color.IndianRed;
            this.btn_terminado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_terminado.Location = new System.Drawing.Point(469, 14);
            this.btn_terminado.Name = "btn_terminado";
            this.btn_terminado.Size = new System.Drawing.Size(198, 84);
            this.btn_terminado.TabIndex = 3;
            this.btn_terminado.Text = "Terminado";
            this.btn_terminado.UseVisualStyleBackColor = false;
            this.btn_terminado.Click += new System.EventHandler(this.btn_terminado_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(10, 14);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(179, 84);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "SALIDAS";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(194, 34);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 32;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(76, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_productomovimiento,
            this.fecha_movimiento,
            this.cantidad_movimiento,
            this.tipo_movimiento});
            this.dgvSalidas.Location = new System.Drawing.Point(32, 88);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.RowHeadersVisible = false;
            this.dgvSalidas.RowHeadersWidth = 51;
            this.dgvSalidas.RowTemplate.Height = 24;
            this.dgvSalidas.Size = new System.Drawing.Size(740, 366);
            this.dgvSalidas.TabIndex = 28;
            this.dgvSalidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // id_productomovimiento
            // 
            this.id_productomovimiento.HeaderText = "ID Producto";
            this.id_productomovimiento.MinimumWidth = 6;
            this.id_productomovimiento.Name = "id_productomovimiento";
            this.id_productomovimiento.Width = 125;
            // 
            // fecha_movimiento
            // 
            this.fecha_movimiento.HeaderText = "Fecha movimiento";
            this.fecha_movimiento.MinimumWidth = 6;
            this.fecha_movimiento.Name = "fecha_movimiento";
            this.fecha_movimiento.Width = 125;
            // 
            // cantidad_movimiento
            // 
            this.cantidad_movimiento.HeaderText = "Cantidad del movimiento";
            this.cantidad_movimiento.MinimumWidth = 6;
            this.cantidad_movimiento.Name = "cantidad_movimiento";
            this.cantidad_movimiento.Width = 125;
            // 
            // tipo_movimiento
            // 
            this.tipo_movimiento.HeaderText = "Tipo de movimiento";
            this.tipo_movimiento.MinimumWidth = 6;
            this.tipo_movimiento.Name = "tipo_movimiento";
            this.tipo_movimiento.Width = 125;
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(434, 487);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(121, 24);
            this.cmb_proveedor.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 42);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tipo\r\nmovimiento:";
            // 
            // txt_idProducto
            // 
            this.txt_idProducto.Location = new System.Drawing.Point(143, 490);
            this.txt_idProducto.Name = "txt_idProducto";
            this.txt_idProducto.Size = new System.Drawing.Size(154, 22);
            this.txt_idProducto.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 42);
            this.label7.TabIndex = 39;
            this.label7.Text = "ID Producto\r\nde salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 42);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cantidad de\r\nsalida:";
            // 
            // nudCantSalida
            // 
            this.nudCantSalida.Location = new System.Drawing.Point(143, 554);
            this.nudCantSalida.Name = "nudCantSalida";
            this.nudCantSalida.Size = new System.Drawing.Size(86, 22);
            this.nudCantSalida.TabIndex = 41;
            // 
            // frmSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudCantSalida);
            this.Controls.Add(this.txt_idProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSalidas);
            this.Name = "frmSalidas";
            this.Text = "frmSalidas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalidas_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_terminado;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_idProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCantSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_productomovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_movimiento;
    }
}