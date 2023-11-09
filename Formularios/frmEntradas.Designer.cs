namespace Base_de_datos.Formularios
{
    partial class frmEntradas
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.id_pedido_reposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_productopedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_reposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_reposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadopedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_terminado = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtvproductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeFCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idProducto = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido_reposicion,
            this.id_productopedido,
            this.fecha_reposicion,
            this.cantidad_reposicion,
            this.estadopedido,
            this.fecha_caducidad});
            this.dgvPedidos.Location = new System.Drawing.Point(735, 134);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(662, 366);
            this.dgvPedidos.TabIndex = 1;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // id_pedido_reposicion
            // 
            this.id_pedido_reposicion.HeaderText = "ID Pedido";
            this.id_pedido_reposicion.MinimumWidth = 6;
            this.id_pedido_reposicion.Name = "id_pedido_reposicion";
            this.id_pedido_reposicion.Width = 125;
            // 
            // id_productopedido
            // 
            this.id_productopedido.HeaderText = "ID producto";
            this.id_productopedido.MinimumWidth = 6;
            this.id_productopedido.Name = "id_productopedido";
            this.id_productopedido.Width = 125;
            // 
            // fecha_reposicion
            // 
            this.fecha_reposicion.HeaderText = "Fecha Reposición";
            this.fecha_reposicion.MinimumWidth = 6;
            this.fecha_reposicion.Name = "fecha_reposicion";
            this.fecha_reposicion.Width = 125;
            // 
            // cantidad_reposicion
            // 
            this.cantidad_reposicion.HeaderText = "Cantidad del Pedido";
            this.cantidad_reposicion.MinimumWidth = 6;
            this.cantidad_reposicion.Name = "cantidad_reposicion";
            this.cantidad_reposicion.Width = 125;
            // 
            // estadopedido
            // 
            this.estadopedido.HeaderText = "Estado Pedido";
            this.estadopedido.MinimumWidth = 6;
            this.estadopedido.Name = "estadopedido";
            this.estadopedido.Width = 125;
            // 
            // fecha_caducidad
            // 
            this.fecha_caducidad.HeaderText = "Fecha Caducidad";
            this.fecha_caducidad.MinimumWidth = 6;
            this.fecha_caducidad.Name = "fecha_caducidad";
            this.fecha_caducidad.Width = 125;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(58, 43);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1152, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "ENTRADAS";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(417, 544);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(86, 22);
            this.nudStock.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de \r\nreposición:";
            // 
            // btn_terminado
            // 
            this.btn_terminado.BackColor = System.Drawing.Color.IndianRed;
            this.btn_terminado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_terminado.Location = new System.Drawing.Point(1093, 14);
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
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_terminado);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Location = new System.Drawing.Point(12, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 118);
            this.panel1.TabIndex = 27;
            // 
            // dtvproductos
            // 
            this.dtvproductos.AllowUserToAddRows = false;
            this.dtvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5});
            this.dtvproductos.Location = new System.Drawing.Point(12, 134);
            this.dtvproductos.Name = "dtvproductos";
            this.dtvproductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtvproductos.RowHeadersVisible = false;
            this.dtvproductos.RowHeadersWidth = 51;
            this.dtvproductos.RowTemplate.Height = 24;
            this.dtvproductos.Size = new System.Drawing.Size(700, 366);
            this.dtvproductos.TabIndex = 28;
            this.dtvproductos.SelectionChanged += new System.EventHandler(this.dtvproductos_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 34);
            this.label4.TabIndex = 29;
            this.label4.Text = "Productos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(724, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 34);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pedidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 42);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha de\r\ncaducidad:\r\n";
            // 
            // dateTimeFCaducidad
            // 
            this.dateTimeFCaducidad.Location = new System.Drawing.Point(640, 544);
            this.dateTimeFCaducidad.Name = "dateTimeFCaducidad";
            this.dateTimeFCaducidad.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFCaducidad.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 42);
            this.label7.TabIndex = 33;
            this.label7.Text = "ID Producto\r\na reponer:";
            // 
            // txt_idProducto
            // 
            this.txt_idProducto.Location = new System.Drawing.Point(128, 544);
            this.txt_idProducto.Name = "txt_idProducto";
            this.txt_idProducto.Size = new System.Drawing.Size(154, 22);
            this.txt_idProducto.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Precio Salida";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Ingreso";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad Stock";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Id proveedor";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // frmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 732);
            this.Controls.Add(this.txt_idProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeFCaducidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtvproductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "frmEntradas";
            this.Text = "frmEntradas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEntradas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_terminado;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtvproductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido_reposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_productopedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_reposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_reposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadopedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_caducidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeFCaducidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}