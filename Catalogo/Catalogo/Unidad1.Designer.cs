namespace Catalogo
{
    partial class Unidad1
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
            this.btnConsola = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.lblUnidad1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsola
            // 
            this.btnConsola.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnConsola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsola.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsola.Location = new System.Drawing.Point(130, 161);
            this.btnConsola.Name = "btnConsola";
            this.btnConsola.Size = new System.Drawing.Size(169, 32);
            this.btnConsola.TabIndex = 0;
            this.btnConsola.Text = "Primer Proyecto en consola";
            this.btnConsola.UseVisualStyleBackColor = true;
            this.btnConsola.Click += new System.EventHandler(this.btnConsola_Click);
            // 
            // btnForm
            // 
            this.btnForm.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnForm.Location = new System.Drawing.Point(517, 161);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(169, 32);
            this.btnForm.TabIndex = 2;
            this.btnForm.Text = "Primer Proyecto en Form";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click_1);
            // 
            // lblUnidad1
            // 
            this.lblUnidad1.AutoSize = true;
            this.lblUnidad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUnidad1.Location = new System.Drawing.Point(272, 33);
            this.lblUnidad1.Name = "lblUnidad1";
            this.lblUnidad1.Size = new System.Drawing.Size(297, 73);
            this.lblUnidad1.TabIndex = 3;
            this.lblUnidad1.Text = "Unidad 1";
            // 
            // Unidad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(842, 575);
            this.Controls.Add(this.lblUnidad1);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.btnConsola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unidad1";
            this.Text = "Unidad1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsola;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Label lblUnidad1;
    }
}