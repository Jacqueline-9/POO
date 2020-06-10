using AreaPerimetroCuadrado;
using Calificaciones;
using CasetaAutopista;
using Concierto;
using ConsumoElectricidad;
using DatosPersonas;
using DiasDeVacaciones;
using Embotelladora;
using MayoresEdad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnidadGradosCF;

namespace Catalogo
{
    public partial class Unidad2 : Form
    {
        public Unidad2()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            FormArea frm = new FormArea();
            frm.Show();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            FormCalif frm = new FormCalif();
            frm.Show();
        }

        private void btnAutopista_Click(object sender, EventArgs e)
        {
            FormCaseta frm = new FormCaseta();
            frm.Show();
        }

        private void btnConcierto_Click(object sender, EventArgs e)
        {
            FormConcierto frm = new FormConcierto();
            frm.Show();
        }

        private void btnElectricidad_Click(object sender, EventArgs e)
        {
            FormRecibo frm = new FormRecibo();
            frm.Show();
        }

        private void btnDatosPersonas_Click(object sender, EventArgs e)
        {
            FormPersonas frm = new FormPersonas();
            frm.Show();
        }

        private void btnDVacaciones_Click(object sender, EventArgs e)
        {
            FormVacaciones frm = new FormVacaciones();
            frm.Show();
        }

        private void btnEmbotelladora_Click(object sender, EventArgs e)
        {
            FormEmbotelladora frm = new FormEmbotelladora();
            frm.Show();
        }

        private void btnMayoresEdad_Click(object sender, EventArgs e)
        {
            FormMayorEdad frm = new FormMayorEdad();
            frm.Show();
        }

        private void btnUnidadesGCF_Click(object sender, EventArgs e)
        {
            FormGrados frm = new FormGrados();
            frm.Show();
        }

        private void btnDatosPer_Click(object sender, EventArgs e)
        {
            FormPersonas frm = new FormPersonas();
            frm.Show();
        }
    }
}
