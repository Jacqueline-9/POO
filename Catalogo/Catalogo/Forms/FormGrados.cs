using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnidadGradosCF
{
    public partial class FormGrados : Form
    {
        ClassTemperatura objTemperatura = new ClassTemperatura();

        public FormGrados()
        {
            InitializeComponent();
            cmbUnidad.Items.Add("Centígrados");
            cmbUnidad.Items.Add("Farenheit");
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtGrados.Text == "")
            {
                errorProvider1.SetError(txtGrados, "Debe introducir grados");
                txtGrados.Focus();
                return;
            }
            if (cmbUnidad.Text == "")
            {
                errorProvider2.SetError(cmbUnidad, "Debe Introducir unidad de grados");
                cmbUnidad.Focus();
                return;
            }
            objTemperatura.unidad = cmbUnidad.Text;
            objTemperatura.grados = Convert.ToDouble(txtGrados.Text);
            objTemperatura.ConvertirUnidad();
            lblGradosCon.Text = "Grados Convertidos:" + objTemperatura.grados.ToString() + "°";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
