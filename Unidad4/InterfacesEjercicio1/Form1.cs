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
            if (cmbBebida.Text =="Cerveza")
            {
                objCerveza.Alcohol = cmbBebida.Text;
                objCerveza.Marca = txtMarca.Text;
                objCerveza.Cantidad = int.Parse(txtCantidad.Text);
                objCerveza.Llenar();

                MessageBox.Show(objCerveza.Mostrar(), "Llenado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (cmbBebida.Text == "Vino")
            {
                
                objVino.Alcohol = cmbBebida.Text;
                objVino.Marca = txtMarca.Text;
                objVino.Cantidad = int.Parse(txtCantidad.Text);
                objVino.Llenar();

                MessageBox.Show(objVino.Mostrar(), "Llenado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
