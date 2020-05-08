namespace FilasColumnasDiagonal
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilas = new System.Windows.Forms.Label();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblSumaColumnas = new System.Windows.Forms.Label();
            this.lblSumaFilas = new System.Windows.Forms.Label();
            this.lblSumaDiagonal = new System.Windows.Forms.Label();
            this.btnImprimirSuma = new System.Windows.Forms.Button();
            this.rtbMatriz = new System.Windows.Forms.RichTextBox();
            this.lblSumasColumnas = new System.Windows.Forms.Label();
            this.lblSumasFilas = new System.Windows.Forms.Label();
            this.lblDiagonalSuma = new System.Windows.Forms.Label();
            this.lblDiagonal = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 22);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(147, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad de filas y columnas: ";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(165, 20);
            this.nudCantidad.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 1;
            this.nudCantidad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(214, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(211, 46);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(107, 80);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(28, 13);
            this.lblFilas.TabIndex = 5;
            this.lblFilas.Text = "Filas";
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(13, 127);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(53, 13);
            this.lblColumnas.TabIndex = 6;
            this.lblColumnas.Text = "Columnas";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(181, 246);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(108, 23);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir Datos";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblSumaColumnas
            // 
            this.lblSumaColumnas.AutoSize = true;
            this.lblSumaColumnas.Location = new System.Drawing.Point(176, 80);
            this.lblSumaColumnas.Name = "lblSumaColumnas";
            this.lblSumaColumnas.Size = new System.Drawing.Size(104, 13);
            this.lblSumaColumnas.TabIndex = 9;
            this.lblSumaColumnas.Text = "Suma de Columnas: ";
            // 
            // lblSumaFilas
            // 
            this.lblSumaFilas.AutoSize = true;
            this.lblSumaFilas.Location = new System.Drawing.Point(6, 195);
            this.lblSumaFilas.Name = "lblSumaFilas";
            this.lblSumaFilas.Size = new System.Drawing.Size(64, 13);
            this.lblSumaFilas.TabIndex = 10;
            this.lblSumaFilas.Text = "Suma Filas: ";
            // 
            // lblSumaDiagonal
            // 
            this.lblSumaDiagonal.AutoSize = true;
            this.lblSumaDiagonal.Location = new System.Drawing.Point(6, 231);
            this.lblSumaDiagonal.Name = "lblSumaDiagonal";
            this.lblSumaDiagonal.Size = new System.Drawing.Size(85, 13);
            this.lblSumaDiagonal.TabIndex = 11;
            this.lblSumaDiagonal.Text = "Suma Diagonal: ";
            // 
            // btnImprimirSuma
            // 
            this.btnImprimirSuma.Enabled = false;
            this.btnImprimirSuma.Location = new System.Drawing.Point(179, 275);
            this.btnImprimirSuma.Name = "btnImprimirSuma";
            this.btnImprimirSuma.Size = new System.Drawing.Size(110, 23);
            this.btnImprimirSuma.TabIndex = 12;
            this.btnImprimirSuma.Text = "Imprimir sumas";
            this.btnImprimirSuma.UseVisualStyleBackColor = true;
            this.btnImprimirSuma.Click += new System.EventHandler(this.btnImprimirSuma_Click);
            // 
            // rtbMatriz
            // 
            this.rtbMatriz.Enabled = false;
            this.rtbMatriz.Location = new System.Drawing.Point(72, 96);
            this.rtbMatriz.Name = "rtbMatriz";
            this.rtbMatriz.Size = new System.Drawing.Size(100, 96);
            this.rtbMatriz.TabIndex = 13;
            this.rtbMatriz.Text = "";
            // 
            // lblSumasColumnas
            // 
            this.lblSumasColumnas.AutoSize = true;
            this.lblSumasColumnas.Location = new System.Drawing.Point(178, 99);
            this.lblSumasColumnas.Name = "lblSumasColumnas";
            this.lblSumasColumnas.Size = new System.Drawing.Size(0, 13);
            this.lblSumasColumnas.TabIndex = 14;
            // 
            // lblSumasFilas
            // 
            this.lblSumasFilas.AutoSize = true;
            this.lblSumasFilas.Location = new System.Drawing.Point(72, 195);
            this.lblSumasFilas.Name = "lblSumasFilas";
            this.lblSumasFilas.Size = new System.Drawing.Size(0, 13);
            this.lblSumasFilas.TabIndex = 15;
            // 
            // lblDiagonalSuma
            // 
            this.lblDiagonalSuma.AutoSize = true;
            this.lblDiagonalSuma.Location = new System.Drawing.Point(97, 231);
            this.lblDiagonalSuma.Name = "lblDiagonalSuma";
            this.lblDiagonalSuma.Size = new System.Drawing.Size(0, 13);
            this.lblDiagonalSuma.TabIndex = 16;
            // 
            // lblDiagonal
            // 
            this.lblDiagonal.AutoSize = true;
            this.lblDiagonal.Location = new System.Drawing.Point(23, 80);
            this.lblDiagonal.Name = "lblDiagonal";
            this.lblDiagonal.Size = new System.Drawing.Size(49, 13);
            this.lblDiagonal.TabIndex = 17;
            this.lblDiagonal.Text = "Diagonal";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(9, 310);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 345);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblDiagonal);
            this.Controls.Add(this.lblDiagonalSuma);
            this.Controls.Add(this.lblSumasFilas);
            this.Controls.Add(this.lblSumasColumnas);
            this.Controls.Add(this.rtbMatriz);
            this.Controls.Add(this.btnImprimirSuma);
            this.Controls.Add(this.lblSumaDiagonal);
            this.Controls.Add(this.lblSumaFilas);
            this.Controls.Add(this.lblSumaColumnas);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblColumnas);
            this.Controls.Add(this.lblFilas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblSumaColumnas;
        private System.Windows.Forms.Label lblSumaFilas;
        private System.Windows.Forms.Label lblSumaDiagonal;
        private System.Windows.Forms.Button btnImprimirSuma;
        private System.Windows.Forms.RichTextBox rtbMatriz;
        private System.Windows.Forms.Label lblSumasColumnas;
        private System.Windows.Forms.Label lblSumasFilas;
        private System.Windows.Forms.Label lblDiagonalSuma;
        private System.Windows.Forms.Label lblDiagonal;
        private System.Windows.Forms.Button btnNuevo;
    }
}

