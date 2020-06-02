using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosAlumnosDocentes
{
    public partial class DatosDocentes : Form
    {
        //Variable contador
        int cont = 1;

        //Objeto de la clase Docentes 
        Docentes Docente = new Docentes();

        public DatosDocentes()
        {
            InitializeComponent();

            //Tamaño de los arreglo
            Docente.Nombre = new string[102];
            Docente.FechaNac = new DateTime[102];
            Docente.Curp = new string[102];
            Docente.Telefono = new decimal[102];
            Docente.email = new string[102];
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

            //Validación de la caja de texto número del docente
            Regex reNumDocente = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumDocente.IsMatch(txtNumDoc.Text))
            {
                errorProvider1.SetError(txtNumDoc, "Ingrese números en el campo número de docente");
                txtNumDoc.Focus();
                return;
            }
            errorProvider1.SetError(txtNumDoc, "");

            //Validación de la cada de texto Sueldo
            decimal sueldo;

            if (!Decimal.TryParse(txtSueldo.Text, out sueldo))
            {
                errorProvider1.SetError(txtSueldo, "Ingrese números en el campo sueldo");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            if (sueldo < 0)
            {
                errorProvider1.SetError(txtSueldo, "Ingrese números positivos");
                txtSueldo.Focus();
                return;
            }

            //Validación de la caja de texto materias que imparte
            Regex reMImparte = new Regex("[a-zA-ZñÑ/s]", RegexOptions.Compiled);

            if (!reMImparte.IsMatch(txtMateriasImp.Text))
            {
                errorProvider1.SetError(txtMateriasImp, "Ingrese materia que imparte válida");
                txtMateriasImp.Focus();
                return;
            }
            errorProvider1.SetError(txtMateriasImp, "");

            //Condión que se cumplirá siempre y cuando, la longitud de los arreglos sea diferente de 102
            if (Docente.Nombre.Length != 102)
            {
                //las propiedades tomaran la posición que vaya indicando el contador 
                Docente.Nombre[cont] = txtNombre.Text;
                Docente.FechaNac[cont] = dtpFechaNac.Value;
                Docente.Curp[cont] = txtCurp.Text;
                Docente.Telefono[cont] = telefono;
                Docente.email[cont] = txtEmail.Text;
                Docente.NumeroMaes[cont] = int.Parse(txtNumDoc.Text);
                Docente.Sueldo[cont] = sueldo;
                Docente.MateriasImparte[cont] = txtMateriasImp.Text;

                //Método para limpiar el textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumDoc.Clear();
                txtSueldo.Clear();
                txtMateriasImp.Clear();
            }
            else
            {
                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                Docente.Nombre = new string[100];
                //Se indica la posición del arreglo
                Docente.Nombre[0] = txtNombre.Text;

                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                Docente.FechaNac = new DateTime[100];
                //Se indica la posición del arreglo
                Docente.FechaNac[0] = dtpFechaNac.Value;

                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                Docente.Curp = new string[100];
                //Se indica la posición del arreglo
                Docente.Curp[0] = txtCurp.Text;

                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                Docente.Telefono = new decimal[100];
                //Se indica la posición del arreglo
                Docente.Telefono[0] = telefono;

                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                Docente.email = new string[100];
                //Se indica la posición del arreglo
                Docente.email[0] = txtEmail.Text;

                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                Docente.NumeroMaes = new int[100];
                //Se indica la posición del arreglo
                Docente.NumeroMaes[0] = int.Parse(txtNumDoc.Text);

                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                Docente.Sueldo = new decimal[100];
                //Se indica la posición del arreglo
                Docente.Sueldo[0] = sueldo;

                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 10 y así, pueda entrar a la primera condición
                Docente.MateriasImparte = new string[100];
                //Se indica la posición del arreglo
                Docente.MateriasImparte[0] = txtMateriasImp.Text;

                //Método para limpiar los textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumDoc.Clear();
                txtSueldo.Clear();
                txtMateriasImp.Clear();
            }         
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            //Método para que se limpien las filas de datagridview
            dgvDatosDocentes.Rows.Clear();

            //Ciclo for que se cumplira siempre y cuando la variable i, sea menor a la 
            //Longitud del arreglo 
            for (int i = 0; i < Docente.Nombre.Length; i++)
            {
                //En caso de que el ciclo for se cumpla, entra a una condición que se cumplirá
                //siempre y cuando la posicion del arreglo Nombre se quede vacia, el arreglo telefono sea diferente a 0 
                if (Docente.Nombre[i] != "" && Docente.Telefono[i] != 0)
                {
                    //Agrega la posicion del arreglo al datagridview
                    dgvDatosDocentes.Rows.Add(Docente.Nombre[i], Docente.FechaNac[i], Docente.Curp[i], Docente.Telefono[i], Docente.email[i], Docente.NumeroMaes[i], Docente.Sueldo[i], Docente.MateriasImparte[i]);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salir del form
            this.Close();
        }
    }
}
