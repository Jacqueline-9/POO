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

namespace DatosAlumnosDocentesAr
{
    public partial class DatosAlumnosAr : Form
    {
        //Variable contador
        int cont = 1;

        //Objeto de la clase Alumnos 
        AlumnossAr Alumno = new AlumnossAr();

        TextWriter archivo;
        string datosArchivos;

        public DatosAlumnosAr()
        {
            //Tamaño de los arreglo
            Alumno.Nombre = new string[102];
            Alumno.FechaNac = new DateTime[102];
            Alumno.Curp = new string[102];
            Alumno.Telefono = new decimal[102];
            Alumno.email = new string[102];
            Alumno.NumControl = new int[102];
            Alumno.Carrera = new string[102];
            Alumno.Materia = new string[102];
            Alumno.Calificacion = new double[102];

            InitializeComponent();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
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

            //Validación de la caja de texto número de control
            Regex reNumControl = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumControl.IsMatch(txtNumControl.Text))
            {
                errorProvider1.SetError(txtNumControl, "Ingrese números en el campo número de control");
                txtNumControl.Focus();
                return;
            }
            errorProvider1.SetError(txtNumControl, "");

            //Validación de la caja de texto Carrera
            Regex reCarrera = new Regex("[a-zA-ZñÑ/s]", RegexOptions.Compiled);

            if (!reCarrera.IsMatch(txtCarrera.Text))
            {
                errorProvider1.SetError(txtCarrera, "Ingrese una carrera válida");
                txtCarrera.Focus();
                return;
            }
            errorProvider1.SetError(txtCarrera, "");

            //Validación de la caja de texto Materia
            Regex reMateria = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reMateria.IsMatch(txtMateria.Text))
            {
                errorProvider1.SetError(txtMateria, "Ingrese una materia válida");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            //Validación de la caja de texto calificación de la materia
            Regex reCalificacion = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (txtCalMateria.Text == "")
            {
                errorProvider1.SetError(txtCalMateria, "Ingrese una calificación válida");
                txtCalMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtCalMateria, "");

            archivo = new StreamWriter("archivo.txt");

            //Condión que se cumplirá siempre y cuando, la longitud de los arreglos sea diferente de 102
            if (Alumno.Nombre.Length != 102)
            {
                //las propiedades tomaran la posición que vaya indicando el contador 
                datosArchivos += "\n" + "Nombre: ";
                Alumno.Nombre[cont] = txtNombre.Text;
                datosArchivos += Alumno.Nombre[cont] + "\n";

                datosArchivos += "Fecha de nacimiento: ";
                Alumno.FechaNac[cont] = dtpFechaNac.Value;
                datosArchivos += Alumno.FechaNac[cont].ToString() + "\n";

                datosArchivos += "Curp: ";
                Alumno.Curp[cont] = txtCurp.Text;
                datosArchivos += Alumno.Curp[cont] + "\n";

                datosArchivos += "Teléfono: ";
                Alumno.Telefono[cont] = telefono;
                datosArchivos += Alumno.Telefono[cont].ToString() + "\n";

                datosArchivos += "Email: ";
                Alumno.email[cont] = txtEmail.Text;
                datosArchivos += Alumno.email[cont] + "\n";

                datosArchivos += "Número de control: ";
                Alumno.NumControl[cont] = int.Parse(txtNumControl.Text);
                datosArchivos += Alumno.NumControl[cont].ToString() + "\n";

                datosArchivos += "Carrera: ";
                Alumno.Carrera[cont] = txtCarrera.Text;
                datosArchivos += Alumno.Carrera[cont] + "\n";

                datosArchivos += "Materia: ";
                Alumno.Materia[cont] = txtMateria.Text;
                datosArchivos += Alumno.Materia[cont] + "\n";

                datosArchivos += "Calificación: ";
                Alumno.Calificacion[cont] = double.Parse(txtCalMateria.Text);
                datosArchivos += Alumno.Calificacion[cont].ToString() + "\n";

                //Método para limpiar el textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumControl.Clear();
                txtCarrera.Clear();
                txtMateria.Clear();
                txtCalMateria.Clear();
                //El contador incrementa de 1 en 1
                cont++;
            }
            //Sino se cumple la primera condición, entra a else
            else
            {
                //se incializa de nuevo el arreglo, pero ahora con un un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.Nombre = new string[100];
                //Se indica la posición del arreglo
                datosArchivos += "Nombre: ";
                Alumno.Nombre[0] = txtNombre.Text;
                datosArchivos += Alumno.Nombre[0] + "\n";

                //se incializa de nuevo el arreglo, pero ahora con un un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.FechaNac = new DateTime[100];
                //Se indica la posición del arreglo
                datosArchivos += "Fecha de nacimiento: ";
                Alumno.FechaNac[0] = dtpFechaNac.Value;
                datosArchivos += Alumno.FechaNac[0].ToString() + "\n";

                //se incializa de nuevo el arreglo, pero ahora con un un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.Curp = new string[100];
                //Se indica la posición del arreglo
                datosArchivos += "Curp: ";
                Alumno.Curp[0] = txtCurp.Text;
                datosArchivos += Alumno.Curp[0] + "\n";

                //se incializa de nuevo el arreglo, pero ahora con un un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.Telefono = new decimal[100];
                //Se indica la posición del arreglo
                datosArchivos += "Teléfono: ";
                Alumno.Telefono[0] = telefono;
                datosArchivos += Alumno.Telefono[0].ToString() + "\n";

                //se incializa de nuevo el arreglo, pero ahora con un un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.email = new string[100];
                //Se indica la posición del arreglo
                datosArchivos += "Email";
                Alumno.email[0] = txtEmail.Text;
                datosArchivos += Alumno.email[0] + "\n";

                //se incializa de nuevo el arreglo, pero ahora con un un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.NumControl = new int[100];
                //Se indica la posición del arreglo
                datosArchivos += "Número de control: ";
                Alumno.NumControl[0] = int.Parse(txtNumControl.Text);
                datosArchivos += Alumno.NumControl[0].ToString() + "\n";

                //se incializa de nuevo el arreglo, pero ahora con un un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.Carrera = new string[100];
                //Se indica la posición del arreglo
                datosArchivos += "Carrera: ";
                Alumno.Carrera[0] = txtCarrera.Text;
                datosArchivos += Alumno.Carrera[0] + "\n";

                //se incializa de nuevo el arreglo, pero ahora con un un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.Materia = new string[100];
                //Se indica la posición del arreglo
                datosArchivos += "Materia: ";
                Alumno.Materia[0] = txtMateria.Text;
                datosArchivos += Alumno.Materia[0] + "\n";

                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                Alumno.Calificacion = new double[100];
                //Se indica la posición del arreglo
                datosArchivos += "Calificación: ";
                Alumno.Calificacion[0] = double.Parse(txtCalMateria.Text);
                datosArchivos += Alumno.Calificacion[0].ToString() + "\n";

                //Método para limpiar los textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumControl.Clear();
                txtCarrera.Clear();
                txtMateria.Clear();
                txtCalMateria.Clear();
            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            //Método para que se limpien las filas de datagridview
            dgvDatosAlumno.Rows.Clear();

            //Ciclo for que se cumplira siempre y cuando la variable i, sea menor a la 
            //Longitud del arreglo 
            for (int i = 0; i < Alumno.Nombre.Length; i++)
            {
                //En caso de que el ciclo for se cumpla, entra a una condición que se cumplirá
                //siempre y cuando la posicion del arreglo Nombre se quede vacia, el arreglo telefono sea diferente a 0 
                if (Alumno.Nombre[i] != "" && Alumno.Telefono[i] != 0)
                {
                    //Agrega la posicion del arreglo al datagridview
                    dgvDatosAlumno.Rows.Add(Alumno.Nombre[i], Alumno.FechaNac[i].ToString(), Alumno.Curp[i], Alumno.Telefono[i], Alumno.email[i], Alumno.NumControl[i], Alumno.Carrera[i], Alumno.Materia[i], Alumno.Calificacion[i]);

                    //archivo.WriteLine(Alumno.Nombre[i] += Alumno.FechaNac[i] += Alumno.Curp[i] += Alumno.Telefono[i], Alumno.email[i], Alumno.NumControl[i], Alumno.Carrera[i], Alumno.Materia[i], Alumno.Calificacion[i]);
                }
            }
            archivo.WriteLine(datosArchivos);
            archivo.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
