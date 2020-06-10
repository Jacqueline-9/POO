using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeVersusJacque
{
    public partial class FormSnake : Form
    {
        public FormSnake()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Snake objSnake = new Snake();
            objSnake.Show();
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
