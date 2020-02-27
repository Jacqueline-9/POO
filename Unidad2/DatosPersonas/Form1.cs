using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosPersonas
{
    public partial class Form1 : Form
    {
        ClassPersona objPersona = new ClassPersona();

        public Form1()
        {
            InitializeComponent();

            cmbEstadoN.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbEstadoN.Items.Add("Aguascalientes");
            cmbEstadoN.Items.Add("Baja California");
            cmbEstadoN.Items.Add("Baja California Sur");
            cmbEstadoN.Items.Add("Campeche");
            cmbEstadoN.Items.Add("Chiapas");
            cmbEstadoN.Items.Add("Chihuahua");
            cmbEstadoN.Items.Add("Coahuila");
            cmbEstadoN.Items.Add("Colima");
            cmbEstadoN.Items.Add("Distrito Federal");
            cmbEstadoN.Items.Add("Durango");
            cmbEstadoN.Items.Add("Estado de México");
            cmbEstadoN.Items.Add("Jalisco");
            cmbEstadoN.Items.Add("Michoacán");
            cmbEstadoN.Items.Add("Morelos");
            cmbEstadoN.Items.Add("Nayarit");
            cmbEstadoN.Items.Add("Nuevo León");
            cmbEstadoN.Items.Add("Oaxaca");
            cmbEstadoN.Items.Add("Puebla");
            cmbEstadoN.Items.Add("Querétaro");
            cmbEstadoN.Items.Add("Quintana Roo");
            cmbEstadoN.Items.Add("San Luis Potosí");
            cmbEstadoN.Items.Add("Sinaloa");
            cmbEstadoN.Items.Add("Sonora");
            cmbEstadoN.Items.Add("Tabasco");
            cmbEstadoN.Items.Add("Tamaulipas");
            cmbEstadoN.Items.Add("Tlaxcala");
            cmbEstadoN.Items.Add("Veracruz");
            cmbEstadoN.Items.Add("yucatán");
            cmbEstadoN.Items.Add("Zacatecas");
            cmbTipo.Items.Add("Alumno");
            cmbTipo.Items.Add("Maestro");
            cmbTipo.Items.Add("Administrativo");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            frmInforme informe = new frmInforme();
            informe.txtMayorEdad.Text = objPersona.contadorMayoresEdad.ToString();
            informe.txtPersonasNay.Text = objPersona.contadorestadoNay.ToString();
            informe.txtAlumnos.Text = objPersona.contadorAlumno.ToString();
            informe.txtMaestros.Text = objPersona.contadorMaestro.ToString();
            informe.txtAdministrativos.Text = objPersona.contadorAdministrativo.ToString();
            informe.Show();

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Introduzca su nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtApPaterno.Text == "")
            {
                errorProvider1.SetError(txtApPaterno, "Introduzca su apellido paterno");
                txtApPaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApPaterno, "");

            if (txtApMaterno.Text == "")
            {
                errorProvider1.SetError(txtApMaterno, "Introduzca su apellido materno");
                txtApMaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApMaterno, "");

            if (cmbEstadoN.Text == "")
            {
                errorProvider1.SetError(cmbEstadoN, "Seleccione su estado de nacimiento");
                cmbEstadoN.Focus();
                return;
            }
            errorProvider1.SetError(cmbEstadoN, "");

            if (cmbTipo.Text == "")
            {
                errorProvider1.SetError(cmbTipo, "Seleccione tipo");
                cmbTipo.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipo, "");

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "Introduzca su número de teléfono");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            objPersona.nombreM = txtNombre.Text;
            objPersona.apPaternoM = txtApPaterno.Text;
            objPersona.apMaternoM = txtApMaterno.Text;
            objPersona.RegistrarPersona();
            txtNombre.Text = objPersona.nombre.ToString();
            txtApPaterno.Text = objPersona.apPaterno.ToString();
            txtApMaterno.Text = objPersona.apMaterno.ToString();

            objPersona.anioA = int.Parse(DateTime.Today.Year.ToString());
            objPersona.mesA = int.Parse(DateTime.Today.Month.ToString());
            objPersona.diaA = int.Parse(DateTime.Today.Day.ToString());
            objPersona.anioN = int.Parse(dtpFechaNacimiento.Value.Year.ToString());
            objPersona.mesN = int.Parse(dtpFechaNacimiento.Value.Month.ToString());
            objPersona.diaN = int.Parse(dtpFechaNacimiento.Value.Day.ToString());
   
            objPersona.MayoresEdad();
            objPersona.estadoN = cmbEstadoN.Text;
            objPersona.contabilizarEstadoNay();
            objPersona.tipo = cmbTipo.Text;
            objPersona.ContabilizarTipo();
            cmbTipo.Text = objPersona.tipo.ToString();

            MessageBox.Show("Los datos se registraron correctamente");

            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            dtpFechaNacimiento.Text = "";
            cmbEstadoN.Text = "";
            cmbTipo.Text = "";
            txtTelefono.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
