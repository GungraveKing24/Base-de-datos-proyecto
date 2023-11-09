namespace Base_de_datos.Formularios
{
    partial class Login
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
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.TextBoxContraseña = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(77)))), ((int)(((byte)(253)))));
            this.TextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.TextBoxUsuario.Location = new System.Drawing.Point(188, 41);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(243, 38);
            this.TextBoxUsuario.TabIndex = 0;
            this.TextBoxUsuario.Text = "esmenb";
            this.TextBoxUsuario.TextChanged += new System.EventHandler(this.TextBoxUsuario_TextChanged);
            // 
            // TextBoxContraseña
            // 
            this.TextBoxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(77)))), ((int)(((byte)(253)))));
            this.TextBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContraseña.ForeColor = System.Drawing.Color.Gainsboro;
            this.TextBoxContraseña.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBoxContraseña.Location = new System.Drawing.Point(188, 135);
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            this.TextBoxContraseña.Size = new System.Drawing.Size(243, 38);
            this.TextBoxContraseña.TabIndex = 1;
            this.TextBoxContraseña.Text = "mecareempresa0";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(16)))), ((int)(((byte)(95)))));
            this.LoginButton.CausesValidation = false;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.LoginButton.Location = new System.Drawing.Point(126, 230);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(184, 53);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Ingresar";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(473, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TextBoxContraseña);
            this.Controls.Add(this.TextBoxUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.TextBox TextBoxContraseña;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}