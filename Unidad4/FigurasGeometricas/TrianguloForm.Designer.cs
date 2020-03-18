namespace FigurasGeometricas
{
    partial class TrianguloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrianguloForm));
            this.lblRegresar = new System.Windows.Forms.Button();
            this.txtPerimetroT = new System.Windows.Forms.TextBox();
            this.txtAreaT = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblLadoT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegresar
            // 
            this.lblRegresar.Location = new System.Drawing.Point(99, 84);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(75, 23);
            this.lblRegresar.TabIndex = 33;
            this.lblRegresar.Text = "Regresar";
            this.lblRegresar.UseVisualStyleBackColor = true;
            this.lblRegresar.Click += new System.EventHandler(this.lblRegresar_Click);
            // 
            // txtPerimetroT
            // 
            this.txtPerimetroT.Location = new System.Drawing.Point(74, 58);
            this.txtPerimetroT.Name = "txtPerimetroT";
            this.txtPerimetroT.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetroT.TabIndex = 32;
            // 
            // txtAreaT
            // 
            this.txtAreaT.Location = new System.Drawing.Point(50, 33);
            this.txtAreaT.Name = "txtAreaT";
            this.txtAreaT.Size = new System.Drawing.Size(100, 20);
            this.txtAreaT.TabIndex = 31;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(12, 65);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(56, 13);
            this.lblPerimetro.TabIndex = 30;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 36);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 29;
            this.lblArea.Text = "Área:";
            // 
            // lblLadoT
            // 
            this.lblLadoT.AutoSize = true;
            this.lblLadoT.Location = new System.Drawing.Point(12, 9);
            this.lblLadoT.Name = "lblLadoT";
            this.lblLadoT.Size = new System.Drawing.Size(34, 13);
            this.lblLadoT.TabIndex = 36;
            this.lblLadoT.Text = "Lado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // TrianguloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 114);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLadoT);
            this.Controls.Add(this.lblRegresar);
            this.Controls.Add(this.txtPerimetroT);
            this.Controls.Add(this.txtAreaT);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Name = "TrianguloForm";
            this.Text = "Triangulo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button lblRegresar;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        public System.Windows.Forms.Label lblLadoT;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtPerimetroT;
        public System.Windows.Forms.TextBox txtAreaT;
    }
}