namespace FigurasGeometricas
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
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLadoo = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblLadoIz = new System.Windows.Forms.Label();
            this.txtLadoIz = new System.Windows.Forms.TextBox();
            this.lblLadoDe = new System.Windows.Forms.Label();
            this.txtLadoD = new System.Windows.Forms.TextBox();
            this.lblLados = new System.Windows.Forms.Label();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.btnSelec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Location = new System.Drawing.Point(64, 12);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 21);
            this.cmbFigura.TabIndex = 2;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigura.Location = new System.Drawing.Point(12, 13);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(46, 16);
            this.lblFigura.TabIndex = 3;
            this.lblFigura.Text = "Figura:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(207, 10);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 19;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(224, 134);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(15, 66);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(34, 13);
            this.lblLado.TabIndex = 20;
            this.lblLado.Text = "Lado:";
            this.lblLado.Visible = false;
            // 
            // txtLadoo
            // 
            this.txtLadoo.Location = new System.Drawing.Point(64, 63);
            this.txtLadoo.Name = "txtLadoo";
            this.txtLadoo.Size = new System.Drawing.Size(100, 20);
            this.txtLadoo.TabIndex = 21;
            this.txtLadoo.Visible = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 90);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 35;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Visible = false;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(64, 87);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 36;
            this.txtAltura.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(207, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 37;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Visible = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(64, 36);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 38;
            this.cmbTipo.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(18, 42);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 39;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Visible = false;
            // 
            // lblLadoIz
            // 
            this.lblLadoIz.AutoSize = true;
            this.lblLadoIz.Location = new System.Drawing.Point(10, 120);
            this.lblLadoIz.Name = "lblLadoIz";
            this.lblLadoIz.Size = new System.Drawing.Size(80, 13);
            this.lblLadoIz.TabIndex = 40;
            this.lblLadoIz.Text = "Lado Izquierdo:";
            this.lblLadoIz.Visible = false;
            // 
            // txtLadoIz
            // 
            this.txtLadoIz.Location = new System.Drawing.Point(99, 113);
            this.txtLadoIz.Name = "txtLadoIz";
            this.txtLadoIz.Size = new System.Drawing.Size(100, 20);
            this.txtLadoIz.TabIndex = 41;
            this.txtLadoIz.Visible = false;
            // 
            // lblLadoDe
            // 
            this.lblLadoDe.AutoSize = true;
            this.lblLadoDe.Location = new System.Drawing.Point(12, 142);
            this.lblLadoDe.Name = "lblLadoDe";
            this.lblLadoDe.Size = new System.Drawing.Size(78, 13);
            this.lblLadoDe.TabIndex = 42;
            this.lblLadoDe.Text = "Lado Derecho:";
            this.lblLadoDe.Visible = false;
            // 
            // txtLadoD
            // 
            this.txtLadoD.Location = new System.Drawing.Point(99, 139);
            this.txtLadoD.Name = "txtLadoD";
            this.txtLadoD.Size = new System.Drawing.Size(100, 20);
            this.txtLadoD.TabIndex = 43;
            this.txtLadoD.Visible = false;
            // 
            // lblLados
            // 
            this.lblLados.AutoSize = true;
            this.lblLados.Location = new System.Drawing.Point(170, 66);
            this.lblLados.Name = "lblLados";
            this.lblLados.Size = new System.Drawing.Size(39, 13);
            this.lblLados.TabIndex = 44;
            this.lblLados.Text = "Lados:";
            this.lblLados.Visible = false;
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(207, 63);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(83, 20);
            this.txtLados.TabIndex = 45;
            this.txtLados.Visible = false;
            // 
            // btnSelec
            // 
            this.btnSelec.Location = new System.Drawing.Point(207, 36);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(75, 23);
            this.btnSelec.TabIndex = 46;
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.UseVisualStyleBackColor = true;
            this.btnSelec.Visible = false;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 166);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.txtLados);
            this.Controls.Add(this.lblLados);
            this.Controls.Add(this.txtLadoD);
            this.Controls.Add(this.lblLadoDe);
            this.Controls.Add(this.txtLadoIz);
            this.Controls.Add(this.lblLadoIz);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtLadoo);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.cmbFigura);
            this.Name = "Form1";
            this.Text = "Figuras Geómetricas";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblLado;
        public System.Windows.Forms.TextBox txtLadoo;
        private System.Windows.Forms.Label lblAltura;
        public System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtLadoD;
        private System.Windows.Forms.Label lblLadoDe;
        private System.Windows.Forms.TextBox txtLadoIz;
        private System.Windows.Forms.Label lblLadoIz;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtLados;
        private System.Windows.Forms.Label lblLados;
        private System.Windows.Forms.Button btnSelec;
    }
}

