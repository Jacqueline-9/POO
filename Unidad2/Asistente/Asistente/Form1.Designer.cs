namespace Asistente
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
            this.cmbAsistente = new System.Windows.Forms.ComboBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblAsistente = new System.Windows.Forms.Label();
            this.lblBebe = new System.Windows.Forms.Label();
            this.lblNiño = new System.Windows.Forms.Label();
            this.lblAdulto = new System.Windows.Forms.Label();
            this.lblAdultosMayores = new System.Windows.Forms.Label();
            this.btnContabilizar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAsistente
            // 
            this.cmbAsistente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsistente.FormattingEnabled = true;
            this.cmbAsistente.Location = new System.Drawing.Point(140, 25);
            this.cmbAsistente.Name = "cmbAsistente";
            this.cmbAsistente.Size = new System.Drawing.Size(121, 21);
            this.cmbAsistente.TabIndex = 0;
            this.cmbAsistente.SelectedIndexChanged += new System.EventHandler(this.cmbAsistente_SelectedIndexChanged);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(198, 52);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(63, 21);
            this.cmbCantidad.TabIndex = 1;
            this.cmbCantidad.SelectedIndexChanged += new System.EventHandler(this.cmbCantidad_SelectedIndexChanged);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(201, 189);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(109, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblAsistente
            // 
            this.lblAsistente.AutoSize = true;
            this.lblAsistente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistente.Location = new System.Drawing.Point(31, 26);
            this.lblAsistente.Name = "lblAsistente";
            this.lblAsistente.Size = new System.Drawing.Size(87, 20);
            this.lblAsistente.TabIndex = 4;
            this.lblAsistente.Text = "Asistente";
            // 
            // lblBebe
            // 
            this.lblBebe.AutoSize = true;
            this.lblBebe.Location = new System.Drawing.Point(35, 107);
            this.lblBebe.Name = "lblBebe";
            this.lblBebe.Size = new System.Drawing.Size(40, 13);
            this.lblBebe.TabIndex = 5;
            this.lblBebe.Text = "Bebés:";
            // 
            // lblNiño
            // 
            this.lblNiño.AutoSize = true;
            this.lblNiño.Location = new System.Drawing.Point(35, 130);
            this.lblNiño.Name = "lblNiño";
            this.lblNiño.Size = new System.Drawing.Size(37, 13);
            this.lblNiño.TabIndex = 6;
            this.lblNiño.Text = "Niños:";
            this.lblNiño.Click += new System.EventHandler(this.lblNiño_Click);
            // 
            // lblAdulto
            // 
            this.lblAdulto.AutoSize = true;
            this.lblAdulto.Location = new System.Drawing.Point(35, 153);
            this.lblAdulto.Name = "lblAdulto";
            this.lblAdulto.Size = new System.Drawing.Size(45, 13);
            this.lblAdulto.TabIndex = 7;
            this.lblAdulto.Text = "Adultos:";
            // 
            // lblAdultosMayores
            // 
            this.lblAdultosMayores.AutoSize = true;
            this.lblAdultosMayores.Location = new System.Drawing.Point(35, 177);
            this.lblAdultosMayores.Name = "lblAdultosMayores";
            this.lblAdultosMayores.Size = new System.Drawing.Size(88, 13);
            this.lblAdultosMayores.TabIndex = 8;
            this.lblAdultosMayores.Text = "Adultos Mayores:";
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Location = new System.Drawing.Point(153, 83);
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(75, 23);
            this.btnContabilizar.TabIndex = 9;
            this.btnContabilizar.Text = "Contabilizar";
            this.btnContabilizar.UseVisualStyleBackColor = true;
            this.btnContabilizar.Click += new System.EventHandler(this.btnContabilizar_Click);
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
            this.ClientSize = new System.Drawing.Size(288, 264);
            this.Controls.Add(this.btnContabilizar);
            this.Controls.Add(this.lblAdultosMayores);
            this.Controls.Add(this.lblAdulto);
            this.Controls.Add(this.lblNiño);
            this.Controls.Add(this.lblBebe);
            this.Controls.Add(this.lblAsistente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.cmbAsistente);
            this.Name = "Form1";
            this.Text = "Concierto-Guns n Roses";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAsistente;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblAsistente;
        private System.Windows.Forms.Label lblBebe;
        private System.Windows.Forms.Label lblNiño;
        private System.Windows.Forms.Label lblAdulto;
        private System.Windows.Forms.Label lblAdultosMayores;
        private System.Windows.Forms.Button btnContabilizar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

