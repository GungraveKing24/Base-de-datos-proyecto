namespace Base_de_datos
{
    partial class VistaProducto
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
            this.button1 = new System.Windows.Forms.Button();
            this.DatagridStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStock)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DatagridStock
            // 
            this.DatagridStock.ColumnHeadersHeight = 29;
            this.DatagridStock.Location = new System.Drawing.Point(26, 155);
            this.DatagridStock.Name = "DatagridStock";
            this.DatagridStock.RowHeadersVisible = false;
            this.DatagridStock.RowHeadersWidth = 51;
            this.DatagridStock.Size = new System.Drawing.Size(1793, 741);
            this.DatagridStock.TabIndex = 5;
            // 
            // VistaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1929, 976);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatagridStock);
            this.Name = "VistaProducto";
            this.Text = "VistaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DatagridStock;
    }
}

