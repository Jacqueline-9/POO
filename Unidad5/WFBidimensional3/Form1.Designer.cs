namespace WFBidimensional3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.blColumnas = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.lblFilas = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblPares = new System.Windows.Forms.Label();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.blColumnas);
            this.groupBox1.Controls.Add(this.txtColumnas);
            this.groupBox1.Controls.Add(this.txtFilas);
            this.groupBox1.Controls.Add(this.lblFilas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(104, 100);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(6, 100);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // blColumnas
            // 
            this.blColumnas.AutoSize = true;
            this.blColumnas.Location = new System.Drawing.Point(17, 64);
            this.blColumnas.Name = "blColumnas";
            this.blColumnas.Size = new System.Drawing.Size(56, 13);
            this.blColumnas.TabIndex = 1;
            this.blColumnas.Text = "Columnas:";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(79, 61);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 20);
            this.txtColumnas.TabIndex = 3;
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(57, 28);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(122, 20);
            this.txtFilas.TabIndex = 2;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(17, 31);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(34, 13);
            this.lblFilas.TabIndex = 0;
            this.lblFilas.Text = "Filas: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(301, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(382, 176);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.btnPar);
            this.groupBox2.Controls.Add(this.lblBuscar);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.lblPares);
            this.groupBox2.Location = new System.Drawing.Point(229, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 148);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(138, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(20, 59);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 4;
            this.btnPar.Text = "Par";
            this.btnPar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(23, 110);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(113, 61);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblPares
            // 
            this.lblPares.AutoSize = true;
            this.lblPares.Location = new System.Drawing.Point(17, 31);
            this.lblPares.Name = "lblPares";
            this.lblPares.Size = new System.Drawing.Size(84, 13);
            this.lblPares.TabIndex = 0;
            this.lblPares.Text = "Números pares: ";
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Location = new System.Drawing.Point(216, 176);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(79, 23);
            this.btnOperaciones.TabIndex = 6;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 211);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arreglos Bidimensionales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label blColumnas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblPares;
        private System.Windows.Forms.Button btnOperaciones;
    }
}

