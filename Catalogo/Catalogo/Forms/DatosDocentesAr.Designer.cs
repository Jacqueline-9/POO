namespace DatosAlumnosDocentesAr
{
    partial class DatosDocentesAr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosDocentesAr));
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
            this.dgvDatosDocentes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriasImparte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMateriasImp = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.lblMateriasImp = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblNumMaestro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDocentes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(69, 96);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(230, 20);
            this.txtCurp.TabIndex = 64;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(69, 121);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 20);
            this.txtTelefono.TabIndex = 63;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(123, 62);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(176, 20);
            this.dtpFechaNac.TabIndex = 62;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 61;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.TabIndex = 60;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(13, 127);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(54, 14);
            this.lblTelefono.TabIndex = 59;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(13, 150);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(37, 14);
            this.lblemail.TabIndex = 58;
            this.lblemail.Text = "email: ";
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurp.Location = new System.Drawing.Point(13, 102);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(36, 14);
            this.lblCurp.TabIndex = 57;
            this.lblCurp.Text = "Curp: ";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(4, 62);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(113, 14);
            this.lblFechaNac.TabIndex = 56;
            this.lblFechaNac.Text = "Fecha de Nacimiento: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 14);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Text = "Nombre Personal: ";
            // 
            // dgvDatosDocentes
            // 
            this.dgvDatosDocentes.AllowUserToAddRows = false;
            this.dgvDatosDocentes.AllowUserToDeleteRows = false;
            this.dgvDatosDocentes.AllowUserToOrderColumns = true;
            this.dgvDatosDocentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosDocentes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDatosDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FechaNac,
            this.Curp,
            this.Telefono,
            this.Email,
            this.NumeroDocente,
            this.Sueldo,
            this.MateriasImparte});
            this.dgvDatosDocentes.Location = new System.Drawing.Point(317, 12);
            this.dgvDatosDocentes.Name = "dgvDatosDocentes";
            this.dgvDatosDocentes.ReadOnly = true;
            this.dgvDatosDocentes.Size = new System.Drawing.Size(844, 258);
            this.dgvDatosDocentes.TabIndex = 54;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha de Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
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
            // NumeroDocente
            // 
            this.NumeroDocente.HeaderText = "Número de Docente";
            this.NumeroDocente.Name = "NumeroDocente";
            this.NumeroDocente.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // MateriasImparte
            // 
            this.MateriasImparte.HeaderText = "Materias que Imparte";
            this.MateriasImparte.Name = "MateriasImparte";
            this.MateriasImparte.ReadOnly = true;
            // 
            // txtMateriasImp
            // 
            this.txtMateriasImp.Location = new System.Drawing.Point(123, 223);
            this.txtMateriasImp.Name = "txtMateriasImp";
            this.txtMateriasImp.Size = new System.Drawing.Size(176, 20);
            this.txtMateriasImp.TabIndex = 53;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(224, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1175, 25);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsbImprimir.Text = "Imprimir Datos";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(123, 199);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(176, 20);
            this.txtSueldo.TabIndex = 50;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(123, 173);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(176, 20);
            this.txtNumDoc.TabIndex = 49;
            // 
            // lblMateriasImp
            // 
            this.lblMateriasImp.AutoSize = true;
            this.lblMateriasImp.Location = new System.Drawing.Point(9, 226);
            this.lblMateriasImp.Name = "lblMateriasImp";
            this.lblMateriasImp.Size = new System.Drawing.Size(117, 13);
            this.lblMateriasImp.TabIndex = 48;
            this.lblMateriasImp.Text = "Materia (s) que imparte:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(72, 204);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(46, 13);
            this.lblSueldo.TabIndex = 47;
            this.lblSueldo.Text = "Sueldo: ";
            // 
            // lblNumMaestro
            // 
            this.lblNumMaestro.AutoSize = true;
            this.lblNumMaestro.Location = new System.Drawing.Point(13, 180);
            this.lblNumMaestro.Name = "lblNumMaestro";
            this.lblNumMaestro.Size = new System.Drawing.Size(105, 13);
            this.lblNumMaestro.TabIndex = 46;
            this.lblNumMaestro.Text = "Número de maestro: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DatosDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 293);
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
            this.Controls.Add(this.dgvDatosDocentes);
            this.Controls.Add(this.txtMateriasImp);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblMateriasImp);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNumMaestro);
            this.Name = "DatosDocentes";
            this.Text = "DatosDocente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDocentes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDatosDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriasImparte;
        public System.Windows.Forms.TextBox txtMateriasImp;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        public System.Windows.Forms.TextBox txtSueldo;
        public System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label lblMateriasImp;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblNumMaestro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}