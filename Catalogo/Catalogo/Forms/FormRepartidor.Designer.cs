namespace EmpleadosRestaurante
{
    partial class FormRepartidor
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblFechaN = new System.Windows.Forms.Label();
            this.dtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZonaR = new System.Windows.Forms.ComboBox();
            this.lblAbonosC = new System.Windows.Forms.Label();
            this.txtAbonosC = new System.Windows.Forms.TextBox();
            this.txtDiasT = new System.Windows.Forms.TextBox();
            this.lblDíasT = new System.Windows.Forms.Label();
            this.lblPropinaS = new System.Windows.Forms.Label();
            this.txtPropinaS = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(246, 149);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(246, 95);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 36);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular Sueldo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(128, 95);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 21;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(79, 98);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(43, 13);
            this.lblSueldo.TabIndex = 20;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // lblFechaN
            // 
            this.lblFechaN.AutoSize = true;
            this.lblFechaN.Location = new System.Drawing.Point(11, 38);
            this.lblFechaN.Name = "lblFechaN";
            this.lblFechaN.Size = new System.Drawing.Size(111, 13);
            this.lblFechaN.TabIndex = 19;
            this.lblFechaN.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaN
            // 
            this.dtpFechaN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaN.Location = new System.Drawing.Point(129, 38);
            this.dtpFechaN.Name = "dtpFechaN";
            this.dtpFechaN.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaN.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Zona de Repartcición:";
            // 
            // cmbZonaR
            // 
            this.cmbZonaR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZonaR.FormattingEnabled = true;
            this.cmbZonaR.Location = new System.Drawing.Point(128, 149);
            this.cmbZonaR.Name = "cmbZonaR";
            this.cmbZonaR.Size = new System.Drawing.Size(100, 21);
            this.cmbZonaR.TabIndex = 27;
            // 
            // lblAbonosC
            // 
            this.lblAbonosC.AutoSize = true;
            this.lblAbonosC.Location = new System.Drawing.Point(28, 179);
            this.lblAbonosC.Name = "lblAbonosC";
            this.lblAbonosC.Size = new System.Drawing.Size(94, 13);
            this.lblAbonosC.TabIndex = 28;
            this.lblAbonosC.Text = "Abonos Cobrados:";
            // 
            // txtAbonosC
            // 
            this.txtAbonosC.Location = new System.Drawing.Point(128, 176);
            this.txtAbonosC.Name = "txtAbonosC";
            this.txtAbonosC.Size = new System.Drawing.Size(100, 20);
            this.txtAbonosC.TabIndex = 29;
            // 
            // txtDiasT
            // 
            this.txtDiasT.Location = new System.Drawing.Point(128, 64);
            this.txtDiasT.Name = "txtDiasT";
            this.txtDiasT.Size = new System.Drawing.Size(100, 20);
            this.txtDiasT.TabIndex = 31;
            // 
            // lblDíasT
            // 
            this.lblDíasT.AutoSize = true;
            this.lblDíasT.Location = new System.Drawing.Point(30, 67);
            this.lblDíasT.Name = "lblDíasT";
            this.lblDíasT.Size = new System.Drawing.Size(92, 13);
            this.lblDíasT.TabIndex = 30;
            this.lblDíasT.Text = "Días Trabajados: ";
            // 
            // lblPropinaS
            // 
            this.lblPropinaS.AutoSize = true;
            this.lblPropinaS.Location = new System.Drawing.Point(32, 126);
            this.lblPropinaS.Name = "lblPropinaS";
            this.lblPropinaS.Size = new System.Drawing.Size(90, 13);
            this.lblPropinaS.TabIndex = 22;
            this.lblPropinaS.Text = "Propina Semanal:";
            // 
            // txtPropinaS
            // 
            this.txtPropinaS.Location = new System.Drawing.Point(128, 123);
            this.txtPropinaS.Name = "txtPropinaS";
            this.txtPropinaS.Size = new System.Drawing.Size(100, 20);
            this.txtPropinaS.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 208);
            this.Controls.Add(this.txtDiasT);
            this.Controls.Add(this.lblDíasT);
            this.Controls.Add(this.txtAbonosC);
            this.Controls.Add(this.lblAbonosC);
            this.Controls.Add(this.cmbZonaR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPropinaS);
            this.Controls.Add(this.lblPropinaS);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblFechaN);
            this.Controls.Add(this.dtpFechaN);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormRepartidor";
            this.Text = "Repartidor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblFechaN;
        private System.Windows.Forms.DateTimePicker dtpFechaN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZonaR;
        private System.Windows.Forms.Label lblAbonosC;
        private System.Windows.Forms.TextBox txtAbonosC;
        private System.Windows.Forms.TextBox txtDiasT;
        private System.Windows.Forms.Label lblDíasT;
        private System.Windows.Forms.Label lblPropinaS;
        private System.Windows.Forms.TextBox txtPropinaS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}