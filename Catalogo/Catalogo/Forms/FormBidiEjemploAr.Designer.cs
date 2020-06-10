namespace BidimensionalEjemplo1
{
    partial class FormBidiEjemploAr
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.rtbimprimir = new System.Windows.Forms.RichTextBox();
            this.nudColumnas = new System.Windows.Forms.NumericUpDown();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.lblFilas = new System.Windows.Forms.Label();
            this.nudFilas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(104, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rtbimprimir
            // 
            this.rtbimprimir.Location = new System.Drawing.Point(10, 142);
            this.rtbimprimir.Name = "rtbimprimir";
            this.rtbimprimir.Size = new System.Drawing.Size(100, 96);
            this.rtbimprimir.TabIndex = 15;
            this.rtbimprimir.Text = "";
            // 
            // nudColumnas
            // 
            this.nudColumnas.Location = new System.Drawing.Point(63, 43);
            this.nudColumnas.Name = "nudColumnas";
            this.nudColumnas.Size = new System.Drawing.Size(120, 20);
            this.nudColumnas.TabIndex = 14;
            this.nudColumnas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(76, 70);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 13;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(21, 113);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(7, 45);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(53, 13);
            this.lblColumnas.TabIndex = 11;
            this.lblColumnas.Text = "Columnas";
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(7, 19);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(28, 13);
            this.lblFilas.TabIndex = 10;
            this.lblFilas.Text = "Filas";
            // 
            // nudFilas
            // 
            this.nudFilas.Location = new System.Drawing.Point(63, 12);
            this.nudFilas.Name = "nudFilas";
            this.nudFilas.Size = new System.Drawing.Size(120, 20);
            this.nudFilas.TabIndex = 9;
            this.nudFilas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 271);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rtbimprimir);
            this.Controls.Add(this.nudColumnas);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblColumnas);
            this.Controls.Add(this.lblFilas);
            this.Controls.Add(this.nudFilas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtbimprimir;
        private System.Windows.Forms.NumericUpDown nudColumnas;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.NumericUpDown nudFilas;
    }
}

