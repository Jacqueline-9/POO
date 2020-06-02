using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesEjercicio1
{
    public partial class Form1 : Form
    {
        Cerveza objCerveza = new Cerveza();
        Vino objVino = new Vino();

        public Form1()
        {
            InitializeComponent();

            cmbBebida.Items.Add("Cerveza");
            cmbBebida.Items.Add("Vino");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbBebida.Text == "")
            {
                errorProvider1.SetError(cmbBebida, "Introduzca el tipo de bebida");
                cmbBebida.Focus();
                return;
            }
            errorProvider1.SetError(cmbBebida, "");

            if (txtMarca.Text == "")
            {
                errorProvider1.SetError(txtMarca, "Introduzca la marca de la bebida");
                txtMarca.Focus();
                return;
            }
            errorProvider1.SetError(txtMarca, "");

            if (txtCantidad.Text == "")
            {
                errorProvider1.SetError(txtCantidad, "Introduzca la cantidad que pesa la bebida");
                txtCantidad.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidad, "");

            if (cmbBebida.Text =="Cerveza")
            {
                objCerveza.Alcohol = cmbBebida.Text;
                objCerveza.Marca = txtMarca.Text;
                objCerveza.Cantidad = int.Parse(txtCantidad.Text);
                objCerveza.Llenar();
                objCerveza.sumar();
                cmbBebida.Text = "";
                txtCantidad.Text = "";
                txtMarca.Text = "";

                MessageBox.Show(objCerveza.Mostrar(), "Llenado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (cmbBebida.Text == "Vino")
            {
                
                objVino.Alcohol = cmbBebida.Text;
                objVino.Marca = txtMarca.Text;
                objVino.Cantidad = int.Parse(txtCantidad.Text);
                objVino.Llenar();
                objVino.sumar();
                cmbBebida.Text = "";
                txtCantidad.Text = "";
                txtMarca.Text = "";

                MessageBox.Show(objVino.Mostrar(), "Llenado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informe objInforme = new Informe();
            objInforme.txtCervezas.Text = objCerveza.SumaC.ToString();
            objInforme.txtVinos.Text = objVino.SumaV.ToString();
            objInforme.Show();
        }
    }
}
