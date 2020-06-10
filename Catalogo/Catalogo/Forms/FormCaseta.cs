using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasetaAutopista
{
    public partial class FormCaseta : Form
    {
        ClassVehículo objVehiculo = new ClassVehículo();

        public FormCaseta()
        {
            InitializeComponent();

            cmbVehículo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbVehículo.Items.Add("Motociclista");
            cmbVehículo.Items.Add("Automóvil");
            cmbVehículo.Items.Add("Autobús");
            cmbVehículo.Items.Add("Tráiler");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objVehiculo.tipoVehiculo = cmbVehículo.Text;
            objVehiculo.CalcularCantidadCobrar();
            txtCantidadCobrar.Text = objVehiculo.cantidadCobrar.ToString();
        }
    }
}
