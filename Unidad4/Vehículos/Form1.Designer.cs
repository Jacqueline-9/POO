namespace Vehículos
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
            this.components = new System.ComponentModel.Container();
            this.txtParar = new System.Windows.Forms.TextBox();
            this.lblPararMotor = new System.Windows.Forms.Label();
            this.lblSonido = new System.Windows.Forms.Label();
            this.txtSonido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.grbDatosAereo = new System.Windows.Forms.GroupBox();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtNumHelices = new System.Windows.Forms.TextBox();
            this.txtNumTurbinas = new System.Windows.Forms.TextBox();
            this.txtNumAlas = new System.Windows.Forms.TextBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblNumHelices = new System.Windows.Forms.Label();
            this.lblNumTurbinas = new System.Windows.Forms.Label();
            this.lblnumAlas = new System.Windows.Forms.Label();
            this.grbDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            this.txtTipoCombustible = new System.Windows.Forms.TextBox();
            this.lblNumeroLlantas = new System.Windows.Forms.Label();
            this.txtNumeroLlantas = new System.Windows.Forms.TextBox();
            this.txtNumeroVentanas = new System.Windows.Forms.TextBox();
            this.lblNumeroVentanas = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblArrancar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnArrancar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDatosAereo.SuspendLayout();
            this.grbDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParar
            // 
            this.txtParar.Location = new System.Drawing.Point(369, 112);
            this.txtParar.Name = "txtParar";
            this.txtParar.Size = new System.Drawing.Size(100, 20);
            this.txtParar.TabIndex = 41;
            // 
            // lblPararMotor
            // 
            this.lblPararMotor.AutoSize = true;
            this.lblPararMotor.Location = new System.Drawing.Point(380, 84);
            this.lblPararMotor.Name = "lblPararMotor";
            this.lblPararMotor.Size = new System.Drawing.Size(79, 13);
            this.lblPararMotor.TabIndex = 40;
            this.lblPararMotor.Text = "Sonido al Parar";
            // 
            // lblSonido
            // 
            this.lblSonido.AutoSize = true;
            this.lblSonido.Location = new System.Drawing.Point(373, 25);
            this.lblSonido.Name = "lblSonido";
            this.lblSonido.Size = new System.Drawing.Size(94, 13);
            this.lblSonido.TabIndex = 39;
            this.lblSonido.Text = "Sonido al Arrancar";
            // 
            // txtSonido
            // 
            this.txtSonido.Location = new System.Drawing.Point(368, 48);
            this.txtSonido.Name = "txtSonido";
            this.txtSonido.Size = new System.Drawing.Size(100, 20);
            this.txtSonido.TabIndex = 38;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(393, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(393, 284);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(75, 23);
            this.btnEstado.TabIndex = 36;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // grbDatosAereo
            // 
            this.grbDatosAereo.Controls.Add(this.cmbTipoVehiculo);
            this.grbDatosAereo.Controls.Add(this.txtNumHelices);
            this.grbDatosAereo.Controls.Add(this.txtNumTurbinas);
            this.grbDatosAereo.Controls.Add(this.txtNumAlas);
            this.grbDatosAereo.Controls.Add(this.lblTipoVehiculo);
            this.grbDatosAereo.Controls.Add(this.lblNumHelices);
            this.grbDatosAereo.Controls.Add(this.lblNumTurbinas);
            this.grbDatosAereo.Controls.Add(this.lblnumAlas);
            this.grbDatosAereo.Location = new System.Drawing.Point(12, 192);
            this.grbDatosAereo.Name = "grbDatosAereo";
            this.grbDatosAereo.Size = new System.Drawing.Size(319, 174);
            this.grbDatosAereo.TabIndex = 35;
            this.grbDatosAereo.TabStop = false;
            this.grbDatosAereo.Text = "Datos Generales del Aéreo";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(155, 118);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVehiculo.TabIndex = 23;
            // 
            // txtNumHelices
            // 
            this.txtNumHelices.Location = new System.Drawing.Point(176, 85);
            this.txtNumHelices.Name = "txtNumHelices";
            this.txtNumHelices.Size = new System.Drawing.Size(100, 20);
            this.txtNumHelices.TabIndex = 21;
            // 
            // txtNumTurbinas
            // 
            this.txtNumTurbinas.Location = new System.Drawing.Point(176, 53);
            this.txtNumTurbinas.Name = "txtNumTurbinas";
            this.txtNumTurbinas.Size = new System.Drawing.Size(100, 20);
            this.txtNumTurbinas.TabIndex = 20;
            // 
            // txtNumAlas
            // 
            this.txtNumAlas.Location = new System.Drawing.Point(176, 18);
            this.txtNumAlas.Name = "txtNumAlas";
            this.txtNumAlas.Size = new System.Drawing.Size(100, 20);
            this.txtNumAlas.TabIndex = 19;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(6, 126);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(126, 13);
            this.lblTipoVehiculo.TabIndex = 18;
            this.lblTipoVehiculo.Text = "Tipo de Vehículo Aéreo: ";
            // 
            // lblNumHelices
            // 
            this.lblNumHelices.AutoSize = true;
            this.lblNumHelices.Location = new System.Drawing.Point(30, 92);
            this.lblNumHelices.Name = "lblNumHelices";
            this.lblNumHelices.Size = new System.Drawing.Size(103, 13);
            this.lblNumHelices.TabIndex = 17;
            this.lblNumHelices.Text = "Número de Hélices: ";
            // 
            // lblNumTurbinas
            // 
            this.lblNumTurbinas.AutoSize = true;
            this.lblNumTurbinas.Location = new System.Drawing.Point(23, 57);
            this.lblNumTurbinas.Name = "lblNumTurbinas";
            this.lblNumTurbinas.Size = new System.Drawing.Size(109, 13);
            this.lblNumTurbinas.TabIndex = 16;
            this.lblNumTurbinas.Text = "Número de Turbinas: ";
            // 
            // lblnumAlas
            // 
            this.lblnumAlas.AutoSize = true;
            this.lblnumAlas.Location = new System.Drawing.Point(47, 25);
            this.lblnumAlas.Name = "lblnumAlas";
            this.lblnumAlas.Size = new System.Drawing.Size(85, 13);
            this.lblnumAlas.TabIndex = 15;
            this.lblnumAlas.Text = "Número de Alas:";
            // 
            // grbDatosVehiculo
            // 
            this.grbDatosVehiculo.Controls.Add(this.lblColor);
            this.grbDatosVehiculo.Controls.Add(this.txtColor);
            this.grbDatosVehiculo.Controls.Add(this.lblTipoCombustible);
            this.grbDatosVehiculo.Controls.Add(this.txtTipoCombustible);
            this.grbDatosVehiculo.Controls.Add(this.lblNumeroLlantas);
            this.grbDatosVehiculo.Controls.Add(this.txtNumeroLlantas);
            this.grbDatosVehiculo.Controls.Add(this.txtNumeroVentanas);
            this.grbDatosVehiculo.Controls.Add(this.lblNumeroVentanas);
            this.grbDatosVehiculo.Location = new System.Drawing.Point(12, 12);
            this.grbDatosVehiculo.Name = "grbDatosVehiculo";
            this.grbDatosVehiculo.Size = new System.Drawing.Size(319, 174);
            this.grbDatosVehiculo.TabIndex = 34;
            this.grbDatosVehiculo.TabStop = false;
            this.grbDatosVehiculo.Text = "Datos Generales del Vehículo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(41, 75);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(98, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color del Vehiculo: ";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(176, 72);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 1;
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.Location = new System.Drawing.Point(32, 43);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(109, 13);
            this.lblTipoCombustible.TabIndex = 2;
            this.lblTipoCombustible.Text = "Tipo de Combustible: ";
            // 
            // txtTipoCombustible
            // 
            this.txtTipoCombustible.Location = new System.Drawing.Point(176, 40);
            this.txtTipoCombustible.Name = "txtTipoCombustible";
            this.txtTipoCombustible.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCombustible.TabIndex = 3;
            // 
            // lblNumeroLlantas
            // 
            this.lblNumeroLlantas.AutoSize = true;
            this.lblNumeroLlantas.Location = new System.Drawing.Point(40, 107);
            this.lblNumeroLlantas.Name = "lblNumeroLlantas";
            this.lblNumeroLlantas.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroLlantas.TabIndex = 4;
            this.lblNumeroLlantas.Text = "Número de Llantas:";
            // 
            // txtNumeroLlantas
            // 
            this.txtNumeroLlantas.Location = new System.Drawing.Point(176, 107);
            this.txtNumeroLlantas.Name = "txtNumeroLlantas";
            this.txtNumeroLlantas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroLlantas.TabIndex = 5;
            // 
            // txtNumeroVentanas
            // 
            this.txtNumeroVentanas.Location = new System.Drawing.Point(176, 141);
            this.txtNumeroVentanas.Name = "txtNumeroVentanas";
            this.txtNumeroVentanas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroVentanas.TabIndex = 7;
            // 
            // lblNumeroVentanas
            // 
            this.lblNumeroVentanas.AutoSize = true;
            this.lblNumeroVentanas.Location = new System.Drawing.Point(26, 144);
            this.lblNumeroVentanas.Name = "lblNumeroVentanas";
            this.lblNumeroVentanas.Size = new System.Drawing.Size(113, 13);
            this.lblNumeroVentanas.TabIndex = 6;
            this.lblNumeroVentanas.Text = "Número de Ventanas: ";
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(383, 249);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(93, 23);
            this.btnParar.TabIndex = 31;
            this.btnParar.Text = "Parar Motor";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblArrancar
            // 
            this.lblArrancar.AutoSize = true;
            this.lblArrancar.Location = new System.Drawing.Point(337, 18);
            this.lblArrancar.Name = "lblArrancar";
            this.lblArrancar.Size = new System.Drawing.Size(0, 13);
            this.lblArrancar.TabIndex = 33;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(393, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnArrancar
            // 
            this.btnArrancar.Location = new System.Drawing.Point(376, 217);
            this.btnArrancar.Name = "btnArrancar";
            this.btnArrancar.Size = new System.Drawing.Size(100, 23);
            this.btnArrancar.TabIndex = 30;
            this.btnArrancar.Text = "Arrancar Motor";
            this.btnArrancar.UseVisualStyleBackColor = true;
            this.btnArrancar.Click += new System.EventHandler(this.btnArrancar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 389);
            this.Controls.Add(this.txtParar);
            this.Controls.Add(this.lblPararMotor);
            this.Controls.Add(this.lblSonido);
            this.Controls.Add(this.txtSonido);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.grbDatosAereo);
            this.Controls.Add(this.grbDatosVehiculo);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.lblArrancar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnArrancar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbDatosAereo.ResumeLayout(false);
            this.grbDatosAereo.PerformLayout();
            this.grbDatosVehiculo.ResumeLayout(false);
            this.grbDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParar;
        private System.Windows.Forms.Label lblPararMotor;
        private System.Windows.Forms.Label lblSonido;
        private System.Windows.Forms.TextBox txtSonido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.GroupBox grbDatosAereo;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txtNumHelices;
        private System.Windows.Forms.TextBox txtNumTurbinas;
        private System.Windows.Forms.TextBox txtNumAlas;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblNumHelices;
        private System.Windows.Forms.Label lblNumTurbinas;
        private System.Windows.Forms.Label lblnumAlas;
        private System.Windows.Forms.GroupBox grbDatosVehiculo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.TextBox txtTipoCombustible;
        private System.Windows.Forms.Label lblNumeroLlantas;
        private System.Windows.Forms.TextBox txtNumeroLlantas;
        private System.Windows.Forms.TextBox txtNumeroVentanas;
        private System.Windows.Forms.Label lblNumeroVentanas;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblArrancar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnArrancar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

