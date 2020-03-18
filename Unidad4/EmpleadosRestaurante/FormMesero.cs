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
    public partial class FormMesero : Form
    {
        Mesero objMesero = new Mesero();

        public FormMesero()
        {
            InitializeComponent();
        }

        private void FormMesero_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Introdzuca nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if(txtDiasT.Text == "")
            {
                errorProvider1.SetError(txtDiasT, "Introduzca la cantidad de días trabajados");
                txtDiasT.Focus();
                return;
            }
            errorProvider1.SetError(txtDiasT, "");

            if(txtSueldo.Text == "")
            {
                errorProvider1.SetError(txtSueldo, "Introduzca sueldo diario");
                txtSueldo.Focus();
                return; 
            }
            errorProvider1.SetError(txtSueldo, "");

            if(txtPropinaS.Text == "")
            {
                errorProvider1.SetError(txtPropinaS, "Introduzca propinas semanales");
                txtPropinaS.Focus();
                return;
            }
            errorProvider1.SetError(txtPropinaS, "");

            objMesero.Nombre = txtNombre.Text;
            objMesero.FechaNacimiento = int.Parse(dtpFechaN.Value.Year.ToString());
            objMesero.FechaNacimiento = int.Parse(dtpFechaN.Value.Month.ToString());
            objMesero.FechaNacimiento = int.Parse(dtpFechaN.Value.Day.ToString());
            objMesero.DiasTrabajados = int.Parse(txtDiasT.Text);
            objMesero.Sueldo = Double.Parse(txtSueldo.Text);
            objMesero.PropinaSemanal = int.Parse(txtPropinaS.Text);

            MessageBox.Show(objMesero.CalcularSueldo(), "Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
