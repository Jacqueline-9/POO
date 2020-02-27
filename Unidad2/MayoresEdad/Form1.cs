using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayoresEdad
{
    public partial class Form1 : Form
    {
        ClassPersona objPersona = new ClassPersona();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            objPersona.anioA = int.Parse (DateTime.Today.Year.ToString());
            objPersona.anioN = int.Parse(dtpFechaNac.Value.Year.ToString());
            objPersona.mesA = int.Parse(DateTime.Today.Month.ToString());
            objPersona.mesN = int.Parse(dtpFechaNac.Value.Month.ToString());
            objPersona.diaA = int.Parse(DateTime.Today.Day.ToString());
            objPersona.diaN = int.Parse(dtpFechaNac.Value.Day.ToString());
            objPersona.MayoresEdad();
            lblMayorEdad.Text = objPersona.mayorEdad;
            objPersona.mayorEdad = "";
            
        }
    }
}
