using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concierto
{
    public partial class Form1 : Form
    {
        ClassAsistente objAsistente = new ClassAsistente();

        public Form1()
        {
            InitializeComponent();
            cmbAsistente.Items.Add("Bebés");
            cmbAsistente.Items.Add("Niños");
            cmbAsistente.Items.Add("Adultos");
            cmbAsistente.Items.Add("Adultos Mayores");
            cmbCantidad.Items.Add("1");
            cmbCantidad.Items.Add("2");
            cmbCantidad.Items.Add("3");
            cmbCantidad.Items.Add("4");
            cmbCantidad.Items.Add("5");
            cmbCantidad.Items.Add("6");
            cmbCantidad.Items.Add("7");
            cmbCantidad.Items.Add("8");
            cmbCantidad.Items.Add("9");
            cmbCantidad.Items.Add("10");
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            if (cmbAsistente.Text == "")
            {
                errorProvider1.SetError(cmbAsistente, "Debe seleccionar un asistente");
                cmbAsistente.Focus();
                return;
            }
            errorProvider1.SetError(cmbAsistente, "");

            if (cmbCantidad.Text == "")
            {
                errorProvider2.SetError(cmbCantidad, "Debe seleccionar una Cantidad");
                cmbCantidad.Focus();
                return;
            }
            errorProvider2.SetError(cmbCantidad, "");


            objAsistente.asistente = cmbAsistente.Text;
            objAsistente.cantidad = int.Parse(cmbCantidad.Text.ToString());
            objAsistente.ContabilizarAsistentes();
            MessageBox.Show("El dato fue contabilizado correctamente");
            cmbAsistente.Text = ("");
            cmbCantidad.Text = ("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            lblBebe.Text = "Bebés: " + objAsistente.bebes.ToString();
            lblNiño.Text = "Niños: " + objAsistente.ninos.ToString();
            lblAdulto.Text = "Adultos: " + objAsistente.adultos.ToString();
            lblAdultosMayores.Text = "Adultos Mayores: " + objAsistente.adultoma.ToString();
        }
    }
}
