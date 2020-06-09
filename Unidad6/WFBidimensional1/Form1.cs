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

namespace WFBidimensional1
{
    public partial class Form1 : Form
    {

        TextWriter archivo;
        string datosArchivos;

        public Form1()
        {
            InitializeComponent();
        }

        int i, j;
        string acumArray;
        int[,] arrayBidi = new int[100, 100];

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            archivo = new StreamWriter("archivo.txt");

            int filas, columnas;
            filas = Convert.ToInt16(txtFilas.Text);
            datosArchivos += "Cantidad de filas: " + filas + "\n";

            columnas = Convert.ToInt16(txtColumnas.Text);
            datosArchivos += "Cantidad de columnas: " + columnas + "\n";

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(acumArray, "Elementos del arreglo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            datosArchivos += "Los números ingresados son: " + acumArray;

            archivo.WriteLine(datosArchivos);
            archivo.Close();
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
    }
}
