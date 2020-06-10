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
    public partial class FormRestaurante : Form
    {
        public FormRestaurante()
        {
            InitializeComponent();

            cmbTipoEmpleado.Items.Add("Mesero");
            cmbTipoEmpleado.Items.Add("Cajero");
            cmbTipoEmpleado.Items.Add("Repartidor");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cmbTipoEmpleado.Text == "Mesero")
            {
                FormMesero Mesero = new FormMesero();
                Mesero.Show();
            }
            else if (cmbTipoEmpleado.Text == "Cajero")
            {
                FormCajero Cajero = new FormCajero();
                Cajero.Show();
            }
            else
            {
                FormRepartidor Repartidor = new FormRepartidor();
                Repartidor.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
