using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimetroCuadrado
{
    public partial class FormArea : Form
    {
        ClassCuadrado objCuadrado = new ClassCuadrado();

        public FormArea()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objCuadrado.lado = int.Parse (txtLado.Text);
            objCuadrado.CalcularArea();
            objCuadrado.CalcularPerimetro();
            lblArea.Text = "Área: " + objCuadrado.area.ToString();
            lblPerimetro.Text = "Perímetro: " + objCuadrado.perimetro.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
