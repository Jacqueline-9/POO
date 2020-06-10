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

namespace WFBidimensional1
{
    public partial class FormWFBidi1 : Form
    {
        public FormWFBidi1()
        {
            InitializeComponent();
        }

        int i, j;
        string acumArray;
        int[,] arrayBidi = new int[100, 100];

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(acumArray, "Elementos del arreglo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFilas.Clear();
            txtColumnas.Clear();
            acumArray = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int filas, columnas;
            filas = Convert.ToInt16(txtFilas.Text);
            columnas = Convert.ToInt16(txtColumnas.Text);

            int[,] arrayBidi = new int[10, 10];

            for (i = 0; i < filas; i++)
            {
                acumArray += "\n";
                for (j = 0; j < columnas; j++)
                {
                    arrayBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Ingrese el valor" + i + "," + j));
                    acumArray += arrayBidi[i, j] + ",";
                }
            }
        }
    }
}
