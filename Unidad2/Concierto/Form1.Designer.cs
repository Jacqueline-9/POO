namespace Concierto
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
            this.lblAsistente = new System.Windows.Forms.Label();
            this.cmbAsistente = new System.Windows.Forms.ComboBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.btnContabilizar = new System.Windows.Forms.Button();
            this.lblBebe = new System.Windows.Forms.Label();
            this.lblNiño = new System.Windows.Forms.Label();
            this.lblAdulto = new System.Windows.Forms.Label();
            this.lblAdultosMayores = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsistente
            // 
            this.lblAsistente.AutoSize = true;
            this.lblAsistente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistente.Location = new System.Drawing.Point(34, 25);
            this.lblAsistente.Name = "lblAsistente";
            this.lblAsistente.Size = new System.Drawing.Size(87, 20);
            this.lblAsistente.TabIndex = 6;
            this.lblAsistente.Text = "Asistente";
            // 
            // cmbAsistente
            // 
            this.cmbAsistente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsistente.FormattingEnabled = true;
            this.cmbAsistente.Location = new System.Drawing.Point(138, 24);
            this.cmbAsistente.Name = "cmbAsistente";
            this.cmbAsistente.Size = new System.Drawing.Size(121, 21);
            this.cmbAsistente.TabIndex = 7;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(196, 51);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(63, 21);
            this.cmbCantidad.TabIndex = 8;
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Location = new System.Drawing.Point(138, 78);
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(75, 23);
            this.btnContabilizar.TabIndex = 11;
            this.btnContabilizar.Text = "Contabilizar";
            this.btnContabilizar.UseVisualStyleBackColor = true;
            this.btnContabilizar.Click += new System.EventHandler(this.btnContabilizar_Click);
            // 
            // lblBebe
            // 
            this.lblBebe.AutoSize = true;
            this.lblBebe.Location = new System.Drawing.Point(49, 116);
            this.lblBebe.Name = "lblBebe";
            this.lblBebe.Size = new System.Drawing.Size(40, 13);
            this.lblBebe.TabIndex = 12;
            this.lblBebe.Text = "Bebés:";
            // 
            // lblNiño
            // 
            this.lblNiño.AutoSize = true;
            this.lblNiño.Location = new System.Drawing.Point(49, 144);
            this.lblNiño.Name = "lblNiño";
            this.lblNiño.Size = new System.Drawing.Size(37, 13);
            this.lblNiño.TabIndex = 13;
            this.lblNiño.Text = "Niños:";
            // 
            // lblAdulto
            // 
            this.lblAdulto.AutoSize = true;
            this.lblAdulto.Location = new System.Drawing.Point(49, 175);
            this.lblAdulto.Name = "lblAdulto";
            this.lblAdulto.Size = new System.Drawing.Size(45, 13);
            this.lblAdulto.TabIndex = 14;
            this.lblAdulto.Text = "Adultos:";
            // 
            // lblAdultosMayores
            // 
            this.lblAdultosMayores.AutoSize = true;
            this.lblAdultosMayores.Location = new System.Drawing.Point(49, 205);
            this.lblAdultosMayores.Name = "lblAdultosMayores";
            this.lblAdultosMayores.Size = new System.Drawing.Size(88, 13);
            this.lblAdultosMayores.TabIndex = 15;
            this.lblAdultosMayores.Text = "Adultos Mayores:";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(196, 227);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 16;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(102, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.ClientSize = new System.Drawing.Size(282, 280);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblAdultosMayores);
            this.Controls.Add(this.lblAdulto);
            this.Controls.Add(this.lblNiño);
            this.Controls.Add(this.lblBebe);
            this.Controls.Add(this.btnContabilizar);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.cmbAsistente);
            this.Controls.Add(this.lblAsistente);
            this.Name = "Form1";
            this.Text = "Concierto Guns n Roses";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsistente;
        private System.Windows.Forms.ComboBox cmbAsistente;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Button btnContabilizar;
        private System.Windows.Forms.Label lblBebe;
        private System.Windows.Forms.Label lblNiño;
        private System.Windows.Forms.Label lblAdulto;
        private System.Windows.Forms.Label lblAdultosMayores;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

