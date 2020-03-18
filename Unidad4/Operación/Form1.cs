using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operación
{
    public partial class Form1 : Form
    {
        Suma objSuma = new Suma();
        Resta objResta = new Resta();
        Multiplicacion objMultiplicacion = new Multiplicacion();
        Divison objDivision = new Divison();

        public Form1()
        {
            InitializeComponent();

            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "")
            {
                errorProvider1.SetError(txtValor1, "Debe introducir el valor 1");
                txtValor1.Focus();
                return;
            }
            errorProvider1.SetError(txtValor1, "");

            if (txtValor2.Text == "")
            {
                errorProvider1.SetError(txtValor2, "Debe introducir el valor 2");
                txtValor2.Focus();
                return;
            }
            errorProvider1.SetError(txtValor2, "");

            if (cmbOperacion.Text == "")
            {
                errorProvider1.SetError(cmbOperacion, "Debe seleccionar la operación");
                cmbOperacion.Focus();
                return;
            }
            errorProvider1.SetError(cmbOperacion, "");

            if (cmbOperacion.Text == "+")
            {
                objSuma.Valor1 = Convert.ToDouble(txtValor1.Text);
                objSuma.Valor2 = Convert.ToDouble(txtValor2.Text);
                objSuma.Sumar();
                txtResultado.Text = objSuma.Resultado.ToString();
            }

            else if (cmbOperacion.Text == "-")
            {
                objResta.Valor1 = Convert.ToDouble(txtValor1.Text);
                objResta.Valor2 = Convert.ToDouble(txtValor2.Text);
                objResta.Restar();
                txtResultado.Text = objResta.Resultado.ToString();
            }

            else if (cmbOperacion.Text == "*")
            {
                objMultiplicacion.Valor1 = Convert.ToDouble(txtValor1.Text);
                objMultiplicacion.Valor2 = Convert.ToDouble(txtValor2.Text);
                objMultiplicacion.Multiplicar();
                txtResultado.Text = objMultiplicacion.Resultado.ToString();
            }

            else if (cmbOperacion.Text == "/")
            {
                objDivision.Valor1 = Convert.ToDouble(txtValor1.Text);
                objDivision.Valor2 = Convert.ToDouble(txtValor2.Text);
                objDivision.Dividir();
                txtResultado.Text = objDivision.Resultado.ToString();
            }
        }
    }
}
