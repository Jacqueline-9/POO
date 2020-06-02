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

namespace WFBidimensional2
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        int[,] arrayA = new int[100, 100];
        int[,] arrayB = new int[100, 100];
        int[,] arrayC = new int[100, 100];
        int fila;
        int colu;
        int i, j;
        string acumA;
        string acumB;
        string acumC;

        private void btnTamMatriz_Click_1(object sender, EventArgs e)
        {
            fila = Convert.ToInt16(Interaction.InputBox("¿Cuantas filas tiene la matriz?"));
            colu = Convert.ToInt16(Interaction.InputBox("¿Cuantas columnas tiene la matriz?"));
        }

        private void btnDatosA_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz A", "Ingresar datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            for (i = 0; i < fila; i++)
            {
                acumA += "\r\n";
                for (j = 0; j < colu; j++)
                {
                    arrayA[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz A  " + i + "," + j));
                    acumA += arrayA[i, j] + "\n";
                    txtA.Text = acumA;
                }
            }
        }

        private void btnDatosB_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz B", "Ingresar datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            for (i = 0; i < fila; i++)
            {
                acumB += "\r\n";
                for (j = 0; j < colu; j++)
                {
                    arrayB[i, j] = Convert.ToInt16(Interaction.InputBox(" Matriz B  " + i + "," + j));
                    acumB += arrayB[i, j] + "\n";
                    txtB.Text = acumB;
                }
            }
        }

        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            for (i = 0; i < fila; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < colu; j++)
                {
                    arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                    acumC += arrayC[i, j] + "\n";
                    txtC.Text = acumC;
                }
            }
        }

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            for (i = 0; i < fila; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < colu; j++)
                {
                    arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
                    acumC += arrayC[i, j] + "\n";
                    txtC.Text = acumC;
                }
            }
        }


        private void bubtnMultip_Click_1(object sender, EventArgs e)
        {
            for (i = 0; i < fila; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < colu; j++)
                {
                    arrayC[i, j] = arrayA[i, j] * arrayB[i, j];
                    acumC += arrayC[i, j] + "\n";
                    txtC.Text = acumC;
                }
            }
        }

        private void btnDivision_Click_1(object sender, EventArgs e)
        {
            for (i = 0; i < fila; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < colu; j++)
                {
                    arrayC[i, j] = arrayA[i, j] / arrayB[i, j];
                    acumC += arrayC[i, j] + "\n";
                    txtC.Text = acumC;
                }
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            acumA = "";
            acumB = "";
            acumC = "";
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
