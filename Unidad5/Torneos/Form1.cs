using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torneos
{
    public partial class Form1 : Form
    {
        Torneo objTorneo = new Torneo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objTorneo.Nombre = txtNombre.Text;
            objTorneo.NumEquipos = (int)nudNumEquipos.Value;
            objTorneo.FechaIn = dtpFechaIn.Value;
            objTorneo.FechaTer = dtpFechaTer.Value;

            txtNombre.Enabled = false;
            nudNumEquipos.Enabled = false;
            dtpFechaIn.Enabled = false;
            dtpFechaTer.Enabled = false;
            btnGuardar.Enabled = false;
            gpbPuntaje.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objTorneo.PunGanados = (int)nudGanado.Value;
            objTorneo.PunEmpatados = (int)nudEmpatado.Value;
            objTorneo.PunPerdidos = (int)nudPerdido.Value;

            objTorneo.PuntajePartidos = new string [objTorneo.NumEquipos, objTorneo.NumEquipos];

            for (int f = 0; f < objTorneo.PuntajePartidos.GetLength(0); f++)
            {
                objTorneo.PuntajePartidos[f, 0] = Interaction.InputBox("Nombre del equipo" + (f + 1) + ": ");

                for (int c = 1; c < objTorneo.PuntajePartidos.GetLength(1); c++)
                {
                    objTorneo.PuntajePartidos[f, c] = Interaction.InputBox("Puntaje obtenido del equipo: ");
                }

                objTorneo.SumaPuntaje = new int[objTorneo.NumEquipos];
                objTorneo.SumaPuntos();
            }

            gpbPuntaje.Enabled = false;
            btnIngresar.Enabled = false;
        }

        private void btnDetGanador_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objTorneo.EquipoGanador(), objTorneo.Nombre, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            txtNombre.Enabled = true;
            nudNumEquipos.Enabled = true;
            dtpFechaIn.Enabled = true;
            dtpFechaTer.Enabled = true;
            btnGuardar.Enabled = true;

            txtNombre.Clear();
            nudNumEquipos.Value = 0;
            nudGanado.Value = 0;
            nudEmpatado.Value = 0;
            nudPerdido.Value = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
