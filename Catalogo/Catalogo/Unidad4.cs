using EmpleadosRestaurante;
using FigurasGeometricas;
using System;
using FontAwesome;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfacesEjercicio1;
using Operación;
using JuegodePreguntas;
using SnakeVersusJacque;
using Vehículos;

namespace Catalogo
{
    public partial class Unidad4 : Form
    {
        public Unidad4()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormRestaurante frm = new FormRestaurante();
            frm.Show();
        }

        private void btnFiguras_Click(object sender, EventArgs e)
        {
            FormFiguras form = new FormFiguras();
            form.Show();
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            FormEjercicio1 frm = new FormEjercicio1();
            frm.Show();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            FormPreguntas frm = new FormPreguntas();
            frm.Show();
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            FormOperacion frm = new FormOperacion();
            frm.Show();
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            FormSnake frm = new FormSnake();
            frm.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FormVehiculos frm = new FormVehiculos();
            frm.Show();
        }
    }
}
