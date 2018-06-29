namespace WindowsFormsApp1
{
    partial class frmExamen
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
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.txbNombrePersona = new System.Windows.Forms.TextBox();
            this.btnRegistrarPersona = new System.Windows.Forms.Button();
            this.grbPersona = new System.Windows.Forms.GroupBox();
            this.grbProductos = new System.Windows.Forms.GroupBox();
            this.btnVenta = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.grbPersona.SuspendLayout();
            this.grbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.Location = new System.Drawing.Point(6, 17);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(95, 23);
            this.lblNombrePersona.TabIndex = 1;
            this.lblNombrePersona.Text = "Nombre Persona:";
            this.lblNombrePersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbNombrePersona
            // 
            this.txbNombrePersona.Location = new System.Drawing.Point(98, 19);
            this.txbNombrePersona.Name = "txbNombrePersona";
            this.txbNombrePersona.Size = new System.Drawing.Size(512, 20);
            this.txbNombrePersona.TabIndex = 2;
            // 
            // btnRegistrarPersona
            // 
            this.btnRegistrarPersona.Location = new System.Drawing.Point(616, 17);
            this.btnRegistrarPersona.Name = "btnRegistrarPersona";
            this.btnRegistrarPersona.Size = new System.Drawing.Size(151, 23);
            this.btnRegistrarPersona.TabIndex = 3;
            this.btnRegistrarPersona.Text = "Registrar/Consultar Persona";
            this.btnRegistrarPersona.UseVisualStyleBackColor = true;
            // 
            // grbPersona
            // 
            this.grbPersona.Controls.Add(this.txbNombrePersona);
            this.grbPersona.Controls.Add(this.btnRegistrarPersona);
            this.grbPersona.Controls.Add(this.lblNombrePersona);
            this.grbPersona.Location = new System.Drawing.Point(12, 12);
            this.grbPersona.Name = "grbPersona";
            this.grbPersona.Size = new System.Drawing.Size(773, 60);
            this.grbPersona.TabIndex = 4;
            this.grbPersona.TabStop = false;
            this.grbPersona.Text = "Persona";
            // 
            // grbProductos
            // 
            this.grbProductos.Controls.Add(this.btnVenta);
            this.grbProductos.Controls.Add(this.dgvProductos);
            this.grbProductos.Location = new System.Drawing.Point(12, 78);
            this.grbProductos.Name = "grbProductos";
            this.grbProductos.Size = new System.Drawing.Size(773, 276);
            this.grbProductos.TabIndex = 5;
            this.grbProductos.TabStop = false;
            this.grbProductos.Text = "Productos";
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(653, 235);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(114, 23);
            this.btnVenta.TabIndex = 4;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(9, 20);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProductos.Size = new System.Drawing.Size(758, 205);
            this.dgvProductos.TabIndex = 0;
            // 
            // frmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.grbProductos);
            this.Controls.Add(this.grbPersona);
            this.Name = "frmExamen";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPersona.ResumeLayout(false);
            this.grbPersona.PerformLayout();
            this.grbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombrePersona;
        private System.Windows.Forms.TextBox txbNombrePersona;
        private System.Windows.Forms.Button btnRegistrarPersona;
        private System.Windows.Forms.GroupBox grbPersona;
        private System.Windows.Forms.GroupBox grbProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnVenta;
    }
}

