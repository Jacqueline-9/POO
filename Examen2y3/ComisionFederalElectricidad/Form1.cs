using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComisionFederalElectricidad
{
    public partial class Form1 : Form
    {
        ClassRecibo objRecibo = new ClassRecibo();

        public Form1()
        {
            InitializeComponent();

            cmbTipo.Items.Add("Hogar");
            cmbTipo.Items.Add("Negocio");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "")
            {
                errorProvider1.SetError(cmbTipo, "Introduzca Tipo");
                cmbTipo.Focus();
                return;
            }

            if (txtKW.Text == "")
            {
                errorProvider2.SetError(txtKW, "Introduzca Cantidad de KW");
                txtKW.Focus();
                return;
            }

            objRecibo.tipo = cmbTipo.Text;
            objRecibo.KW = int.Parse (txtKW.Text);
            objRecibo.CalcularCantidadPagar();
            lblCantidadPagar.Text = "Cantidad a Pagar: " + objRecibo.cantidadPagar.ToString();
        }
    }
}
