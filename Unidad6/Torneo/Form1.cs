using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torneo
{
    public partial class Form1 : Form
    {
        Torneo objTorneo = new Torneo();

        TextWriter archivo;
        string datosArchivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            archivo = new StreamWriter("archivo.txt");

            objTorneo.Nombre = txtNombre.Text;
            datosArchivo += "Nombre del Torneo: " + objTorneo.Nombre + "\n";

            objTorneo.NumEquipos = (int)nudNumEquipos.Value;
            datosArchivo += "Número de equipos: " + objTorneo.NumEquipos + "\n" ;

            objTorneo.FechaIn = dtpFechaIn.Value;
            datosArchivo += "Fecha de Inicio: " + objTorneo.FechaIn + "\n";

            objTorneo.FechaTer = dtpFechaTer.Value;
            datosArchivo += "Fecha de Terminó: " + objTorneo.FechaTer + "\n";

            objTorneo.Resta();

            objTorneo.PuntajePartidos = new string[objTorneo.NumEquipos, objTorneo.NumPartidos];

            for (int f = 0; f < objTorneo.NumEquipos; f++)
            {
                objTorneo.PuntajePartidos[f, 0] = Interaction.InputBox("Nombre del equipo " + (f + 1) + ":");

                datosArchivo += "Nombre del equipo: " + objTorneo.PuntajePartidos[f, 0] + "\n";

                for (int c = 0; c < objTorneo.NumPartidos; c++)
                {
                    objTorneo.PuntajePartidos[f, c] = Interaction.InputBox("Puntos obtenidos: ");

                    datosArchivo += "Puntos obtenidos: " + objTorneo.PuntajePartidos[f, c] + "\n";
                }

            }

            objTorneo.SumaPuntaje = new int[objTorneo.NumEquipos];
            objTorneo.SumaPuntos();

            txtNombre.Enabled = false;
            nudNumEquipos.Enabled = false;
            dtpFechaIn.Enabled = false;
            dtpFechaTer.Enabled = false;
            btnGuardar.Enabled = false;
            gpbPuntaje.Enabled = true;
        }

        private void btnDetGanador_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objTorneo.Ganador(), "Equipo Ganador", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            datosArchivo += "El equipo ganador es: " + objTorneo.Ganador() + "\n";

            archivo.WriteLine(datosArchivo);
            archivo.Close();

            txtGanado.Text = objTorneo.PunGanados.ToString();
            txtEmpatado.Text = objTorneo.PunEmpatados.ToString();
            txtPerdido.Text = objTorneo.PunPerdidos.ToString();

            txtNombre.Enabled = true;
            nudNumEquipos.Enabled = true;
            dtpFechaIn.Enabled = true;
            dtpFechaTer.Enabled = true;
            btnGuardar.Enabled = true;
            gpbPuntaje.Enabled = true;

            txtNombre.Clear();
            nudNumEquipos.Value = 2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
