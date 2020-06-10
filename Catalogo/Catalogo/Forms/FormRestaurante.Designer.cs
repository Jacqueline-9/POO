namespace EmpleadosRestaurante
{
    partial class FormRestaurante
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
            this.lblTipoEmpledo = new System.Windows.Forms.Label();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoEmpledo
            // 
            this.lblTipoEmpledo.AutoSize = true;
            this.lblTipoEmpledo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEmpledo.Location = new System.Drawing.Point(13, 13);
            this.lblTipoEmpledo.Name = "lblTipoEmpledo";
            this.lblTipoEmpledo.Size = new System.Drawing.Size(109, 22);
            this.lblTipoEmpledo.TabIndex = 0;
            this.lblTipoEmpledo.Text = "Tipo de Empleado:";
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(17, 39);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEmpleado.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(77, 95);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(36, 66);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 122);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbTipoEmpleado);
            this.Controls.Add(this.lblTipoEmpledo);
            this.Name = "Form1";
            this.Text = "EmpleadosRestaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoEmpledo;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEnter;
    }
}

