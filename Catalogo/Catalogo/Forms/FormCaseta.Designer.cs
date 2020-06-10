namespace CasetaAutopista
{
    partial class FormCaseta
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
            this.cmbVehículo = new System.Windows.Forms.ComboBox();
            this.lblVehículo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCantidadCobrar = new System.Windows.Forms.Label();
            this.txtCantidadCobrar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbVehículo
            // 
            this.cmbVehículo.FormattingEnabled = true;
            this.cmbVehículo.Location = new System.Drawing.Point(101, 17);
            this.cmbVehículo.Name = "cmbVehículo";
            this.cmbVehículo.Size = new System.Drawing.Size(121, 21);
            this.cmbVehículo.TabIndex = 0;
            // 
            // lblVehículo
            // 
            this.lblVehículo.AutoSize = true;
            this.lblVehículo.Location = new System.Drawing.Point(3, 20);
            this.lblVehículo.Name = "lblVehículo";
            this.lblVehículo.Size = new System.Drawing.Size(92, 13);
            this.lblVehículo.TabIndex = 1;
            this.lblVehículo.Text = "Tipo de Vehículo:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(146, 54);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCantidadCobrar
            // 
            this.lblCantidadCobrar.AutoSize = true;
            this.lblCantidadCobrar.Location = new System.Drawing.Point(12, 108);
            this.lblCantidadCobrar.Name = "lblCantidadCobrar";
            this.lblCantidadCobrar.Size = new System.Drawing.Size(98, 13);
            this.lblCantidadCobrar.TabIndex = 3;
            this.lblCantidadCobrar.Text = "Cantidad a Cobrar: ";
            // 
            // txtCantidadCobrar
            // 
            this.txtCantidadCobrar.Location = new System.Drawing.Point(116, 105);
            this.txtCantidadCobrar.Name = "txtCantidadCobrar";
            this.txtCantidadCobrar.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadCobrar.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(79, 141);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 177);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCantidadCobrar);
            this.Controls.Add(this.lblCantidadCobrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVehículo);
            this.Controls.Add(this.cmbVehículo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVehículo;
        private System.Windows.Forms.Label lblVehículo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCantidadCobrar;
        private System.Windows.Forms.TextBox txtCantidadCobrar;
        private System.Windows.Forms.Button btnSalir;
    }
}

