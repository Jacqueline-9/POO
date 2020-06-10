namespace SnakeVersusJacque
{
    partial class Reglamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reglamento));
            this.lblReglas = new System.Windows.Forms.Label();
            this.lblRegla1 = new System.Windows.Forms.Label();
            this.lblRegla2 = new System.Windows.Forms.Label();
            this.lblRegla3 = new System.Windows.Forms.Label();
            this.lblTeclasDireccion = new System.Windows.Forms.Label();
            this.ptbTeclado = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTeclado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReglas
            // 
            this.lblReglas.AutoSize = true;
            this.lblReglas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReglas.Location = new System.Drawing.Point(12, 19);
            this.lblReglas.Name = "lblReglas";
            this.lblReglas.Size = new System.Drawing.Size(52, 14);
            this.lblReglas.TabIndex = 3;
            this.lblReglas.Text = "Reglas:";
            // 
            // lblRegla1
            // 
            this.lblRegla1.AutoSize = true;
            this.lblRegla1.Location = new System.Drawing.Point(12, 44);
            this.lblRegla1.Name = "lblRegla1";
            this.lblRegla1.Size = new System.Drawing.Size(159, 13);
            this.lblRegla1.TabIndex = 4;
            this.lblRegla1.Text = "1. No chocar contra las paredes";
            // 
            // lblRegla2
            // 
            this.lblRegla2.AutoSize = true;
            this.lblRegla2.Location = new System.Drawing.Point(12, 70);
            this.lblRegla2.Name = "lblRegla2";
            this.lblRegla2.Size = new System.Drawing.Size(144, 13);
            this.lblRegla2.TabIndex = 5;
            this.lblRegla2.Text = "2. No chocar contra si mismo";
            // 
            // lblRegla3
            // 
            this.lblRegla3.AutoSize = true;
            this.lblRegla3.Location = new System.Drawing.Point(12, 96);
            this.lblRegla3.Name = "lblRegla3";
            this.lblRegla3.Size = new System.Drawing.Size(158, 13);
            this.lblRegla3.TabIndex = 6;
            this.lblRegla3.Text = "3. Agarrar la comida para crecer";
            // 
            // lblTeclasDireccion
            // 
            this.lblTeclasDireccion.AutoSize = true;
            this.lblTeclasDireccion.Location = new System.Drawing.Point(12, 127);
            this.lblTeclasDireccion.Name = "lblTeclasDireccion";
            this.lblTeclasDireccion.Size = new System.Drawing.Size(182, 13);
            this.lblTeclasDireccion.TabIndex = 7;
            this.lblTeclasDireccion.Text = "Teclas Verdes = Teclas de Dirección";
            // 
            // ptbTeclado
            // 
            this.ptbTeclado.Image = ((System.Drawing.Image)(resources.GetObject("ptbTeclado.Image")));
            this.ptbTeclado.Location = new System.Drawing.Point(194, 3);
            this.ptbTeclado.Name = "ptbTeclado";
            this.ptbTeclado.Size = new System.Drawing.Size(363, 182);
            this.ptbTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTeclado.TabIndex = 8;
            this.ptbTeclado.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegresar.Location = new System.Drawing.Point(60, 162);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Reglamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(569, 197);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.ptbTeclado);
            this.Controls.Add(this.lblTeclasDireccion);
            this.Controls.Add(this.lblRegla3);
            this.Controls.Add(this.lblRegla2);
            this.Controls.Add(this.lblRegla1);
            this.Controls.Add(this.lblReglas);
            this.Name = "Reglamento";
            this.Text = "Reglamento";
            ((System.ComponentModel.ISupportInitialize)(this.ptbTeclado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReglas;
        private System.Windows.Forms.Label lblRegla1;
        private System.Windows.Forms.Label lblRegla2;
        private System.Windows.Forms.Label lblRegla3;
        private System.Windows.Forms.Label lblTeclasDireccion;
        private System.Windows.Forms.PictureBox ptbTeclado;
        private System.Windows.Forms.Button btnRegresar;
    }
}