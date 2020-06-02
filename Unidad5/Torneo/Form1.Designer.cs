namespace Torneo
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbPuntaje = new System.Windows.Forms.GroupBox();
            this.txtPerdido = new System.Windows.Forms.TextBox();
            this.txtEmpatado = new System.Windows.Forms.TextBox();
            this.txtGanado = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetGanador
            // 
            this.btnDetGanador.Location = new System.Drawing.Point(113, 298);
            this.btnDetGanador.Name = "btnDetGanador";
            this.btnDetGanador.Size = new System.Drawing.Size(130, 23);
            this.btnDetGanador.TabIndex = 52;
            this.btnDetGanador.Text = "Determinar al ganador ";
            this.btnDetGanador.UseVisualStyleBackColor = true;
            this.btnDetGanador.Click += new System.EventHandler(this.btnDetGanador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(260, 312);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(260, 133);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbPuntaje
            // 
            this.gpbPuntaje.Controls.Add(this.txtPerdido);
            this.gpbPuntaje.Controls.Add(this.txtEmpatado);
            this.gpbPuntaje.Controls.Add(this.txtGanado);
            this.gpbPuntaje.Controls.Add(this.lblPPerdidio);
            this.gpbPuntaje.Controls.Add(this.lblPEmpatado);
            this.gpbPuntaje.Controls.Add(this.lblPGanado);
            this.gpbPuntaje.Enabled = false;
            this.gpbPuntaje.Location = new System.Drawing.Point(10, 162);
            this.gpbPuntaje.Name = "gpbPuntaje";
            this.gpbPuntaje.Size = new System.Drawing.Size(324, 115);
            this.gpbPuntaje.TabIndex = 49;
            this.gpbPuntaje.TabStop = false;
            // 
            // txtPerdido
            // 
            this.txtPerdido.Location = new System.Drawing.Point(112, 75);
            this.txtPerdido.Name = "txtPerdido";
            this.txtPerdido.Size = new System.Drawing.Size(175, 20);
            this.txtPerdido.TabIndex = 5;
            // 
            // txtEmpatado
            // 
            this.txtEmpatado.Location = new System.Drawing.Point(112, 49);
            this.txtEmpatado.Name = "txtEmpatado";
            this.txtEmpatado.Size = new System.Drawing.Size(175, 20);
            this.txtEmpatado.TabIndex = 4;
            // 
            // txtGanado
            // 
            this.txtGanado.Location = new System.Drawing.Point(112, 23);
            this.txtGanado.Name = "txtGanado";
            this.txtGanado.Size = new System.Drawing.Size(175, 20);
            this.txtGanado.TabIndex = 3;
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
            this.dtpFechaTer.Location = new System.Drawing.Point(117, 102);
            this.dtpFechaTer.Name = "dtpFechaTer";
            this.dtpFechaTer.Size = new System.Drawing.Size(218, 20);
            this.dtpFechaTer.TabIndex = 48;
            // 
            // lblFechaTer
            // 
            this.lblFechaTer.AutoSize = true;
            this.lblFechaTer.Location = new System.Drawing.Point(9, 108);
            this.lblFechaTer.Name = "lblFechaTer";
            this.lblFechaTer.Size = new System.Drawing.Size(99, 13);
            this.lblFechaTer.TabIndex = 47;
            this.lblFechaTer.Text = "Fecha de Termino: ";
            // 
            // dtpFechaIn
            // 
            this.dtpFechaIn.Location = new System.Drawing.Point(117, 67);
            this.dtpFechaIn.Name = "dtpFechaIn";
            this.dtpFechaIn.Size = new System.Drawing.Size(218, 20);
            this.dtpFechaIn.TabIndex = 46;
            // 
            // nudNumEquipos
            // 
            this.nudNumEquipos.Location = new System.Drawing.Point(117, 39);
            this.nudNumEquipos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumEquipos.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumEquipos.Name = "nudNumEquipos";
            this.nudNumEquipos.Size = new System.Drawing.Size(94, 20);
            this.nudNumEquipos.TabIndex = 45;
            this.nudNumEquipos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblNumEquipos
            // 
            this.lblNumEquipos.AutoSize = true;
            this.lblNumEquipos.Location = new System.Drawing.Point(6, 39);
            this.lblNumEquipos.Name = "lblNumEquipos";
            this.lblNumEquipos.Size = new System.Drawing.Size(102, 13);
            this.lblNumEquipos.TabIndex = 44;
            this.lblNumEquipos.Text = "Número de equipos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 13);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre del Torneo: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 42;
            // 
            // lblFechaIn
            // 
            this.lblFechaIn.AutoSize = true;
            this.lblFechaIn.Location = new System.Drawing.Point(25, 73);
            this.lblFechaIn.Name = "lblFechaIn";
            this.lblFechaIn.Size = new System.Drawing.Size(83, 13);
            this.lblFechaIn.TabIndex = 41;
            this.lblFechaIn.Text = "Fecha de Inicio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 342);
            this.Controls.Add(this.btnDetGanador);
            this.Controls.Add(this.btnSalir);
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
            this.Text = "Form1";
            this.gpbPuntaje.ResumeLayout(false);
            this.gpbPuntaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetGanador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gpbPuntaje;
        private System.Windows.Forms.TextBox txtPerdido;
        private System.Windows.Forms.TextBox txtEmpatado;
        private System.Windows.Forms.TextBox txtGanado;
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

