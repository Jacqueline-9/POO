namespace InterfacesEjercicio1
{
    partial class Informe
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
            this.lblCerveza = new System.Windows.Forms.Label();
            this.lblVinos = new System.Windows.Forms.Label();
            this.txtCervezas = new System.Windows.Forms.TextBox();
            this.txtVinos = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCerveza
            // 
            this.lblCerveza.AutoSize = true;
            this.lblCerveza.Location = new System.Drawing.Point(22, 34);
            this.lblCerveza.Name = "lblCerveza";
            this.lblCerveza.Size = new System.Drawing.Size(57, 13);
            this.lblCerveza.TabIndex = 0;
            this.lblCerveza.Text = "Cervezas: ";
            // 
            // lblVinos
            // 
            this.lblVinos.AutoSize = true;
            this.lblVinos.Location = new System.Drawing.Point(35, 67);
            this.lblVinos.Name = "lblVinos";
            this.lblVinos.Size = new System.Drawing.Size(36, 13);
            this.lblVinos.TabIndex = 1;
            this.lblVinos.Text = "Vinos:";
            // 
            // txtCervezas
            // 
            this.txtCervezas.Location = new System.Drawing.Point(85, 31);
            this.txtCervezas.Name = "txtCervezas";
            this.txtCervezas.Size = new System.Drawing.Size(100, 20);
            this.txtCervezas.TabIndex = 2;
            // 
            // txtVinos
            // 
            this.txtVinos.Location = new System.Drawing.Point(85, 60);
            this.txtVinos.Name = "txtVinos";
            this.txtVinos.Size = new System.Drawing.Size(100, 20);
            this.txtVinos.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "El total de:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(147, 86);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 120);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtVinos);
            this.Controls.Add(this.txtCervezas);
            this.Controls.Add(this.lblVinos);
            this.Controls.Add(this.lblCerveza);
            this.Name = "Informe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCerveza;
        private System.Windows.Forms.Label lblVinos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.TextBox txtCervezas;
        public System.Windows.Forms.TextBox txtVinos;
    }
}