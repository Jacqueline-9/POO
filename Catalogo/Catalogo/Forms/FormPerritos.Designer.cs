namespace Perritos
{
    partial class FormPerritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerritos));
            this.dgvDatosPerritos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpFechaTer = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dtpFechaIn = new System.Windows.Forms.DateTimePicker();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPerritos)).BeginInit();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosPerritos
            // 
            this.dgvDatosPerritos.AllowUserToAddRows = false;
            this.dgvDatosPerritos.AllowUserToDeleteRows = false;
            this.dgvDatosPerritos.AllowUserToOrderColumns = true;
            this.dgvDatosPerritos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosPerritos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDatosPerritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPerritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Edad,
            this.Peso,
            this.Sexo,
            this.Color1,
            this.Color2,
            this.FIngreso,
            this.FEgreso});
            this.dgvDatosPerritos.Location = new System.Drawing.Point(349, 59);
            this.dgvDatosPerritos.Name = "dgvDatosPerritos";
            this.dgvDatosPerritos.ReadOnly = true;
            this.dgvDatosPerritos.Size = new System.Drawing.Size(981, 252);
            this.dgvDatosPerritos.TabIndex = 56;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad(meses)";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso(gramos)";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Color1
            // 
            this.Color1.HeaderText = "Color 1";
            this.Color1.Name = "Color1";
            this.Color1.ReadOnly = true;
            // 
            // Color2
            // 
            this.Color2.HeaderText = "Color 2";
            this.Color2.Name = "Color2";
            this.Color2.ReadOnly = true;
            // 
            // FIngreso
            // 
            this.FIngreso.HeaderText = "F. Ingreso";
            this.FIngreso.Name = "FIngreso";
            this.FIngreso.ReadOnly = true;
            // 
            // FEgreso
            // 
            this.FEgreso.HeaderText = "F. Egreso";
            this.FEgreso.Name = "FEgreso";
            this.FEgreso.ReadOnly = true;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Enabled = false;
            this.btnPromedio.Location = new System.Drawing.Point(245, 373);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 55;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.cmbSexo);
            this.gpbDatos.Controls.Add(this.dtpFechaTer);
            this.gpbDatos.Controls.Add(this.lblNombre);
            this.gpbDatos.Controls.Add(this.lblEdad);
            this.gpbDatos.Controls.Add(this.lblPeso);
            this.gpbDatos.Controls.Add(this.txtColor2);
            this.gpbDatos.Controls.Add(this.lblSexo);
            this.gpbDatos.Controls.Add(this.btnRegistrar);
            this.gpbDatos.Controls.Add(this.txtColor1);
            this.gpbDatos.Controls.Add(this.label5);
            this.gpbDatos.Controls.Add(this.lblColor2);
            this.gpbDatos.Controls.Add(this.label6);
            this.gpbDatos.Controls.Add(this.lblColor1);
            this.gpbDatos.Controls.Add(this.txtNombre);
            this.gpbDatos.Controls.Add(this.txtEdad);
            this.gpbDatos.Controls.Add(this.txtPeso);
            this.gpbDatos.Controls.Add(this.dtpFechaIn);
            this.gpbDatos.Enabled = false;
            this.gpbDatos.Location = new System.Drawing.Point(25, 43);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(304, 291);
            this.gpbDatos.TabIndex = 54;
            this.gpbDatos.TabStop = false;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(106, 105);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 42;
            // 
            // dtpFechaTer
            // 
            this.dtpFechaTer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaTer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTer.Location = new System.Drawing.Point(117, 233);
            this.dtpFechaTer.Name = "dtpFechaTer";
            this.dtpFechaTer.Size = new System.Drawing.Size(178, 20);
            this.dtpFechaTer.TabIndex = 32;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(16, 47);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(88, 15);
            this.lblEdad.TabIndex = 22;
            this.lblEdad.Text = "Edad (meses):";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(6, 77);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(94, 15);
            this.lblPeso.TabIndex = 23;
            this.lblPeso.Text = "Peso (gramos):";
            // 
            // txtColor2
            // 
            this.txtColor2.Location = new System.Drawing.Point(115, 166);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(126, 20);
            this.txtColor2.TabIndex = 41;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(61, 105);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 15);
            this.lblSexo.TabIndex = 24;
            this.lblSexo.Text = "Sexo:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(220, 262);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 35;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtColor1
            // 
            this.txtColor1.Location = new System.Drawing.Point(115, 138);
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(126, 20);
            this.txtColor1.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha de Ingreso: ";
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.BackColor = System.Drawing.Color.Transparent;
            this.lblColor2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor2.Location = new System.Drawing.Point(4, 168);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(105, 15);
            this.lblColor2.TabIndex = 39;
            this.lblColor2.Text = "Color de Pelaje 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha de Egreso:";
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.BackColor = System.Drawing.Color.Transparent;
            this.lblColor1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.Location = new System.Drawing.Point(4, 140);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(105, 15);
            this.lblColor1.TabIndex = 38;
            this.lblColor1.Text = "Color de Pelaje 1:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(67, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(106, 45);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(112, 20);
            this.txtEdad.TabIndex = 28;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(106, 75);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(112, 20);
            this.txtPeso.TabIndex = 29;
            // 
            // dtpFechaIn
            // 
            this.dtpFechaIn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIn.Location = new System.Drawing.Point(117, 200);
            this.dtpFechaIn.Name = "dtpFechaIn";
            this.dtpFechaIn.Size = new System.Drawing.Size(178, 20);
            this.dtpFechaIn.TabIndex = 31;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(403, 15);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 53;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(205, 17);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(183, 20);
            this.txtCantidad.TabIndex = 52;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 20);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(187, 14);
            this.lblCantidad.TabIndex = 51;
            this.lblCantidad.Text = "Cantidad de perritos a registrar: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(711, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 131);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(245, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(131, 340);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 48;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 451);
            this.Controls.Add(this.dgvDatosPerritos);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPerritos)).EndInit();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosPerritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEgreso;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtpFechaTer;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DateTimePicker dtpFechaIn;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

