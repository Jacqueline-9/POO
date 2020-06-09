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

namespace BidimensionalEjemplo1
{
    public partial class Form1 : Form
    {
        int[,] arregloBidi;
        int filas, columnas;
        TextWriter archivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("archivo.txt");
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            filas = (int)nudFilas.Value;
            columnas = (int)nudColumnas.Value;

            arregloBidi = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    arregloBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Introduce el elemento [" + i + "]  [" + j + "] : "));
                }
            }
            btnCapturar.Enabled = false;
            btnImprimir.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    rtbimprimir.Text += arregloBidi[i, j] + " ";
                    archivo.Write(arregloBidi[i, j] + " ") ;
                }
                archivo.WriteLine();
                rtbimprimir.Text += "\n";
            }
            archivo.Close();

            btnCapturar.Enabled = true;
            btnImprimir.Enabled = false;
            nudFilas.Value = 1;
            nudColumnas.Value = 1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
