namespace DatosPersonas
{
    partial class frmInforme
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
            this.lblPersonasRegistradas = new System.Windows.Forms.Label();
            this.txtAlumnos = new System.Windows.Forms.TextBox();
            this.lblMayoresEdad = new System.Windows.Forms.Label();
            this.lblPersonasNay = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtPersonasNay = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMaestros = new System.Windows.Forms.Label();
            this.lblAdministrativos = new System.Windows.Forms.Label();
            this.txtMaestros = new System.Windows.Forms.TextBox();
            this.txtAdministrativos = new System.Windows.Forms.TextBox();
            this.txtMayorEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPersonasRegistradas
            // 
            this.lblPersonasRegistradas.AutoSize = true;
            this.lblPersonasRegistradas.Location = new System.Drawing.Point(59, 137);
            this.lblPersonasRegistradas.Name = "lblPersonasRegistradas";
            this.lblPersonasRegistradas.Size = new System.Drawing.Size(50, 13);
            this.lblPersonasRegistradas.TabIndex = 0;
            this.lblPersonasRegistradas.Text = "Alumnos:";
            this.lblPersonasRegistradas.Click += new System.EventHandler(this.lblPersonasRegistradas_Click);
            // 
            // txtAlumnos
            // 
            this.txtAlumnos.Location = new System.Drawing.Point(134, 134);
            this.txtAlumnos.Name = "txtAlumnos";
            this.txtAlumnos.Size = new System.Drawing.Size(100, 20);
            this.txtAlumnos.TabIndex = 1;
            // 
            // lblMayoresEdad
            // 
            this.lblMayoresEdad.AutoSize = true;
            this.lblMayoresEdad.Location = new System.Drawing.Point(35, 29);
            this.lblMayoresEdad.Name = "lblMayoresEdad";
            this.lblMayoresEdad.Size = new System.Drawing.Size(93, 13);
            this.lblMayoresEdad.TabIndex = 2;
            this.lblMayoresEdad.Text = "Mayores de Edad:";
            // 
            // lblPersonasNay
            // 
            this.lblPersonasNay.AutoSize = true;
            this.lblPersonasNay.Location = new System.Drawing.Point(23, 66);
            this.lblPersonasNay.Name = "lblPersonasNay";
            this.lblPersonasNay.Size = new System.Drawing.Size(105, 13);
            this.lblPersonasNay.TabIndex = 3;
            this.lblPersonasNay.Text = "Personas de Nayarit:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(231, 242);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtPersonasNay
            // 
            this.txtPersonasNay.Location = new System.Drawing.Point(134, 59);
            this.txtPersonasNay.Name = "txtPersonasNay";
            this.txtPersonasNay.Size = new System.Drawing.Size(100, 20);
            this.txtPersonasNay.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(59, 103);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblMaestros
            // 
            this.lblMaestros.AutoSize = true;
            this.lblMaestros.Location = new System.Drawing.Point(62, 169);
            this.lblMaestros.Name = "lblMaestros";
            this.lblMaestros.Size = new System.Drawing.Size(53, 13);
            this.lblMaestros.TabIndex = 8;
            this.lblMaestros.Text = "Maestros:";
            // 
            // lblAdministrativos
            // 
            this.lblAdministrativos.AutoSize = true;
            this.lblAdministrativos.Location = new System.Drawing.Point(35, 200);
            this.lblAdministrativos.Name = "lblAdministrativos";
            this.lblAdministrativos.Size = new System.Drawing.Size(80, 13);
            this.lblAdministrativos.TabIndex = 9;
            this.lblAdministrativos.Text = "Administrativos:";
            // 
            // txtMaestros
            // 
            this.txtMaestros.Location = new System.Drawing.Point(134, 166);
            this.txtMaestros.Name = "txtMaestros";
            this.txtMaestros.Size = new System.Drawing.Size(100, 20);
            this.txtMaestros.TabIndex = 10;
            // 
            // txtAdministrativos
            // 
            this.txtAdministrativos.Location = new System.Drawing.Point(134, 200);
            this.txtAdministrativos.Name = "txtAdministrativos";
            this.txtAdministrativos.Size = new System.Drawing.Size(100, 20);
            this.txtAdministrativos.TabIndex = 11;
            // 
            // txtMayorEdad
            // 
            this.txtMayorEdad.Location = new System.Drawing.Point(134, 26);
            this.txtMayorEdad.Name = "txtMayorEdad";
            this.txtMayorEdad.Size = new System.Drawing.Size(100, 20);
            this.txtMayorEdad.TabIndex = 5;
            this.txtMayorEdad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // frmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 277);
            this.Controls.Add(this.txtAdministrativos);
            this.Controls.Add(this.txtMaestros);
            this.Controls.Add(this.lblAdministrativos);
            this.Controls.Add(this.lblMaestros);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtPersonasNay);
            this.Controls.Add(this.txtMayorEdad);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblPersonasNay);
            this.Controls.Add(this.lblMayoresEdad);
            this.Controls.Add(this.txtAlumnos);
            this.Controls.Add(this.lblPersonasRegistradas);
            this.Name = "frmInforme";
            this.Text = "frmInforme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonasRegistradas;
        private System.Windows.Forms.Label lblMayoresEdad;
        private System.Windows.Forms.Label lblPersonasNay;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMaestros;
        private System.Windows.Forms.Label lblAdministrativos;
        public System.Windows.Forms.TextBox txtMayorEdad;
        public System.Windows.Forms.TextBox txtAlumnos;
        public System.Windows.Forms.TextBox txtPersonasNay;
        public System.Windows.Forms.TextBox txtMaestros;
        public System.Windows.Forms.TextBox txtAdministrativos;
    }
}