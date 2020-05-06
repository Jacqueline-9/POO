namespace WFBidimensional2
{
    partial class Operaciones
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDivision = new System.Windows.Forms.Button();
            this.bubtnMultip = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatosB = new System.Windows.Forms.Button();
            this.btnDatosA = new System.Windows.Forms.Button();
            this.btnTamMatriz = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(395, 164);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(290, 164);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDivision);
            this.groupBox2.Controls.Add(this.bubtnMultip);
            this.groupBox2.Controls.Add(this.btnResta);
            this.groupBox2.Controls.Add(this.btnSuma);
            this.groupBox2.Location = new System.Drawing.Point(100, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 55);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(295, 19);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "División";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click_1);
            // 
            // bubtnMultip
            // 
            this.bubtnMultip.Location = new System.Drawing.Point(190, 20);
            this.bubtnMultip.Name = "bubtnMultip";
            this.bubtnMultip.Size = new System.Drawing.Size(89, 23);
            this.bubtnMultip.TabIndex = 2;
            this.bubtnMultip.Text = "Multiplicación";
            this.bubtnMultip.UseVisualStyleBackColor = true;
            this.bubtnMultip.Click += new System.EventHandler(this.bubtnMultip_Click_1);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(100, 20);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click_1);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(7, 20);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click_1);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(352, 69);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 23;
            this.lblResultado.Text = "=";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(223, 69);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(17, 13);
            this.lblSuma.TabIndex = 22;
            this.lblSuma.Text = "\"\"";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(376, 66);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 21;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(246, 66);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 20;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(107, 66);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDatosB);
            this.groupBox1.Controls.Add(this.btnDatosA);
            this.groupBox1.Controls.Add(this.btnTamMatriz);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 151);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btnDatosB
            // 
            this.btnDatosB.Location = new System.Drawing.Point(6, 101);
            this.btnDatosB.Name = "btnDatosB";
            this.btnDatosB.Size = new System.Drawing.Size(75, 34);
            this.btnDatosB.TabIndex = 2;
            this.btnDatosB.Text = "Ingresar datos B";
            this.btnDatosB.UseVisualStyleBackColor = true;
            this.btnDatosB.Click += new System.EventHandler(this.btnDatosB_Click_1);
            // 
            // btnDatosA
            // 
            this.btnDatosA.Location = new System.Drawing.Point(6, 60);
            this.btnDatosA.Name = "btnDatosA";
            this.btnDatosA.Size = new System.Drawing.Size(75, 35);
            this.btnDatosA.TabIndex = 1;
            this.btnDatosA.Text = "Ingresar datos A";
            this.btnDatosA.UseVisualStyleBackColor = true;
            this.btnDatosA.Click += new System.EventHandler(this.btnDatosA_Click_1);
            // 
            // btnTamMatriz
            // 
            this.btnTamMatriz.Location = new System.Drawing.Point(6, 19);
            this.btnTamMatriz.Name = "btnTamMatriz";
            this.btnTamMatriz.Size = new System.Drawing.Size(75, 35);
            this.btnTamMatriz.TabIndex = 0;
            this.btnTamMatriz.Text = "Tamaño Matriz";
            this.btnTamMatriz.UseVisualStyleBackColor = true;
            this.btnTamMatriz.Click += new System.EventHandler(this.btnTamMatriz_Click_1);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 203);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.groupBox1);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button bubtnMultip;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatosB;
        private System.Windows.Forms.Button btnDatosA;
        private System.Windows.Forms.Button btnTamMatriz;
    }
}