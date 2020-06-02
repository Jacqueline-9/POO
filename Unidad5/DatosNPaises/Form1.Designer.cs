namespace DatosNPaises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.txtColor3 = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColoresBandera = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPaisBuscar = new System.Windows.Forms.Label();
            this.txtPaisBuscar = new System.Windows.Forms.TextBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblCantidadpaises = new System.Windows.Forms.Label();
            this.txtPaisesRegistrar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbImprimir,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(280, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "Guardar datos ";
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
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Text = "Salir del programa";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // txtColor3
            // 
            this.txtColor3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtColor3.Enabled = false;
            this.txtColor3.Location = new System.Drawing.Point(104, 259);
            this.txtColor3.Name = "txtColor3";
            this.txtColor3.Size = new System.Drawing.Size(153, 20);
            this.txtColor3.TabIndex = 48;
            // 
            // txtColor2
            // 
            this.txtColor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtColor2.Enabled = false;
            this.txtColor2.Location = new System.Drawing.Point(104, 233);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(153, 20);
            this.txtColor2.TabIndex = 47;
            // 
            // txtColor1
            // 
            this.txtColor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtColor1.Enabled = false;
            this.txtColor1.Location = new System.Drawing.Point(104, 208);
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(153, 20);
            this.txtColor1.TabIndex = 46;
            // 
            // lblColor3
            // 
            this.lblColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor3.AutoSize = true;
            this.lblColor3.BackColor = System.Drawing.Color.Transparent;
            this.lblColor3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor3.Location = new System.Drawing.Point(24, 265);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(68, 14);
            this.lblColor3.TabIndex = 45;
            this.lblColor3.Text = "Tercer color:";
            // 
            // lblColor2
            // 
            this.lblColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor2.AutoSize = true;
            this.lblColor2.BackColor = System.Drawing.Color.Transparent;
            this.lblColor2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor2.Location = new System.Drawing.Point(12, 239);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(80, 14);
            this.lblColor2.TabIndex = 44;
            this.lblColor2.Text = "Segundo color:";
            // 
            // lblColor1
            // 
            this.lblColor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColor1.AutoSize = true;
            this.lblColor1.BackColor = System.Drawing.Color.Transparent;
            this.lblColor1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.Location = new System.Drawing.Point(28, 214);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(70, 14);
            this.lblColor1.TabIndex = 43;
            this.lblColor1.Text = "Primer color: ";
            // 
            // lblColoresBandera
            // 
            this.lblColoresBandera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColoresBandera.AutoSize = true;
            this.lblColoresBandera.BackColor = System.Drawing.Color.Transparent;
            this.lblColoresBandera.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColoresBandera.Location = new System.Drawing.Point(12, 191);
            this.lblColoresBandera.Name = "lblColoresBandera";
            this.lblColoresBandera.Size = new System.Drawing.Size(245, 14);
            this.lblColoresBandera.TabIndex = 42;
            this.lblColoresBandera.Text = "3 colores principales de la bandera del país";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Enabled = false;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(104, 158);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(108, 22);
            this.cmbIdioma.TabIndex = 41;
            // 
            // lblIdioma
            // 
            this.lblIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.lblIdioma.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(55, 161);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(43, 14);
            this.lblIdioma.TabIndex = 40;
            this.lblIdioma.Text = "Idioma: ";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPoblacion.Enabled = false;
            this.txtPoblacion.Location = new System.Drawing.Point(104, 132);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(153, 20);
            this.txtPoblacion.TabIndex = 39;
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPoblacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacion.Location = new System.Drawing.Point(2, 138);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(96, 14);
            this.lblPoblacion.TabIndex = 38;
            this.lblPoblacion.Text = "Total de Población:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 14);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre del País:";
            // 
            // lblPaisBuscar
            // 
            this.lblPaisBuscar.AutoSize = true;
            this.lblPaisBuscar.Location = new System.Drawing.Point(3, 21);
            this.lblPaisBuscar.Name = "lblPaisBuscar";
            this.lblPaisBuscar.Size = new System.Drawing.Size(90, 14);
            this.lblPaisBuscar.TabIndex = 50;
            this.lblPaisBuscar.Text = "Nombre del país: ";
            // 
            // txtPaisBuscar
            // 
            this.txtPaisBuscar.Location = new System.Drawing.Point(99, 18);
            this.txtPaisBuscar.Name = "txtPaisBuscar";
            this.txtPaisBuscar.Size = new System.Drawing.Size(119, 20);
            this.txtPaisBuscar.TabIndex = 51;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.lblPaisBuscar);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtPaisBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(33, 23);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(224, 74);
            this.gbBuscar.TabIndex = 53;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(65, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.Enabled = false;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(104, 103);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(153, 22);
            this.cmbPais.TabIndex = 54;
            // 
            // lblCantidadpaises
            // 
            this.lblCantidadpaises.AutoSize = true;
            this.lblCantidadpaises.Location = new System.Drawing.Point(2, 33);
            this.lblCantidadpaises.Name = "lblCantidadpaises";
            this.lblCantidadpaises.Size = new System.Drawing.Size(158, 14);
            this.lblCantidadpaises.TabIndex = 55;
            this.lblCantidadpaises.Text = "Cantidad de Países a registrar: ";
            // 
            // txtPaisesRegistrar
            // 
            this.txtPaisesRegistrar.Location = new System.Drawing.Point(162, 30);
            this.txtPaisesRegistrar.Name = "txtPaisesRegistrar";
            this.txtPaisesRegistrar.Size = new System.Drawing.Size(100, 20);
            this.txtPaisesRegistrar.TabIndex = 56;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(187, 56);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 57;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 293);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPaisesRegistrar);
            this.Controls.Add(this.lblCantidadpaises);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.txtColor3);
            this.Controls.Add(this.txtColor2);
            this.Controls.Add(this.txtColor1);
            this.Controls.Add(this.lblColor3);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.lblColoresBandera);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Datos de n Paises";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.Label lblColor3;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Label lblColoresBandera;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPaisBuscar;
        private System.Windows.Forms.TextBox txtPaisBuscar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblCantidadpaises;
        private System.Windows.Forms.TextBox txtPaisesRegistrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}

