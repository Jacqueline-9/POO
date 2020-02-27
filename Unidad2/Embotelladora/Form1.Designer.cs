namespace Embotelladora
{
    partial class frmEmbotelladora
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
            this.lblNivelLlenado = new System.Windows.Forms.Label();
            this.txtNivelLlenado = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNivelLlenado
            // 
            this.lblNivelLlenado.AutoSize = true;
            this.lblNivelLlenado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelLlenado.Location = new System.Drawing.Point(25, 50);
            this.lblNivelLlenado.Name = "lblNivelLlenado";
            this.lblNivelLlenado.Size = new System.Drawing.Size(165, 12);
            this.lblNivelLlenado.TabIndex = 0;
            this.lblNivelLlenado.Text = "Introduce el nivel de llenado:";
            // 
            // txtNivelLlenado
            // 
            this.txtNivelLlenado.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelLlenado.Location = new System.Drawing.Point(196, 45);
            this.txtNivelLlenado.Name = "txtNivelLlenado";
            this.txtNivelLlenado.Size = new System.Drawing.Size(100, 22);
            this.txtNivelLlenado.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(221, 103);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 27);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmEmbotelladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 202);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNivelLlenado);
            this.Controls.Add(this.lblNivelLlenado);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmEmbotelladora";
            this.Text = "Embotelladora Ahuacatlán - Verificador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNivelLlenado;
        private System.Windows.Forms.TextBox txtNivelLlenado;
        private System.Windows.Forms.Button btnVerificar;
    }
}

