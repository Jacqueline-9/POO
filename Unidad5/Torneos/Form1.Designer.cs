﻿namespace Torneos
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
            this.btnDetGanador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbPuntaje = new System.Windows.Forms.GroupBox();
            this.nudPerdido = new System.Windows.Forms.NumericUpDown();
            this.nudEmpatado = new System.Windows.Forms.NumericUpDown();
            this.nudGanado = new System.Windows.Forms.NumericUpDown();
            this.lblPPerdidio = new System.Windows.Forms.Label();
            this.lblPEmpatado = new System.Windows.Forms.Label();
            this.lblPGanado = new System.Windows.Forms.Label();
            this.dtpFechaTer = new System.Windows.Forms.DateTimePicker();
            this.lblFechaTer = new System.Windows.Forms.Label();
            this.dtpFechaIn = new System.Windows.Forms.DateTimePicker();
            this.nudNumEquipos = new System.Windows.Forms.NumericUpDown();
            this.lblNumEquipos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaIn = new System.Windows.Forms.Label();
            this.gpbPuntaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerdido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpatado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetGanador
            // 
            this.btnDetGanador.Location = new System.Drawing.Point(125, 321);
            this.btnDetGanador.Name = "btnDetGanador";
            this.btnDetGanador.Size = new System.Drawing.Size(130, 23);
            this.btnDetGanador.TabIndex = 27;
            this.btnDetGanador.Text = "Determinar al ganador ";
            this.btnDetGanador.UseVisualStyleBackColor = true;
            this.btnDetGanador.Click += new System.EventHandler(this.btnDetGanador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(271, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Enabled = false;
            this.btnIngresar.Location = new System.Drawing.Point(272, 291);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 25;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(272, 141);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbPuntaje
            // 
            this.gpbPuntaje.Controls.Add(this.nudPerdido);
            this.gpbPuntaje.Controls.Add(this.nudEmpatado);
            this.gpbPuntaje.Controls.Add(this.nudGanado);
            this.gpbPuntaje.Controls.Add(this.lblPPerdidio);
            this.gpbPuntaje.Controls.Add(this.lblPEmpatado);
            this.gpbPuntaje.Controls.Add(this.lblPGanado);
            this.gpbPuntaje.Enabled = false;
            this.gpbPuntaje.Location = new System.Drawing.Point(22, 170);
            this.gpbPuntaje.Name = "gpbPuntaje";
            this.gpbPuntaje.Size = new System.Drawing.Size(325, 115);
            this.gpbPuntaje.TabIndex = 23;
            this.gpbPuntaje.TabStop = false;
            // 
            // nudPerdido
            // 
            this.nudPerdido.Location = new System.Drawing.Point(113, 73);
            this.nudPerdido.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPerdido.Name = "nudPerdido";
            this.nudPerdido.Size = new System.Drawing.Size(120, 20);
            this.nudPerdido.TabIndex = 5;
            // 
            // nudEmpatado
            // 
            this.nudEmpatado.Location = new System.Drawing.Point(113, 46);
            this.nudEmpatado.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEmpatado.Name = "nudEmpatado";
            this.nudEmpatado.Size = new System.Drawing.Size(120, 20);
            this.nudEmpatado.TabIndex = 4;
            // 
            // nudGanado
            // 
            this.nudGanado.Location = new System.Drawing.Point(113, 18);
            this.nudGanado.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGanado.Name = "nudGanado";
            this.nudGanado.Size = new System.Drawing.Size(120, 20);
            this.nudGanado.TabIndex = 3;
            // 
            // lblPPerdidio
            // 
            this.lblPPerdidio.AutoSize = true;
            this.lblPPerdidio.Location = new System.Drawing.Point(18, 79);
            this.lblPPerdidio.Name = "lblPPerdidio";
            this.lblPPerdidio.Size = new System.Drawing.Size(88, 13);
            this.lblPPerdidio.TabIndex = 2;
            this.lblPPerdidio.Text = "Puntaje Perdido: ";
            // 
            // lblPEmpatado
            // 
            this.lblPEmpatado.AutoSize = true;
            this.lblPEmpatado.Location = new System.Drawing.Point(6, 54);
            this.lblPEmpatado.Name = "lblPEmpatado";
            this.lblPEmpatado.Size = new System.Drawing.Size(100, 13);
            this.lblPEmpatado.TabIndex = 1;
            this.lblPEmpatado.Text = "Puntaje Empatado: ";
            // 
            // lblPGanado
            // 
            this.lblPGanado.AutoSize = true;
            this.lblPGanado.Location = new System.Drawing.Point(16, 26);
            this.lblPGanado.Name = "lblPGanado";
            this.lblPGanado.Size = new System.Drawing.Size(90, 13);
            this.lblPGanado.TabIndex = 0;
            this.lblPGanado.Text = "Puntaje Ganado: ";
            // 
            // dtpFechaTer
            // 
            this.dtpFechaTer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaTer.Location = new System.Drawing.Point(129, 110);
            this.dtpFechaTer.Name = "dtpFechaTer";
            this.dtpFechaTer.Size = new System.Drawing.Size(218, 20);
            this.dtpFechaTer.TabIndex = 22;
            // 
            // lblFechaTer
            // 
            this.lblFechaTer.AutoSize = true;
            this.lblFechaTer.Location = new System.Drawing.Point(21, 116);
            this.lblFechaTer.Name = "lblFechaTer";
            this.lblFechaTer.Size = new System.Drawing.Size(99, 13);
            this.lblFechaTer.TabIndex = 21;
            this.lblFechaTer.Text = "Fecha de Termino: ";
            // 
            // dtpFechaIn
            // 
            this.dtpFechaIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaIn.Location = new System.Drawing.Point(129, 75);
            this.dtpFechaIn.Name = "dtpFechaIn";
            this.dtpFechaIn.Size = new System.Drawing.Size(217, 20);
            this.dtpFechaIn.TabIndex = 20;
            // 
            // nudNumEquipos
            // 
            this.nudNumEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumEquipos.Location = new System.Drawing.Point(129, 47);
            this.nudNumEquipos.Name = "nudNumEquipos";
            this.nudNumEquipos.Size = new System.Drawing.Size(84, 20);
            this.nudNumEquipos.TabIndex = 19;
            // 
            // lblNumEquipos
            // 
            this.lblNumEquipos.AutoSize = true;
            this.lblNumEquipos.Location = new System.Drawing.Point(18, 47);
            this.lblNumEquipos.Name = "lblNumEquipos";
            this.lblNumEquipos.Size = new System.Drawing.Size(102, 13);
            this.lblNumEquipos.TabIndex = 18;
            this.lblNumEquipos.Text = "Número de equipos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre del Torneo: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(129, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // lblFechaIn
            // 
            this.lblFechaIn.AutoSize = true;
            this.lblFechaIn.Location = new System.Drawing.Point(37, 81);
            this.lblFechaIn.Name = "lblFechaIn";
            this.lblFechaIn.Size = new System.Drawing.Size(83, 13);
            this.lblFechaIn.TabIndex = 15;
            this.lblFechaIn.Text = "Fecha de Inicio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 385);
            this.Controls.Add(this.btnDetGanador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbPuntaje);
            this.Controls.Add(this.dtpFechaTer);
            this.Controls.Add(this.lblFechaTer);
            this.Controls.Add(this.dtpFechaIn);
            this.Controls.Add(this.nudNumEquipos);
            this.Controls.Add(this.lblNumEquipos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFechaIn);
            this.Name = "Form1";
            this.Text = "Torneo";
            this.gpbPuntaje.ResumeLayout(false);
            this.gpbPuntaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerdido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpatado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetGanador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gpbPuntaje;
        private System.Windows.Forms.NumericUpDown nudPerdido;
        private System.Windows.Forms.NumericUpDown nudEmpatado;
        private System.Windows.Forms.NumericUpDown nudGanado;
        private System.Windows.Forms.Label lblPPerdidio;
        private System.Windows.Forms.Label lblPEmpatado;
        private System.Windows.Forms.Label lblPGanado;
        private System.Windows.Forms.DateTimePicker dtpFechaTer;
        private System.Windows.Forms.Label lblFechaTer;
        private System.Windows.Forms.DateTimePicker dtpFechaIn;
        private System.Windows.Forms.NumericUpDown nudNumEquipos;
        private System.Windows.Forms.Label lblNumEquipos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaIn;
    }
}
