namespace DatosPaisMundo
{
    partial class FormDatosPaisesMundo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosPaisesMundo));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblColoresBandera = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.txtColor3 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardarImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNombrePais = new System.Windows.Forms.Label();
            this.lblTotalPoblacion = new System.Windows.Forms.Label();
            this.lblIdiomaI = new System.Windows.Forms.Label();
            this.lblSegundoColor = new System.Windows.Forms.Label();
            this.lblPrimerColor = new System.Windows.Forms.Label();
            this.lblTercerColor = new System.Windows.Forms.Label();
            this.gpbDocumento = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpbDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del País:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombre.Location = new System.Drawing.Point(104, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPoblacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacion.Location = new System.Drawing.Point(2, 62);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(96, 14);
            this.lblPoblacion.TabIndex = 2;
            this.lblPoblacion.Text = "Total de Población:";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPoblacion.Location = new System.Drawing.Point(104, 56);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(153, 20);
            this.txtPoblacion.TabIndex = 3;
            // 
            // lblIdioma
            // 
            this.lblIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.lblIdioma.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(55, 85);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(43, 14);
            this.lblIdioma.TabIndex = 4;
            this.lblIdioma.Text = "Idioma: ";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(104, 82);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(108, 21);
            this.cmbIdioma.TabIndex = 9;
            // 
            // lblColoresBandera
            // 
            this.lblColoresBandera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColoresBandera.AutoSize = true;
            this.lblColoresBandera.BackColor = System.Drawing.Color.Transparent;
            this.lblColoresBandera.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColoresBandera.Location = new System.Drawing.Point(12, 115);
            this.lblColoresBandera.Name = "lblColoresBandera";
            this.lblColoresBandera.Size = new System.Drawing.Size(245, 14);
            this.lblColoresBandera.TabIndex = 13;
            this.lblColoresBandera.Text = "3 colores principales de la bandera del país";
            // 
            // lblColor1
            // 
            this.lblColor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColor1.AutoSize = true;
            this.lblColor1.BackColor = System.Drawing.Color.Transparent;
            this.lblColor1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.Location = new System.Drawing.Point(28, 138);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(70, 14);
            this.lblColor1.TabIndex = 14;
            this.lblColor1.Text = "Primer color: ";
            // 
            // lblColor2
            // 
            this.lblColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor2.AutoSize = true;
            this.lblColor2.BackColor = System.Drawing.Color.Transparent;
            this.lblColor2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor2.Location = new System.Drawing.Point(12, 160);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(80, 14);
            this.lblColor2.TabIndex = 15;
            this.lblColor2.Text = "Segundo color:";
            // 
            // lblColor3
            // 
            this.lblColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor3.AutoSize = true;
            this.lblColor3.BackColor = System.Drawing.Color.Transparent;
            this.lblColor3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor3.Location = new System.Drawing.Point(24, 189);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(68, 14);
            this.lblColor3.TabIndex = 16;
            this.lblColor3.Text = "Tercer color:";
            // 
            // txtColor1
            // 
            this.txtColor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtColor1.Location = new System.Drawing.Point(104, 132);
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(153, 20);
            this.txtColor1.TabIndex = 17;
            // 
            // txtColor2
            // 
            this.txtColor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtColor2.Location = new System.Drawing.Point(104, 157);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(153, 20);
            this.txtColor2.TabIndex = 18;
            // 
            // txtColor3
            // 
            this.txtColor3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtColor3.Location = new System.Drawing.Point(104, 183);
            this.txtColor3.Name = "txtColor3";
            this.txtColor3.Size = new System.Drawing.Size(153, 20);
            this.txtColor3.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardarImprimir,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardarImprimir
            // 
            this.tsbGuardarImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardarImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardarImprimir.Image")));
            this.tsbGuardarImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardarImprimir.Name = "tsbGuardarImprimir";
            this.tsbGuardarImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardarImprimir.Text = "Guardar e imprimir datos ";
            this.tsbGuardarImprimir.Click += new System.EventHandler(this.tsbGuardarImprimir_Click);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNombrePais
            // 
            this.lblNombrePais.AutoSize = true;
            this.lblNombrePais.Location = new System.Drawing.Point(6, 16);
            this.lblNombrePais.Name = "lblNombrePais";
            this.lblNombrePais.Size = new System.Drawing.Size(92, 13);
            this.lblNombrePais.TabIndex = 21;
            this.lblNombrePais.Text = "Nombre del País: ";
            // 
            // lblTotalPoblacion
            // 
            this.lblTotalPoblacion.AutoSize = true;
            this.lblTotalPoblacion.Location = new System.Drawing.Point(6, 42);
            this.lblTotalPoblacion.Name = "lblTotalPoblacion";
            this.lblTotalPoblacion.Size = new System.Drawing.Size(102, 13);
            this.lblTotalPoblacion.TabIndex = 22;
            this.lblTotalPoblacion.Text = "Total de Población: ";
            // 
            // lblIdiomaI
            // 
            this.lblIdiomaI.AutoSize = true;
            this.lblIdiomaI.Location = new System.Drawing.Point(6, 68);
            this.lblIdiomaI.Name = "lblIdiomaI";
            this.lblIdiomaI.Size = new System.Drawing.Size(44, 13);
            this.lblIdiomaI.TabIndex = 23;
            this.lblIdiomaI.Text = "Idioma: ";
            // 
            // lblSegundoColor
            // 
            this.lblSegundoColor.AutoSize = true;
            this.lblSegundoColor.Location = new System.Drawing.Point(6, 143);
            this.lblSegundoColor.Name = "lblSegundoColor";
            this.lblSegundoColor.Size = new System.Drawing.Size(82, 13);
            this.lblSegundoColor.TabIndex = 24;
            this.lblSegundoColor.Text = "Segundo color: ";
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
            // lblTercerColor
            // 
            this.lblTercerColor.AutoSize = true;
            this.lblTercerColor.Location = new System.Drawing.Point(6, 169);
            this.lblTercerColor.Name = "lblTercerColor";
            this.lblTercerColor.Size = new System.Drawing.Size(70, 13);
            this.lblTercerColor.TabIndex = 26;
            this.lblTercerColor.Text = "Tercer color: ";
            // 
            // gpbDocumento
            // 
            this.gpbDocumento.Controls.Add(this.lblNombrePais);
            this.gpbDocumento.Controls.Add(this.lblTercerColor);
            this.gpbDocumento.Controls.Add(this.lblTotalPoblacion);
            this.gpbDocumento.Controls.Add(this.lblPrimerColor);
            this.gpbDocumento.Controls.Add(this.lblIdiomaI);
            this.gpbDocumento.Controls.Add(this.lblSegundoColor);
            this.gpbDocumento.Location = new System.Drawing.Point(290, 12);
            this.gpbDocumento.Name = "gpbDocumento";
            this.gpbDocumento.Size = new System.Drawing.Size(200, 198);
            this.gpbDocumento.TabIndex = 27;
            this.gpbDocumento.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 225);
            this.Controls.Add(this.gpbDocumento);
            this.Controls.Add(this.toolStrip1);
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
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Datos de Paises ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpbDocumento.ResumeLayout(false);
            this.gpbDocumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblColoresBandera;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.Label lblColor3;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardarImprimir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTercerColor;
        private System.Windows.Forms.Label lblPrimerColor;
        private System.Windows.Forms.Label lblSegundoColor;
        private System.Windows.Forms.Label lblIdiomaI;
        private System.Windows.Forms.Label lblTotalPoblacion;
        private System.Windows.Forms.Label lblNombrePais;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.GroupBox gpbDocumento;
    }
}

