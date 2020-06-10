using System;
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

namespace DatosAlumnoDocente
{
    public partial class FormDatosAlumnoDocenteAr : Form
    {
        //Objetos de las clases hijas
        AlumnosAr ObjAlumno = new AlumnosAr();
        DocentesAr ObjDocente = new DocentesAr();

        public FormDatosAlumnoDocenteAr()
        {
            InitializeComponent();

            //Elementos del combobox usuario
            cmbUsuario.Items.Add("Alumno");
            cmbUsuario.Items.Add("Docente");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Validación de caja de texto nombre
            Regex reNombre = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre válido");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            //Validación de la caja de texto curp
            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);

            if (!reCurp.IsMatch(txtCurp.Text))
            {
                errorProvider1.SetError(txtCurp, "Ingrese una curp válida");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");

            //Validación de la caja de texto teléfono
            decimal telefono;

            if (!Decimal.TryParse(txtTelefono.Text, out telefono))
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar números en el campo Teléfono");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            //Validación del correo 
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Ingrese una dirección de correo válida");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            //Condición, si en el combobox usuario, se introduce alumno,
            //Guardar los datos en las propiedades del objeto de la clase usuario
            if (cmbUsuario.Text == "Alumno")
            {
                ObjAlumno.Nombre = txtNombre.Text;
                ObjAlumno.FechaNac = dtpFechaNac.Value;
                ObjAlumno.Curp = txtCurp.Text;
                ObjAlumno.Telefono = telefono;
                ObjAlumno.email = txtEmail.Text;
                ObjAlumno.Usuario = cmbUsuario.Text;
                
                //se crea un objeto del form Alumno
                AlumnoAr objAlumno = new AlumnoAr();
                //se llama al form alumno
                objAlumno.Show();
            }

            //En caso de que en el combobox usuario, se introduce docente,
            //Guardar los datos en las propiedades del objeto de la clase docente
            if (cmbUsuario.Text == "Docente")
            {
                ObjDocente.Nombre = txtNombre.Text;
                ObjDocente.FechaNac = dtpFechaNac.Value;
                ObjDocente.Curp = txtCurp.Text;
                ObjDocente.Telefono = telefono;
                ObjDocente.email = txtEmail.Text;

                //se crea un objeto del form Docente
                DocenteAr objDocente = new DocenteAr();
                //se llama al form docente
                objDocente.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
