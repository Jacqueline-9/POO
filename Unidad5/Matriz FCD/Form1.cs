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

namespace Matriz_FCD
{
    public partial class Form1 : Form
    {
        MatrizFCD FCD = new MatrizFCD();

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
            FCD.Bidi = new int[(int)nudCantidad.Value, (int)nudCantidad.Value];

            for (int f = 0; f < FCD.Bidi.GetLength(0); f++)
            {

                for (int c = 0; c < FCD.Bidi.GetLength(1); c++)
                {
                    FCD.Bidi[f, c] = Convert.ToInt32(Interaction.InputBox("Introduce el elemento [" + f + "] [" + c + "]"));
                    acum += FCD.Bidi[f, c];
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
            for (int f = 0; f < FCD.Bidi.GetLength(0); f++)
            {
                for (int c = 0; c < FCD.Bidi.GetLength(1); c++)
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
            FCD.SumFilas = new int[(int)nudCantidad.Value];
            FCD.SumaFilas();

            for (int f = 0; f < FCD.SumFilas.Length; f++)
            {
                acumF += FCD.SumFilas[f] + " ";
                lblSumasFilas.Text = acumF;
            }

            FCD.SumColumnas = new int[(int)nudCantidad.Value];
            FCD.SumaColumnas();

            for (int c = 0; c < FCD.SumColumnas.Length; c++)
            {
                acumC += FCD.SumColumnas[c] + "\n";
                lblSumasColumnas.Text = acumC;
            }

            FCD.Diagonal = new int[(int)nudCantidad.Value];
            lblDiagonalSuma.Text = FCD.SumaDiagonal();

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
