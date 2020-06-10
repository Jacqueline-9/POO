namespace ConsumoElectricidad
{
    partial class FormRecibo
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
            this.lblKW = new System.Windows.Forms.Label();
            this.txtKW = new System.Windows.Forms.TextBox();
            this.btnDeterminarCosto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKW
            // 
            this.lblKW.AutoSize = true;
            this.lblKW.Location = new System.Drawing.Point(11, 50);
            this.lblKW.Name = "lblKW";
            this.lblKW.Size = new System.Drawing.Size(88, 13);
            this.lblKW.TabIndex = 0;
            this.lblKW.Text = "KW Consumidos:";
            // 
            // txtKW
            // 
            this.txtKW.Location = new System.Drawing.Point(105, 47);
            this.txtKW.Name = "txtKW";
            this.txtKW.Size = new System.Drawing.Size(100, 20);
            this.txtKW.TabIndex = 1;
            // 
            // btnDeterminarCosto
            // 
            this.btnDeterminarCosto.Location = new System.Drawing.Point(196, 73);
            this.btnDeterminarCosto.Name = "btnDeterminarCosto";
            this.btnDeterminarCosto.Size = new System.Drawing.Size(75, 23);
            this.btnDeterminarCosto.TabIndex = 2;
            this.btnDeterminarCosto.Text = "Calcular";
            this.btnDeterminarCosto.UseVisualStyleBackColor = true;
            this.btnDeterminarCosto.Click += new System.EventHandler(this.btnDeterminarCosto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(196, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(12, 121);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(95, 13);
            this.lblConsumo.TabIndex = 4;
            this.lblConsumo.Text = "Cantidad a Pagar: ";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(113, 118);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(74, 20);
            this.txtConsumo.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(105, 12);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(10, 15);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(89, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo de Contrato:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 178);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeterminarCosto);
            this.Controls.Add(this.txtKW);
            this.Controls.Add(this.lblKW);
            this.Name = "Form1";
            this.Text = "Comisión Federal de Electricidad";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKW;
        private System.Windows.Forms.TextBox txtKW;
        private System.Windows.Forms.Button btnDeterminarCosto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

