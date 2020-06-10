using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegodePreguntas
{
    public partial class FormPreguntas : Form
    {
        public FormPreguntas()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Preguntas objPreguntas = new Preguntas();
            objPreguntas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            Reglamento objReglamento = new Reglamento();
            objReglamento.Show();
        }
    }
}
