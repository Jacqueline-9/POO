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

namespace FilasColumnasDiagonal
{
    public partial class Form1 : Form
    {
        Arreglos objArreglos = new Arreglos();

        int N = 0;
        string acum = "";
        string acumF = "";
        string acumC = "";
        string acumD = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objArreglos.Bidimensional = new int [(int)nudCantidad.Value, (int)nudCantidad.Value];

            for (int f = 0; f < objArreglos.Bidimensional.GetLength(0); f++)
            {
                
                for (int c = 0; c < objArreglos.Bidimensional.GetLength(1); c++)
                {
                    objArreglos.Bidimensional[f, c] = Convert.ToInt32(Interaction.InputBox("Introduce el elemento [" + f + "] [" + c + "]"));
                    acum += objArreglos.Bidimensional[f, c];
                }
                acum += "\r\n";
            }

            nudCantidad.Enabled = false;
            btnIngresar.Enabled = false;
            rtbMatriz.Enabled = true;
            btnImprimir.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < objArreglos.Bidimensional.GetLength(0); f++)
            {
                for (int c = 0; c < objArreglos.Bidimensional.GetLength(1); c++)
                {
                    rtbMatriz.Text = acum;
                }
            }

            rtbMatriz.Enabled = false;
            btnImprimir.Enabled = false;
            btnImprimirSuma.Enabled = true;
        }

        private void btnImprimirSuma_Click(object sender, EventArgs e)
        {
            objArreglos.SumFilas = new int[(int)nudCantidad.Value];
            objArreglos.SumaFilas();

            for (int f = 0; f < objArreglos.SumFilas.Length; f++)
            {
                acumF += objArreglos.SumFilas[f] + " ";
                lblSumasFilas.Text = acumF;
            }

            objArreglos.SumColumnas = new int[(int)nudCantidad.Value];
            objArreglos.SumaColumnas();

            for (int c = 0; c < objArreglos.SumColumnas.Length; c++)
            {
                acumC += objArreglos.SumColumnas[c] + "\n";
                lblSumasColumnas.Text = acumC;
            }

            objArreglos.Diagonal = new int[(int)nudCantidad.Value];
            lblDiagonalSuma.Text = objArreglos.SumaDiagonal();

            btnImprimirSuma.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nudCantidad.Value = 2;
            rtbMatriz.Clear();
            lblSumasColumnas.Text = "";
            lblSumasFilas.Text = "";
            lblDiagonalSuma.Text = "";

            nudCantidad.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
