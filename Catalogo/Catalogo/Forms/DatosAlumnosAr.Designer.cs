namespace DatosAlumnosDocentesAr
{
    partial class DatosAlumnosAr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosAlumnosAr));
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblCurp = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDatosAlumno = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCalMateria = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtNumControl = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNumeroControl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAlumno)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(70, 86);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(230, 20);
            this.txtCurp.TabIndex = 66;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(70, 111);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 20);
            this.txtTelefono.TabIndex = 65;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(124, 52);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(176, 20);
            this.dtpFechaNac.TabIndex = 64;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 63;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.TabIndex = 62;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(14, 117);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(54, 14);
            this.lblTelefono.TabIndex = 61;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(14, 140);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(37, 14);
            this.lblemail.TabIndex = 60;
            this.lblemail.Text = "email: ";
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurp.Location = new System.Drawing.Point(14, 92);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(36, 14);
            this.lblCurp.TabIndex = 59;
            this.lblCurp.Text = "Curp: ";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(5, 58);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(113, 14);
            this.lblFechaNac.TabIndex = 58;
            this.lblFechaNac.Text = "Fecha de Nacimiento: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(23, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 14);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre Personal: ";
            // 
            // dgvDatosAlumno
            // 
            this.dgvDatosAlumno.AllowUserToAddRows = false;
            this.dgvDatosAlumno.AllowUserToDeleteRows = false;
            this.dgvDatosAlumno.AllowUserToOrderColumns = true;
            this.dgvDatosAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosAlumno.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDatosAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FechaNacimiento,
            this.Curp,
            this.Telefono,
            this.Email,
            this.NumControl,
            this.Carrera,
            this.Materia,
            this.Calificacion});
            this.dgvDatosAlumno.Location = new System.Drawing.Point(326, 12);
            this.dgvDatosAlumno.Name = "dgvDatosAlumno";
            this.dgvDatosAlumno.ReadOnly = true;
            this.dgvDatosAlumno.Size = new System.Drawing.Size(941, 281);
            this.dgvDatosAlumno.TabIndex = 56;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Personal";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Curp
            // 
            this.Curp.HeaderText = "Curp";
            this.Curp.Name = "Curp";
            this.Curp.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NumControl
            // 
            this.NumControl.HeaderText = "No.Control";
            this.NumControl.Name = "NumControl";
            this.NumControl.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificación";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(58, 215);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(242, 20);
            this.txtMateria.TabIndex = 55;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1283, 25);
            this.toolStrip1.TabIndex = 54;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "Guardar datos";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsbImprimir.Text = "Imprimir datos";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(225, 270);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 53;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCalMateria
            // 
            this.txtCalMateria.Location = new System.Drawing.Point(133, 244);
            this.txtCalMateria.Name = "txtCalMateria";
            this.txtCalMateria.Size = new System.Drawing.Size(167, 20);
            this.txtCalMateria.TabIndex = 52;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(58, 190);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(242, 20);
            this.txtCarrera.TabIndex = 51;
            // 
            // txtNumControl
            // 
            this.txtNumControl.Location = new System.Drawing.Point(113, 164);
            this.txtNumControl.Name = "txtNumControl";
            this.txtNumControl.Size = new System.Drawing.Size(187, 20);
            this.txtNumControl.TabIndex = 50;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(5, 247);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(132, 14);
            this.lblCalificacion.TabIndex = 49;
            this.lblCalificacion.Text = "Calificación de la materia: ";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(5, 218);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(48, 14);
            this.lblMateria.TabIndex = 48;
            this.lblMateria.Text = "Materia: ";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(5, 194);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(47, 14);
            this.lblCarrera.TabIndex = 47;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblNumeroControl
            // 
            this.lblNumeroControl.AutoSize = true;
            this.lblNumeroControl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroControl.Location = new System.Drawing.Point(5, 170);
            this.lblNumeroControl.Name = "lblNumeroControl";
            this.lblNumeroControl.Size = new System.Drawing.Size(102, 14);
            this.lblNumeroControl.TabIndex = 46;
            this.lblNumeroControl.Text = "Número de Control: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DatosAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 306);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblCurp);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDatosAlumno);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCalMateria);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtNumControl);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblNumeroControl);
            this.Name = "DatosAlumnos";
            this.Text = "DatosAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAlumno)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvDatosAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        public System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txtCalMateria;
        public System.Windows.Forms.TextBox txtCarrera;
        public System.Windows.Forms.TextBox txtNumControl;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNumeroControl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}