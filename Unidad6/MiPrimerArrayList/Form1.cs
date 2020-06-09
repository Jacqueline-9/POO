using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        TextWriter archivo;
        string datosArchivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void tsbIngresar_Click(object sender, EventArgs e)
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

            archivo = new StreamWriter("archivo.txt");

            Persona miPersona = new Persona();

            miPersona.ID = txtID.Text;
            datosArchivo += "\n" + "IDE: " + miPersona.ID + "\n";

            miPersona.Nombres = txtNombres.Text;
            datosArchivo += "Nombres: " + miPersona.Nombres + "\n";

            miPersona.Apellidos = txtApellidos.Text;
            datosArchivo += "Apellidos: " + miPersona.Apellidos + "\n";

            miPersona.Correo = txtEmail.Text;
            datosArchivo += "Correo: " + miPersona.Correo + "\n";

            miPersona.FechaNac = dtpFechaNac.Value;
            datosArchivo += "Fecha de nacimiento: " + miPersona.FechaNac + "\n";

            miPersona.Salario = Salario;
            datosArchivo += "Salario: " + miPersona.Salario + "\n";

            Personas.Add(miPersona);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Personas;

            archivo.WriteLine(datosArchivo);
            archivo.Close();

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
