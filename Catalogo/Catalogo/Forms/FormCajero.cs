using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosRestaurante
{
    public partial class FormCajero : Form
    {
        Cajero objCajero = new Cajero();

        public FormCajero()
        {
            InitializeComponent();

            cmbNumeroCaja.Items.Add("1");
            cmbNumeroCaja.Items.Add("2");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Introduzca nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtDiasT.Text == "")
            {
                errorProvider1.SetError(txtDiasT, "Introduzca la cantidad de días trabajados");
                txtDiasT.Focus();
                return;
            }
            errorProvider1.SetError(txtDiasT, "");

            if (txtSueldo.Text == "")
            {
                errorProvider1.SetError(txtSueldo, "Introduzca sueldo diario");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            objCajero.Nombre = txtNombre.Text;
            objCajero.FechaNacimiento = int.Parse (dtpFechaN.Value.Year.ToString());
            objCajero.FechaNacimiento = int.Parse(dtpFechaN.Value.Month.ToString());
            objCajero.FechaNacimiento = int.Parse(dtpFechaN.Value.Day.ToString());
            objCajero.DiasTrabajados = int.Parse(txtDiasT.Text);
            objCajero.Sueldo = Double.Parse(txtSueldo.Text);
            objCajero.NumeroCaja = cmbNumeroCaja.Text;

            MessageBox.Show(objCajero.CalcularSueldo(), "Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                
        }
    }
}
