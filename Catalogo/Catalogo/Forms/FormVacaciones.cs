using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasDeVacaciones
{
    public partial class FormVacaciones : Form
    {
        ClassEmpleado objEmpleado = new ClassEmpleado();

        public FormVacaciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtaniosTrabajados.Text == "")
            {
                errorProvider1.SetError(txtaniosTrabajados, "Debe Introducir los años trabajados");
                txtaniosTrabajados.Focus();
                return;
            }

            objEmpleado.aniosTrabajados = int.Parse (txtaniosTrabajados.Text);
            objEmpleado.CalcularDias();
            lblDiasdeVaciones.Text = "Días de Vacaciones: " + objEmpleado.diasVacaciones.ToString();
        }
    }
}
