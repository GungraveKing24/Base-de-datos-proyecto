namespace Machote_Admin_Bases_D
{
    partial class frmInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_id_proveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pSalida = new System.Windows.Forms.TextBox();
            this.txt_pEntrada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_terminado = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_producto,
            this.Categoria,
            this.cantidadstock,
            this.Precio_Entrada,
            this.Precio_Salida,
            this.Fecha_Ingreso,
            this.Proveedor,
            this.test});
            this.dgvProductos.Location = new System.Drawing.Point(15, 62);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(1053, 351);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Width = 125;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre";
            this.nombre_producto.MinimumWidth = 6;
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            this.nombre_producto.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // cantidadstock
            // 
            this.cantidadstock.HeaderText = "Stock";
            this.cantidadstock.MinimumWidth = 6;
            this.cantidadstock.Name = "cantidadstock";
            this.cantidadstock.ReadOnly = true;
            this.cantidadstock.Width = 125;
            // 
            // Precio_Entrada
            // 
            this.Precio_Entrada.HeaderText = "Precio Entrada";
            this.Precio_Entrada.MinimumWidth = 6;
            this.Precio_Entrada.Name = "Precio_Entrada";
            this.Precio_Entrada.ReadOnly = true;
            this.Precio_Entrada.Width = 125;
            // 
            // Precio_Salida
            // 
            this.Precio_Salida.HeaderText = "Precio Salida";
            this.Precio_Salida.MinimumWidth = 6;
            this.Precio_Salida.Name = "Precio_Salida";
            this.Precio_Salida.ReadOnly = true;
            this.Precio_Salida.Width = 125;
            // 
            // Fecha_Ingreso
            // 
            this.Fecha_Ingreso.HeaderText = "Fecha Ingreso";
            this.Fecha_Ingreso.MinimumWidth = 6;
            this.Fecha_Ingreso.Name = "Fecha_Ingreso";
            this.Fecha_Ingreso.ReadOnly = true;
            this.Fecha_Ingreso.Width = 125;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 125;
            // 
            // test
            // 
            this.test.HeaderText = "Id Proveedor";
            this.test.MinimumWidth = 6;
            this.test.Name = "test";
            this.test.ReadOnly = true;
            this.test.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(892, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(66, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.txt_id_proveedor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudStock);
            this.panel1.Controls.Add(this.cmb_proveedor);
            this.panel1.Controls.Add(this.cmb_categoria);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_pSalida);
            this.panel1.Controls.Add(this.txt_pEntrada);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_terminado);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Location = new System.Drawing.Point(15, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 240);
            this.panel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(776, 32);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(239, 22);
            this.txt_descripcion.TabIndex = 40;
            // 
            // txt_id_proveedor
            // 
            this.txt_id_proveedor.Location = new System.Drawing.Point(698, 153);
            this.txt_id_proveedor.Name = "txt_id_proveedor";
            this.txt_id_proveedor.Size = new System.Drawing.Size(100, 22);
            this.txt_id_proveedor.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Stock:";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(569, 33);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(86, 22);
            this.nudStock.TabIndex = 37;
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(549, 97);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(121, 24);
            this.cmb_proveedor.TabIndex = 36;
            this.cmb_proveedor.SelectedIndexChanged += new System.EventHandler(this.cmb_proveedor_SelectedIndexChanged);
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(91, 94);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(192, 24);
            this.cmb_categoria.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(565, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Proveedor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-2, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Categoría:";
            // 
            // txt_pSalida
            // 
            this.txt_pSalida.Location = new System.Drawing.Point(384, 94);
            this.txt_pSalida.Name = "txt_pSalida";
            this.txt_pSalida.Size = new System.Drawing.Size(126, 22);
            this.txt_pSalida.TabIndex = 30;
            // 
            // txt_pEntrada
            // 
            this.txt_pEntrada.Location = new System.Drawing.Point(384, 32);
            this.txt_pEntrada.Name = "txt_pEntrada";
            this.txt_pEntrada.Size = new System.Drawing.Size(126, 22);
            this.txt_pEntrada.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 42);
            this.label7.TabIndex = 28;
            this.label7.Text = "Precio\r\nSalida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 42);
            this.label6.TabIndex = 27;
            this.label6.Text = "Precio \r\nEntrada:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(91, 26);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(192, 22);
            this.txt_nombre.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre:";
            // 
            // btn_terminado
            // 
            this.btn_terminado.BackColor = System.Drawing.Color.IndianRed;
            this.btn_terminado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_terminado.Location = new System.Drawing.Point(826, 144);
            this.btn_terminado.Name = "btn_terminado";
            this.btn_terminado.Size = new System.Drawing.Size(207, 84);
            this.btn_terminado.TabIndex = 4;
            this.btn_terminado.Text = "Terminado";
            this.btn_terminado.UseVisualStyleBackColor = false;
            this.btn_terminado.Click += new System.EventHandler(this.btn_terminado_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(485, 144);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(207, 84);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(260, 144);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(207, 84);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(23, 144);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(207, 84);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_buscador
            // 
            this.txt_buscador.Location = new System.Drawing.Point(324, 24);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(159, 22);
            this.txt_buscador.TabIndex = 22;
            this.txt_buscador.TextChanged += new System.EventHandler(this.txt_buscador_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Bucador:";
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 675);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInventario";
            this.Text = "Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInventario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_terminado;
        public System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pSalida;
        private System.Windows.Forms.TextBox txt_pEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudStock;
        public System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewButtonColumn test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.Label label8;
    }
}

