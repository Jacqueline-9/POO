namespace DiasDeVacaciones
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblAnios = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDiasdeVaciones = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtaniosTrabajados = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.Location = new System.Drawing.Point(12, 30);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(91, 13);
            this.lblAnios.TabIndex = 0;
            this.lblAnios.Text = "Años Trabajando:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(162, 72);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblDiasdeVaciones
            // 
            this.lblDiasdeVaciones.AutoSize = true;
            this.lblDiasdeVaciones.Location = new System.Drawing.Point(12, 120);
            this.lblDiasdeVaciones.Name = "lblDiasdeVaciones";
            this.lblDiasdeVaciones.Size = new System.Drawing.Size(107, 13);
            this.lblDiasdeVaciones.TabIndex = 3;
            this.lblDiasdeVaciones.Text = "Días de Vacaciones:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(159, 178);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtaniosTrabajados
            // 
            this.txtaniosTrabajados.Location = new System.Drawing.Point(121, 27);
            this.txtaniosTrabajados.Name = "txtaniosTrabajados";
            this.txtaniosTrabajados.Size = new System.Drawing.Size(100, 20);
            this.txtaniosTrabajados.TabIndex = 5;
            this.txtaniosTrabajados.TextChanged += new System.EventHandler(this.txtaniosTrabajados_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 213);
            this.Controls.Add(this.txtaniosTrabajados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblDiasdeVaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAnios);
            this.Name = "Form1";
            this.Text = "Determinar Días de Vacaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnios;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDiasdeVaciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtaniosTrabajados;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

