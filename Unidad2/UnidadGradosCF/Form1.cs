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
    public partial class Form1 : Form
    {
        ClassTemperatura objTemperatura = new ClassTemperatura();

        public Form1()
        {
            InitializeComponent();
            cmbUnidad.Items.Add("Centígrados");
            cmbUnidad.Items.Add("Farenheit");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            Application.Exit();
        }
    }
}
