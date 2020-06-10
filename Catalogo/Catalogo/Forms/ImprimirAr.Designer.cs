namespace DatosPaisesN
{
    partial class ImprimirAr
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpbDocumento = new System.Windows.Forms.GroupBox();
            this.lblNombrePais = new System.Windows.Forms.Label();
            this.lblTercerColor = new System.Windows.Forms.Label();
            this.lblTotalPoblacion = new System.Windows.Forms.Label();
            this.lblPrimerColor = new System.Windows.Forms.Label();
            this.lblIdiomaI = new System.Windows.Forms.Label();
            this.lblSegundoColor = new System.Windows.Forms.Label();
            this.gpbDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(75, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 53;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpbDocumento
            // 
            this.gpbDocumento.Controls.Add(this.lblNombrePais);
            this.gpbDocumento.Controls.Add(this.lblTercerColor);
            this.gpbDocumento.Controls.Add(this.lblTotalPoblacion);
            this.gpbDocumento.Controls.Add(this.lblPrimerColor);
            this.gpbDocumento.Controls.Add(this.lblIdiomaI);
            this.gpbDocumento.Controls.Add(this.lblSegundoColor);
            this.gpbDocumento.Location = new System.Drawing.Point(12, 3);
            this.gpbDocumento.Name = "gpbDocumento";
            this.gpbDocumento.Size = new System.Drawing.Size(200, 198);
            this.gpbDocumento.TabIndex = 52;
            this.gpbDocumento.TabStop = false;
            // 
            // lblNombrePais
            // 
            this.lblNombrePais.AutoSize = true;
            this.lblNombrePais.Location = new System.Drawing.Point(6, 21);
            this.lblNombrePais.Name = "lblNombrePais";
            this.lblNombrePais.Size = new System.Drawing.Size(92, 13);
            this.lblNombrePais.TabIndex = 21;
            this.lblNombrePais.Text = "Nombre del País: ";
            // 
            // lblTercerColor
            // 
            this.lblTercerColor.AutoSize = true;
            this.lblTercerColor.Location = new System.Drawing.Point(6, 175);
            this.lblTercerColor.Name = "lblTercerColor";
            this.lblTercerColor.Size = new System.Drawing.Size(70, 13);
            this.lblTercerColor.TabIndex = 26;
            this.lblTercerColor.Text = "Tercer color: ";
            // 
            // lblTotalPoblacion
            // 
            this.lblTotalPoblacion.AutoSize = true;
            this.lblTotalPoblacion.Location = new System.Drawing.Point(6, 48);
            this.lblTotalPoblacion.Name = "lblTotalPoblacion";
            this.lblTotalPoblacion.Size = new System.Drawing.Size(102, 13);
            this.lblTotalPoblacion.TabIndex = 22;
            this.lblTotalPoblacion.Text = "Total de Población: ";
            // 
            // lblPrimerColor
            // 
            this.lblPrimerColor.AutoSize = true;
            this.lblPrimerColor.Location = new System.Drawing.Point(6, 121);
            this.lblPrimerColor.Name = "lblPrimerColor";
            this.lblPrimerColor.Size = new System.Drawing.Size(68, 13);
            this.lblPrimerColor.TabIndex = 25;
            this.lblPrimerColor.Text = "Primer color: ";
            // 
            // lblIdiomaI
            // 
            this.lblIdiomaI.AutoSize = true;
            this.lblIdiomaI.Location = new System.Drawing.Point(6, 76);
            this.lblIdiomaI.Name = "lblIdiomaI";
            this.lblIdiomaI.Size = new System.Drawing.Size(44, 13);
            this.lblIdiomaI.TabIndex = 23;
            this.lblIdiomaI.Text = "Idioma: ";
            // 
            // lblSegundoColor
            // 
            this.lblSegundoColor.AutoSize = true;
            this.lblSegundoColor.Location = new System.Drawing.Point(6, 146);
            this.lblSegundoColor.Name = "lblSegundoColor";
            this.lblSegundoColor.Size = new System.Drawing.Size(82, 13);
            this.lblSegundoColor.TabIndex = 24;
            this.lblSegundoColor.Text = "Segundo color: ";
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 236);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbDocumento);
            this.Name = "Imprimir";
            this.Text = "Imprimir";
            this.gpbDocumento.ResumeLayout(false);
            this.gpbDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gpbDocumento;
        public System.Windows.Forms.Label lblNombrePais;
        public System.Windows.Forms.Label lblTercerColor;
        public System.Windows.Forms.Label lblTotalPoblacion;
        public System.Windows.Forms.Label lblPrimerColor;
        public System.Windows.Forms.Label lblIdiomaI;
        public System.Windows.Forms.Label lblSegundoColor;
    }
}