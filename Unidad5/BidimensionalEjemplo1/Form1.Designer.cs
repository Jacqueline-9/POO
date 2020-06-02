namespace BidimensionalEjemplo1
{
    partial class Form1
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
            this.nudFilas = new System.Windows.Forms.NumericUpDown();
            this.lblFilas = new System.Windows.Forms.Label();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.nudColumnas = new System.Windows.Forms.NumericUpDown();
            this.rtbimprimir = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFilas
            // 
            this.nudFilas.Location = new System.Drawing.Point(68, 11);
            this.nudFilas.Name = "nudFilas";
            this.nudFilas.Size = new System.Drawing.Size(120, 20);
            this.nudFilas.TabIndex = 0;
            this.nudFilas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(12, 18);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(28, 13);
            this.lblFilas.TabIndex = 1;
            this.lblFilas.Text = "Filas";
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(12, 44);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(53, 13);
            this.lblColumnas.TabIndex = 2;
            this.lblColumnas.Text = "Columnas";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(26, 112);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(81, 69);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 5;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // nudColumnas
            // 
            this.nudColumnas.Location = new System.Drawing.Point(68, 42);
            this.nudColumnas.Name = "nudColumnas";
            this.nudColumnas.Size = new System.Drawing.Size(120, 20);
            this.nudColumnas.TabIndex = 6;
            this.nudColumnas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtbimprimir
            // 
            this.rtbimprimir.Location = new System.Drawing.Point(15, 141);
            this.rtbimprimir.Name = "rtbimprimir";
            this.rtbimprimir.Size = new System.Drawing.Size(100, 96);
            this.rtbimprimir.TabIndex = 7;
            this.rtbimprimir.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(109, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 272);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rtbimprimir);
            this.Controls.Add(this.nudColumnas);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblColumnas);
            this.Controls.Add(this.lblFilas);
            this.Controls.Add(this.nudFilas);
            this.Name = "Form1";
            this.Text = "Ejemplo Arreglo";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFilas;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.NumericUpDown nudColumnas;
        private System.Windows.Forms.RichTextBox rtbimprimir;
        private System.Windows.Forms.Button btnSalir;
    }
}

