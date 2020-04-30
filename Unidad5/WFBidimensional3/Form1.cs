using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBidimensional3
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        int i, j;
        int filas, columnas;
        int buscar;
        string acumArray;
        string acumPar;
        int[,] arrayBidi = new int[100, 100];

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(acumArray, "Elementos del arreglo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            
        }
    }
}
