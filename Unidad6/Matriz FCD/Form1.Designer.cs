namespace Matriz_FCD
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblDiagonal = new System.Windows.Forms.Label();
            this.lblDiagonalSuma = new System.Windows.Forms.Label();
            this.lblSumasFilas = new System.Windows.Forms.Label();
            this.lblSumasColumnas = new System.Windows.Forms.Label();
            this.rtbMatriz = new System.Windows.Forms.RichTextBox();
            this.btnImprimirSuma = new System.Windows.Forms.Button();
            this.lblSumaDiagonal = new System.Windows.Forms.Label();
            this.lblSumaFilas = new System.Windows.Forms.Label();
            this.lblSumaColumnas = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.lblFilas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(19, 308);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 54;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblDiagonal
            // 
            this.lblDiagonal.AutoSize = true;
            this.lblDiagonal.Location = new System.Drawing.Point(33, 78);
            this.lblDiagonal.Name = "lblDiagonal";
            this.lblDiagonal.Size = new System.Drawing.Size(49, 13);
            this.lblDiagonal.TabIndex = 53;
            this.lblDiagonal.Text = "Diagonal";
            // 
            // lblDiagonalSuma
            // 
            this.lblDiagonalSuma.AutoSize = true;
            this.lblDiagonalSuma.Location = new System.Drawing.Point(107, 229);
            this.lblDiagonalSuma.Name = "lblDiagonalSuma";
            this.lblDiagonalSuma.Size = new System.Drawing.Size(0, 13);
            this.lblDiagonalSuma.TabIndex = 52;
            // 
            // lblSumasFilas
            // 
            this.lblSumasFilas.AutoSize = true;
            this.lblSumasFilas.Location = new System.Drawing.Point(82, 193);
            this.lblSumasFilas.Name = "lblSumasFilas";
            this.lblSumasFilas.Size = new System.Drawing.Size(0, 13);
            this.lblSumasFilas.TabIndex = 51;
            // 
            // lblSumasColumnas
            // 
            this.lblSumasColumnas.AutoSize = true;
            this.lblSumasColumnas.Location = new System.Drawing.Point(188, 97);
            this.lblSumasColumnas.Name = "lblSumasColumnas";
            this.lblSumasColumnas.Size = new System.Drawing.Size(0, 13);
            this.lblSumasColumnas.TabIndex = 50;
            // 
            // rtbMatriz
            // 
            this.rtbMatriz.Enabled = false;
            this.rtbMatriz.Location = new System.Drawing.Point(82, 94);
            this.rtbMatriz.Name = "rtbMatriz";
            this.rtbMatriz.Size = new System.Drawing.Size(100, 96);
            this.rtbMatriz.TabIndex = 49;
            this.rtbMatriz.Text = "";
            // 
            // btnImprimirSuma
            // 
            this.btnImprimirSuma.Enabled = false;
            this.btnImprimirSuma.Location = new System.Drawing.Point(189, 273);
            this.btnImprimirSuma.Name = "btnImprimirSuma";
            this.btnImprimirSuma.Size = new System.Drawing.Size(110, 23);
            this.btnImprimirSuma.TabIndex = 48;
            this.btnImprimirSuma.Text = "Imprimir sumas";
            this.btnImprimirSuma.UseVisualStyleBackColor = true;
            this.btnImprimirSuma.Click += new System.EventHandler(this.btnImprimirSuma_Click);
            // 
            // lblSumaDiagonal
            // 
            this.lblSumaDiagonal.AutoSize = true;
            this.lblSumaDiagonal.Location = new System.Drawing.Point(16, 229);
            this.lblSumaDiagonal.Name = "lblSumaDiagonal";
            this.lblSumaDiagonal.Size = new System.Drawing.Size(85, 13);
            this.lblSumaDiagonal.TabIndex = 47;
            this.lblSumaDiagonal.Text = "Suma Diagonal: ";
            // 
            // lblSumaFilas
            // 
            this.lblSumaFilas.AutoSize = true;
            this.lblSumaFilas.Location = new System.Drawing.Point(16, 193);
            this.lblSumaFilas.Name = "lblSumaFilas";
            this.lblSumaFilas.Size = new System.Drawing.Size(64, 13);
            this.lblSumaFilas.TabIndex = 46;
            this.lblSumaFilas.Text = "Suma Filas: ";
            // 
            // lblSumaColumnas
            // 
            this.lblSumaColumnas.AutoSize = true;
            this.lblSumaColumnas.Location = new System.Drawing.Point(186, 78);
            this.lblSumaColumnas.Name = "lblSumaColumnas";
            this.lblSumaColumnas.Size = new System.Drawing.Size(104, 13);
            this.lblSumaColumnas.TabIndex = 45;
            this.lblSumaColumnas.Text = "Suma de Columnas: ";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(191, 244);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(108, 23);
            this.btnImprimir.TabIndex = 44;
            this.btnImprimir.Text = "Imprimir Datos";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(23, 125);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(53, 13);
            this.lblColumnas.TabIndex = 43;
            this.lblColumnas.Text = "Columnas";
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(117, 78);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(28, 13);
            this.lblFilas.TabIndex = 42;
            this.lblFilas.Text = "Filas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 41;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(221, 44);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 40;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(224, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(175, 18);
            this.nudCantidad.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 38;
            this.nudCantidad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(22, 20);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(147, 13);
            this.lblCantidad.TabIndex = 37;
            this.lblCantidad.Text = "Cantidad de filas y columnas: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 340);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblDiagonal;
        private System.Windows.Forms.Label lblDiagonalSuma;
        private System.Windows.Forms.Label lblSumasFilas;
        private System.Windows.Forms.Label lblSumasColumnas;
        private System.Windows.Forms.RichTextBox rtbMatriz;
        private System.Windows.Forms.Button btnImprimirSuma;
        private System.Windows.Forms.Label lblSumaDiagonal;
        private System.Windows.Forms.Label lblSumaFilas;
        private System.Windows.Forms.Label lblSumaColumnas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}

