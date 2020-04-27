namespace DatosAlumnosDocentes
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
            this.lblNumMaestro = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblMateriasImp = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.MateriasImparte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMateriasImp = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumMaestro
            // 
            this.lblNumMaestro.AutoSize = true;
            this.lblNumMaestro.Location = new System.Drawing.Point(13, 35);
            this.lblNumMaestro.Name = "lblNumMaestro";
            this.lblNumMaestro.Size = new System.Drawing.Size(105, 13);
            this.lblNumMaestro.TabIndex = 0;
            this.lblNumMaestro.Text = "Número de maestro: ";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(72, 59);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(46, 13);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "Sueldo: ";
            // 
            // lblMateriasImp
            // 
            this.lblMateriasImp.AutoSize = true;
            this.lblMateriasImp.Location = new System.Drawing.Point(9, 81);
            this.lblMateriasImp.Name = "lblMateriasImp";
            this.lblMateriasImp.Size = new System.Drawing.Size(108, 13);
            this.lblMateriasImp.TabIndex = 2;
            this.lblMateriasImp.Text = "Materias que imparte:";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(123, 28);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(131, 20);
            this.txtNumDoc.TabIndex = 4;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(123, 54);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(131, 20);
            this.txtSueldo.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(443, 25);
            this.toolStrip1.TabIndex = 8;
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
            // dgvDocente
            // 
            this.dgvDocente.AllowUserToAddRows = false;
            this.dgvDocente.AllowUserToDeleteRows = false;
            this.dgvDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriasImparte});
            this.dgvDocente.Location = new System.Drawing.Point(286, 12);
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.Size = new System.Drawing.Size(145, 126);
            this.dgvDocente.TabIndex = 9;
            // 
            // MateriasImparte
            // 
            this.MateriasImparte.HeaderText = "Materias que Imparte";
            this.MateriasImparte.Name = "MateriasImparte";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(179, 105);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMateriasImp
            // 
            this.txtMateriasImp.Location = new System.Drawing.Point(123, 81);
            this.txtMateriasImp.Name = "txtMateriasImp";
            this.txtMateriasImp.Size = new System.Drawing.Size(131, 20);
            this.txtMateriasImp.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 147);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumMaestro;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblMateriasImp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txtNumDoc;
        public System.Windows.Forms.TextBox txtSueldo;
        public System.Windows.Forms.TextBox txtMateriasImp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView dgvDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriasImparte;
    }
}