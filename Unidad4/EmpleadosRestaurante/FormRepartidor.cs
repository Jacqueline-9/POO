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
    public partial class FormRepartidor : Form
    {
        Repartidor objRepartidor = new Repartidor();

        public FormRepartidor()
        {
            InitializeComponent();

            cmbZonaR.Items.Add("1");
            cmbZonaR.Items.Add("2");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Introduzca nombre");
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
                errorProvider1.SetError(txtPropinaS, "Introduzca propinas");
                txtPropinaS.Focus();
                return;
            }
            errorProvider1.SetError(txtPropinaS, "");

            if(txtAbonosC.Text == "")
            {
                errorProvider1.SetError(txtAbonosC, "Introduzca los abonos cobrados");
                txtAbonosC.Focus();
                return;
            }
            errorProvider1.SetError(txtAbonosC, "");

            objRepartidor.Nombre = txtNombre.Text;
            objRepartidor.FechaNacimiento = int.Parse(dtpFechaN.Value.Year.ToString());
            objRepartidor.FechaNacimiento = int.Parse(dtpFechaN.Value.Month.ToString());
            objRepartidor.FechaNacimiento = int.Parse(dtpFechaN.Value.Day.ToString());
            objRepartidor.DiasTrabajados = int.Parse(txtDiasT.Text);
            objRepartidor.Sueldo = double.Parse(txtSueldo.Text);
            objRepartidor.PropinaSemanal = double.Parse(txtPropinaS.Text);
            objRepartidor.ZonaRepartir = cmbZonaR.Text;
            objRepartidor.AbonosCobrados = double.Parse(txtAbonosC.Text);

            MessageBox.Show(objRepartidor.CalcularSueldo(), "Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void FormRepartidor_Load(object sender, EventArgs e)
        {

        }
    }
}
