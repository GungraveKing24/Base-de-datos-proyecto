namespace Machote_Admin_Bases_D
{
    partial class frmEmpleado
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoelectronico_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharesgitro_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_admin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_terminado = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.Busqueda_filtro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_empleado,
            this.nombre_empleado,
            this.apellido_empleado,
            this.nombre_usuario,
            this.correoelectronico_empleado,
            this.telefono_empleado,
            this.administrador,
            this.fecharesgitro_empleado,
            this.contraseña});
            this.dgvProductos.Location = new System.Drawing.Point(14, 104);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(1406, 439);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "ID";
            this.id_empleado.MinimumWidth = 6;
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Width = 125;
            // 
            // nombre_empleado
            // 
            this.nombre_empleado.HeaderText = "Nombre";
            this.nombre_empleado.MinimumWidth = 6;
            this.nombre_empleado.Name = "nombre_empleado";
            this.nombre_empleado.Width = 125;
            // 
            // apellido_empleado
            // 
            this.apellido_empleado.HeaderText = "Apellido";
            this.apellido_empleado.MinimumWidth = 6;
            this.apellido_empleado.Name = "apellido_empleado";
            this.apellido_empleado.Width = 125;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.HeaderText = "Usuario";
            this.nombre_usuario.MinimumWidth = 6;
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Width = 125;
            // 
            // correoelectronico_empleado
            // 
            this.correoelectronico_empleado.HeaderText = "Correo";
            this.correoelectronico_empleado.MinimumWidth = 6;
            this.correoelectronico_empleado.Name = "correoelectronico_empleado";
            this.correoelectronico_empleado.Width = 125;
            // 
            // telefono_empleado
            // 
            this.telefono_empleado.HeaderText = "Teléfono";
            this.telefono_empleado.MinimumWidth = 6;
            this.telefono_empleado.Name = "telefono_empleado";
            this.telefono_empleado.Width = 125;
            // 
            // administrador
            // 
            this.administrador.HeaderText = "Administrador";
            this.administrador.MinimumWidth = 6;
            this.administrador.Name = "administrador";
            this.administrador.Width = 125;
            // 
            // fecharesgitro_empleado
            // 
            this.fecharesgitro_empleado.HeaderText = "Fecha Ingreso";
            this.fecharesgitro_empleado.MinimumWidth = 6;
            this.fecharesgitro_empleado.Name = "fecharesgitro_empleado";
            this.fecharesgitro_empleado.Width = 125;
            // 
            // contraseña
            // 
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.MinimumWidth = 6;
            this.contraseña.Name = "contraseña";
            this.contraseña.Visible = false;
            this.contraseña.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1213, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPLEADOS";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(56, 49);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(112, 26);
            this.txt_id.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 570);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(255, 26);
            this.txt_nombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(107, 626);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(255, 26);
            this.txt_apellido.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(107, 681);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(255, 26);
            this.txt_usuario.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuario:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(602, 571);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(275, 26);
            this.txt_correo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correo:";
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(602, 626);
            this.txt_contra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(275, 26);
            this.txt_contra.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 626);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(975, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Administrador:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(602, 682);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(275, 26);
            this.txt_telefono.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(496, 680);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Teléfono:";
            // 
            // chk_admin
            // 
            this.chk_admin.AutoSize = true;
            this.chk_admin.Location = new System.Drawing.Point(1117, 625);
            this.chk_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_admin.Name = "chk_admin";
            this.chk_admin.Size = new System.Drawing.Size(22, 21);
            this.chk_admin.TabIndex = 24;
            this.chk_admin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_terminado);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Location = new System.Drawing.Point(21, 738);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 147);
            this.panel1.TabIndex = 25;
            // 
            // btn_terminado
            // 
            this.btn_terminado.BackColor = System.Drawing.Color.IndianRed;
            this.btn_terminado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_terminado.Location = new System.Drawing.Point(1149, 19);
            this.btn_terminado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_terminado.Name = "btn_terminado";
            this.btn_terminado.Size = new System.Drawing.Size(233, 105);
            this.btn_terminado.TabIndex = 3;
            this.btn_terminado.Text = "Terminado";
            this.btn_terminado.UseVisualStyleBackColor = false;
            this.btn_terminado.Click += new System.EventHandler(this.btn_terminado_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(763, 19);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(233, 105);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(407, 19);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(233, 105);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(34, 19);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(233, 105);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "Busqueda";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_busqueda.Location = new System.Drawing.Point(448, 54);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(191, 26);
            this.txt_busqueda.TabIndex = 27;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // Busqueda_filtro
            // 
            this.Busqueda_filtro.FormattingEnabled = true;
            this.Busqueda_filtro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Busqueda_filtro.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Apellido",
            "Usuario",
            "Correo",
            "Telefono"});
            this.Busqueda_filtro.Location = new System.Drawing.Point(657, 54);
            this.Busqueda_filtro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Busqueda_filtro.Name = "Busqueda_filtro";
            this.Busqueda_filtro.Size = new System.Drawing.Size(136, 28);
            this.Busqueda_filtro.TabIndex = 28;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 900);
            this.Controls.Add(this.Busqueda_filtro);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chk_admin);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmpleado";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_admin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_terminado;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoelectronico_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn administrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharesgitro_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.ComboBox Busqueda_filtro;
    }
}