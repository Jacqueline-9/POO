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
    public partial class FormWFBidi2 : Form
    {
        public FormWFBidi2()
        {
            InitializeComponent();
        }

        int i, j;
        int filas, columnas;
        int buscar;
        string acumArray;
        string acumPar;
        int[,] arrayBidi = new int[100, 100];

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar = Convert.ToInt16(txtBuscar.Text);

            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    if (arrayBidi[i, j] == buscar)
                    {
                        MessageBox.Show(Convert.ToString(buscar), "El número si existe", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            for (i = 0; i < filas; i++)
            {
                acumPar += "\n";
                for (j = 0; j < columnas; j++)
                {
                    if (arrayBidi[i, j]%2==0)
                    {
                        acumPar += arrayBidi[i, j];
                    }
                }
            }
            MessageBox.Show(acumPar, "Números pares", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            filas = Convert.ToInt16(txtFilas.Text);
            columnas = Convert.ToInt16(txtColumnas.Text);

            for (i = 0; i < filas; i++)
            {
                acumArray += "\n";

                for (j = 0; j < columnas; j++)
                {
                    arrayBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Ingresa el valor " + i + "," + j));
                    acumArray += arrayBidi[i, j] + ",";
                }
            }
        }

        private void btnOperaciones_Click_1(object sender, EventArgs e)
        {
            OperacionesWFBidi2 Operaciones = new OperacionesWFBidi2();
            Operaciones.Show();
            this.Hide();
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
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
            this.Close();
        }
    }
}
