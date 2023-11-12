namespace Machote_Admin_Bases_D
{
    partial class frmProveedores
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_terminado = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoelectronico_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_administrador = new System.Windows.Forms.TextBox();
            this.txt_id_proveedor = new System.Windows.Forms.TextBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_id_stock = new System.Windows.Forms.TextBox();
            this.txt_id_Producto = new System.Windows.Forms.TextBox();
            this.txt_id_Reposicion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.txt_nombre_proveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_terminar = new System.Windows.Forms.Button();
            this.Btn_rechazar = new System.Windows.Forms.Button();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.dgvProveedoresRepocision = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedoresRepocision)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(170, 52);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(52, 53);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "PROVEEDORES";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 639);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_ciudad);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_correo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_telefono);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_nombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvProveedores);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control Proveedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(427, 429);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(183, 22);
            this.txt_ciudad.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ciudad:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(427, 386);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(183, 22);
            this.txt_correo.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Correo:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(143, 429);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(183, 22);
            this.txt_telefono.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Teléfono:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(143, 386);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(183, 22);
            this.txt_nombre.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_terminado);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Location = new System.Drawing.Point(68, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 118);
            this.panel1.TabIndex = 37;
            // 
            // btn_terminado
            // 
            this.btn_terminado.BackColor = System.Drawing.Color.IndianRed;
            this.btn_terminado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_terminado.Location = new System.Drawing.Point(585, 14);
            this.btn_terminado.Name = "btn_terminado";
            this.btn_terminado.Size = new System.Drawing.Size(198, 84);
            this.btn_terminado.TabIndex = 3;
            this.btn_terminado.Text = "Terminado";
            this.btn_terminado.UseVisualStyleBackColor = false;
            this.btn_terminado.Click += new System.EventHandler(this.btn_terminado_Click_1);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(15, 14);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(179, 84);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.nombre_proveedor,
            this.telefono_proveedor,
            this.correoelectronico_proveedor,
            this.ciudad_proveedor});
            this.dgvProveedores.Location = new System.Drawing.Point(-4, 6);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.Size = new System.Drawing.Size(938, 351);
            this.dgvProveedores.TabIndex = 9;
            // 
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "ID";
            this.id_proveedor.MinimumWidth = 6;
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.Width = 125;
            // 
            // nombre_proveedor
            // 
            this.nombre_proveedor.HeaderText = "Nombre";
            this.nombre_proveedor.MinimumWidth = 6;
            this.nombre_proveedor.Name = "nombre_proveedor";
            this.nombre_proveedor.Width = 125;
            // 
            // telefono_proveedor
            // 
            this.telefono_proveedor.HeaderText = "Teléfono";
            this.telefono_proveedor.MinimumWidth = 6;
            this.telefono_proveedor.Name = "telefono_proveedor";
            this.telefono_proveedor.Width = 125;
            // 
            // correoelectronico_proveedor
            // 
            this.correoelectronico_proveedor.HeaderText = "Correo";
            this.correoelectronico_proveedor.MinimumWidth = 6;
            this.correoelectronico_proveedor.Name = "correoelectronico_proveedor";
            this.correoelectronico_proveedor.Width = 125;
            // 
            // ciudad_proveedor
            // 
            this.ciudad_proveedor.HeaderText = "Ciudad";
            this.ciudad_proveedor.MinimumWidth = 6;
            this.ciudad_proveedor.Name = "ciudad_proveedor";
            this.ciudad_proveedor.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgvProveedoresRepocision);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control Pedidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_administrador);
            this.panel2.Controls.Add(this.txt_id_proveedor);
            this.panel2.Controls.Add(this.txt_id_empleado);
            this.panel2.Controls.Add(this.txt_cantidad);
            this.panel2.Controls.Add(this.txt_id_stock);
            this.panel2.Controls.Add(this.txt_id_Producto);
            this.panel2.Controls.Add(this.txt_id_Reposicion);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_nombre_producto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.chk_estado);
            this.panel2.Controls.Add(this.txt_nombre_proveedor);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Btn_terminar);
            this.panel2.Controls.Add(this.Btn_rechazar);
            this.panel2.Controls.Add(this.Btn_aceptar);
            this.panel2.Location = new System.Drawing.Point(13, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 200);
            this.panel2.TabIndex = 38;
            // 
            // txt_administrador
            // 
            this.txt_administrador.Location = new System.Drawing.Point(828, 59);
            this.txt_administrador.Name = "txt_administrador";
            this.txt_administrador.Size = new System.Drawing.Size(49, 22);
            this.txt_administrador.TabIndex = 55;
            this.txt_administrador.Visible = false;
            // 
            // txt_id_proveedor
            // 
            this.txt_id_proveedor.Location = new System.Drawing.Point(741, 59);
            this.txt_id_proveedor.Name = "txt_id_proveedor";
            this.txt_id_proveedor.Size = new System.Drawing.Size(60, 22);
            this.txt_id_proveedor.TabIndex = 54;
            this.txt_id_proveedor.Visible = false;
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Location = new System.Drawing.Point(647, 57);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(88, 22);
            this.txt_id_empleado.TabIndex = 50;
            this.txt_id_empleado.Visible = false;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(846, 13);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(60, 22);
            this.txt_cantidad.TabIndex = 49;
            this.txt_cantidad.Visible = false;
            // 
            // txt_id_stock
            // 
            this.txt_id_stock.Location = new System.Drawing.Point(779, 13);
            this.txt_id_stock.Name = "txt_id_stock";
            this.txt_id_stock.Size = new System.Drawing.Size(60, 22);
            this.txt_id_stock.TabIndex = 48;
            this.txt_id_stock.Visible = false;
            // 
            // txt_id_Producto
            // 
            this.txt_id_Producto.Location = new System.Drawing.Point(713, 13);
            this.txt_id_Producto.Name = "txt_id_Producto";
            this.txt_id_Producto.Size = new System.Drawing.Size(60, 22);
            this.txt_id_Producto.TabIndex = 47;
            this.txt_id_Producto.Visible = false;
            // 
            // txt_id_Reposicion
            // 
            this.txt_id_Reposicion.Location = new System.Drawing.Point(647, 13);
            this.txt_id_Reposicion.Name = "txt_id_Reposicion";
            this.txt_id_Reposicion.Size = new System.Drawing.Size(60, 22);
            this.txt_id_Reposicion.TabIndex = 46;
            this.txt_id_Reposicion.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Producto:";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Location = new System.Drawing.Point(124, 57);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(183, 22);
            this.txt_nombre_producto.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "Estado:";
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(403, 25);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(18, 17);
            this.chk_estado.TabIndex = 42;
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // txt_nombre_proveedor
            // 
            this.txt_nombre_proveedor.Location = new System.Drawing.Point(124, 19);
            this.txt_nombre_proveedor.Name = "txt_nombre_proveedor";
            this.txt_nombre_proveedor.Size = new System.Drawing.Size(183, 22);
            this.txt_nombre_proveedor.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Proveedor:";
            // 
            // Btn_terminar
            // 
            this.Btn_terminar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_terminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_terminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_terminar.Location = new System.Drawing.Point(718, 111);
            this.Btn_terminar.Name = "Btn_terminar";
            this.Btn_terminar.Size = new System.Drawing.Size(198, 84);
            this.Btn_terminar.TabIndex = 3;
            this.Btn_terminar.Text = "Terminado";
            this.Btn_terminar.UseVisualStyleBackColor = false;
            this.Btn_terminar.Click += new System.EventHandler(this.Btn_terminar_Click);
            // 
            // Btn_rechazar
            // 
            this.Btn_rechazar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_rechazar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_rechazar.Location = new System.Drawing.Point(462, 105);
            this.Btn_rechazar.Name = "Btn_rechazar";
            this.Btn_rechazar.Size = new System.Drawing.Size(179, 84);
            this.Btn_rechazar.TabIndex = 2;
            this.Btn_rechazar.Text = "Rechazar";
            this.Btn_rechazar.UseVisualStyleBackColor = false;
            this.Btn_rechazar.Click += new System.EventHandler(this.Btn_rechazar_Click);
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_aceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aceptar.Location = new System.Drawing.Point(462, 13);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(179, 84);
            this.Btn_aceptar.TabIndex = 0;
            this.Btn_aceptar.Text = "Aceptar";
            this.Btn_aceptar.UseVisualStyleBackColor = false;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // dgvProveedoresRepocision
            // 
            this.dgvProveedoresRepocision.AllowUserToAddRows = false;
            this.dgvProveedoresRepocision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProveedoresRepocision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedoresRepocision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column9,
            this.Column7});
            this.dgvProveedoresRepocision.Location = new System.Drawing.Point(6, 6);
            this.dgvProveedoresRepocision.Name = "dgvProveedoresRepocision";
            this.dgvProveedoresRepocision.RowHeadersVisible = false;
            this.dgvProveedoresRepocision.RowHeadersWidth = 51;
            this.dgvProveedoresRepocision.RowTemplate.Height = 24;
            this.dgvProveedoresRepocision.Size = new System.Drawing.Size(928, 392);
            this.dgvProveedoresRepocision.TabIndex = 0;
            this.dgvProveedoresRepocision.SelectionChanged += new System.EventHandler(this.dgvProveedoresRepocision_SelectionChanged);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "ID";
            this.Column0.MinimumWidth = 6;
            this.Column0.Name = "Column0";
            this.Column0.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Proveedor";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha Repocision";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad Reposicion";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado del pedido";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID producto";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID Stock";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "id proveedor";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 754);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProveedores_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProveedores_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedoresRepocision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_terminado;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_terminar;
        private System.Windows.Forms.Button Btn_rechazar;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.DataGridView dgvProveedoresRepocision;
        private System.Windows.Forms.TextBox txt_nombre_proveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.TextBox txt_id_stock;
        private System.Windows.Forms.TextBox txt_id_Producto;
        private System.Windows.Forms.TextBox txt_id_Reposicion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoelectronico_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad_proveedor;
        private System.Windows.Forms.TextBox txt_id_proveedor;
        public System.Windows.Forms.TextBox txt_administrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}