namespace EmpleadosRestaurante
{
    partial class FormMesero
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.lblFechaN = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblPropinaS = new System.Windows.Forms.Label();
            this.txtPropinaS = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtDiasT = new System.Windows.Forms.TextBox();
            this.lblDíasT = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // dtpFechaN
            // 
            this.dtpFechaN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaN.Location = new System.Drawing.Point(129, 46);
            this.dtpFechaN.Name = "dtpFechaN";
            this.dtpFechaN.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaN.TabIndex = 2;
            // 
            // lblFechaN
            // 
            this.lblFechaN.AutoSize = true;
            this.lblFechaN.Location = new System.Drawing.Point(12, 52);
            this.lblFechaN.Name = "lblFechaN";
            this.lblFechaN.Size = new System.Drawing.Size(111, 13);
            this.lblFechaN.TabIndex = 3;
            this.lblFechaN.Text = "Fecha de Nacimiento:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(80, 111);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(43, 13);
            this.lblSueldo.TabIndex = 4;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(130, 108);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 5;
            // 
            // lblPropinaS
            // 
            this.lblPropinaS.AutoSize = true;
            this.lblPropinaS.Location = new System.Drawing.Point(33, 137);
            this.lblPropinaS.Name = "lblPropinaS";
            this.lblPropinaS.Size = new System.Drawing.Size(90, 13);
            this.lblPropinaS.TabIndex = 6;
            this.lblPropinaS.Text = "Propina Semanal:";
            // 
            // txtPropinaS
            // 
            this.txtPropinaS.Location = new System.Drawing.Point(130, 134);
            this.txtPropinaS.Name = "txtPropinaS";
            this.txtPropinaS.Size = new System.Drawing.Size(100, 20);
            this.txtPropinaS.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(248, 80);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 38);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular Sueldo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(248, 134);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtDiasT
            // 
            this.txtDiasT.Location = new System.Drawing.Point(129, 80);
            this.txtDiasT.Name = "txtDiasT";
            this.txtDiasT.Size = new System.Drawing.Size(100, 20);
            this.txtDiasT.TabIndex = 20;
            // 
            // lblDíasT
            // 
            this.lblDíasT.AutoSize = true;
            this.lblDíasT.Location = new System.Drawing.Point(31, 83);
            this.lblDíasT.Name = "lblDíasT";
            this.lblDíasT.Size = new System.Drawing.Size(92, 13);
            this.lblDíasT.TabIndex = 19;
            this.lblDíasT.Text = "Días Trabajados: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 169);
            this.Controls.Add(this.txtDiasT);
            this.Controls.Add(this.lblDíasT);
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
            this.Name = "FormMesero";
            this.Text = "Mesero";
            this.Load += new System.EventHandler(this.FormMesero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaN;
        private System.Windows.Forms.Label lblFechaN;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblPropinaS;
        private System.Windows.Forms.TextBox txtPropinaS;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtDiasT;
        private System.Windows.Forms.Label lblDíasT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}