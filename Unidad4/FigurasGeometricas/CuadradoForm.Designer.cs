namespace FigurasGeometricas
{
    partial class CuadradoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuadradoForm));
            this.txtPerimetroC = new System.Windows.Forms.TextBox();
            this.txtAreaC = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRegresar = new System.Windows.Forms.Button();
            this.lblLadoCu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPerimetroC
            // 
            this.txtPerimetroC.Location = new System.Drawing.Point(67, 57);
            this.txtPerimetroC.Name = "txtPerimetroC";
            this.txtPerimetroC.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetroC.TabIndex = 27;
            // 
            // txtAreaC
            // 
            this.txtAreaC.Location = new System.Drawing.Point(50, 31);
            this.txtAreaC.Name = "txtAreaC";
            this.txtAreaC.Size = new System.Drawing.Size(100, 20);
            this.txtAreaC.TabIndex = 26;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(5, 60);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(56, 13);
            this.lblPerimetro.TabIndex = 25;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 34);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 24;
            this.lblArea.Text = "Área:";
            // 
            // lblRegresar
            // 
            this.lblRegresar.Location = new System.Drawing.Point(92, 83);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(75, 23);
            this.lblRegresar.TabIndex = 28;
            this.lblRegresar.Text = "Regresar";
            this.lblRegresar.UseVisualStyleBackColor = true;
            this.lblRegresar.Click += new System.EventHandler(this.lblRegresar_Click);
            // 
            // lblLadoCu
            // 
            this.lblLadoCu.AutoSize = true;
            this.lblLadoCu.Location = new System.Drawing.Point(26, 9);
            this.lblLadoCu.Name = "lblLadoCu";
            this.lblLadoCu.Size = new System.Drawing.Size(34, 13);
            this.lblLadoCu.TabIndex = 29;
            this.lblLadoCu.Text = "Lado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // CuadradoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 118);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLadoCu);
            this.Controls.Add(this.lblRegresar);
            this.Controls.Add(this.txtPerimetroC);
            this.Controls.Add(this.txtAreaC);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Name = "CuadradoForm";
            this.Text = "Cuadrado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button lblRegresar;
        public System.Windows.Forms.TextBox txtPerimetroC;
        public System.Windows.Forms.TextBox txtAreaC;
        private System.Windows.Forms.Label lblLadoCu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}