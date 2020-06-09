namespace DatosAlumnoDocente
{
    partial class Docente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docente));
            this.txtMateriasImp = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.MateriasImparte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.lblMateriasImp = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblNumMaestro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMateriasImp
            // 
            this.txtMateriasImp.Location = new System.Drawing.Point(125, 81);
            this.txtMateriasImp.Name = "txtMateriasImp";
            this.txtMateriasImp.Size = new System.Drawing.Size(131, 20);
            this.txtMateriasImp.TabIndex = 20;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(181, 105);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvDocente
            // 
            this.dgvDocente.AllowUserToAddRows = false;
            this.dgvDocente.AllowUserToDeleteRows = false;
            this.dgvDocente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriasImparte});
            this.dgvDocente.Location = new System.Drawing.Point(288, 12);
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.Size = new System.Drawing.Size(143, 126);
            this.dgvDocente.TabIndex = 18;
            // 
            // MateriasImparte
            // 
            this.MateriasImparte.HeaderText = "Materias que Imparte";
            this.MateriasImparte.Name = "MateriasImparte";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(443, 25);
            this.toolStrip1.TabIndex = 17;
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
            this.txtSueldo.Location = new System.Drawing.Point(125, 54);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(131, 20);
            this.txtSueldo.TabIndex = 16;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(125, 28);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(131, 20);
            this.txtNumDoc.TabIndex = 15;
            // 
            // lblMateriasImp
            // 
            this.lblMateriasImp.AutoSize = true;
            this.lblMateriasImp.Location = new System.Drawing.Point(11, 84);
            this.lblMateriasImp.Name = "lblMateriasImp";
            this.lblMateriasImp.Size = new System.Drawing.Size(108, 13);
            this.lblMateriasImp.TabIndex = 14;
            this.lblMateriasImp.Text = "Materias que imparte:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(74, 57);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(46, 13);
            this.lblSueldo.TabIndex = 13;
            this.lblSueldo.Text = "Sueldo: ";
            // 
            // lblNumMaestro
            // 
            this.lblNumMaestro.AutoSize = true;
            this.lblNumMaestro.Location = new System.Drawing.Point(15, 31);
            this.lblNumMaestro.Name = "lblNumMaestro";
            this.lblNumMaestro.Size = new System.Drawing.Size(105, 13);
            this.lblNumMaestro.TabIndex = 12;
            this.lblNumMaestro.Text = "Número de maestro: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 153);
            this.Controls.Add(this.txtMateriasImp);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDocente);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblMateriasImp);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNumMaestro);
            this.Name = "Docente";
            this.Text = "Docente";
            this.Load += new System.EventHandler(this.Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMateriasImp;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.DataGridView dgvDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriasImparte;
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