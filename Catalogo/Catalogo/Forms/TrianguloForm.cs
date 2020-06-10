using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class TrianguloForm : Form
    {
        public TrianguloForm()
        {
            InitializeComponent();
        }

        public TrianguloForm (double Lado)
        {
            InitializeComponent();
            lblLadoT.Text = "Lado: " + Lado.ToString();
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
