using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerArrayList
{
    public partial class Form1 : Form
    {
        ArrayList Personas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona Persona1 = new Persona();

            Persona1.ID = "1010";
            Persona1.Nombres = "Emmy";
            Persona1.Apellidos = "Winehouse";
            Persona1.Correo = "Winehouse@gmail.com";
            Persona1.FechaNac = new DateTime(1983, 9, 14);
            Persona1.Salario = 1200000;
            Personas.Add(Persona1);

            Persona Persona2 = new Persona();
            Persona2.ID = "2020";
            Persona2.Nombres = "Freddy";
            Persona2.Apellidos = "Mercury";
            Persona2.Correo = "MercuryFreddy@gmail.com";
            Persona2.FechaNac = new DateTime(1946, 9, 5);
            Persona2.Salario = 2560000;
            Personas.Add(Persona2);

            dgvDatos.DataSource = Personas;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Debe ingresar el ID de la persona");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

            if (Existe(txtID.Text))
            {
                errorProvider1.SetError(txtID, "ID de Persona ya ha sido registrado");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");
        

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar el o los nombres de la persona");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar el o los apellidos de la persona");
                txtApellidos.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidos, "");

            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Debe ingresar una dirección de correo válida");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            decimal Salario;

            if (!Decimal.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar números en el campo salario");
                txtSalario.Focus();
                return;
            }

            if (Salario < 0)
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar números positivos");
                txtSalario.Focus();
                return;
            }

            Persona miPersona = new Persona();

            miPersona.ID = txtID.Text;
            miPersona.Nombres = txtNombres.Text;
            miPersona.Apellidos = txtApellidos.Text;
            miPersona.Correo = txtEmail.Text;
            miPersona.FechaNac = dtpFechaNac.Value;
            miPersona.Salario = Salario;
            Personas.Add(miPersona);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Personas;

            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtSalario.Clear();
            txtID.Focus();
        }

        private bool Existe(string ID)
        {
           foreach (Persona Persona in Personas)
           {
                if (Persona.ID == ID) return true;
           }
            return false;
        }
    }
}
