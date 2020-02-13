using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones2intento
{
    public partial class Form1 : Form
    {
        ClassCalificaciones objCalificaciones = new ClassCalificaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (txtCalificación.Text == "")
            {
                errorProvider1.SetError(txtCalificación,"Debe introducir una calificación ");
                txtCalificación.Focus();
                return;

            }
            errorProvider1.SetError(txtCalificación, "");

            objCalificaciones.calLeida = int.Parse(txtCalificación.Text.ToString());
            objCalificaciones.capturarCalificación();
            txtCalificación.Text = "";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            lblAprobados.Text = "Aprobados: "+objCalificaciones.aprobados.ToString();
            lblReprobados.Text = "Reprobados: " + objCalificaciones.reprobados.ToString();
            lblPromedio.Text = "Promedio: " + objCalificaciones.promedio.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCalificación_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
