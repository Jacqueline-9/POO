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
    public partial class Docente : Form
    {
        //Variable contador 
        int cont = 1;
        //Objeto de la clase Docentes 
        Docentes ObjDocente = new Docentes();

        TextWriter archivo;

        public Docente()
        {
            //Tamaño del arreglo
            ObjDocente.MateriasImparte = new string[102];

            InitializeComponent();
        }

        private void Docente_Load(object sender, EventArgs e)
        {
            archivo = new StreamWriter("archivo.txt");
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            //Validación de la caja de texto número del docente
            Regex reNumDocente = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumDocente.IsMatch(txtNumDoc.Text))
            {
                errorProvider1.SetError(txtNumDoc, "Ingrese números en el campo número de docente");
                txtNumDoc.Focus();
                return;
            }
            errorProvider1.SetError(txtNumDoc, "");

            //Variable que ayudará con la validación de la cada de texto sueldo
            decimal sueldo;

            //Validación de la cada de texto Sueldo
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

            //Condión que se cumplirá siempre y cuando, la longitud del arreglo sea diferente de 102
            if (ObjDocente.MateriasImparte.Length != 102)
            {
                ObjDocente.NumeroMaes = int.Parse(txtNumDoc.Text);
                ObjDocente.Sueldo = sueldo;
                //la propiedad tomará la posición que vaya indicando el contador 
                ObjDocente.MateriasImparte[cont] = txtMateriasImp.Text;

                //Método para limpiar el textbox 
                txtMateriasImp.Clear();
                //El contador incrementa de 1 en 1
                cont++;
            }
            //Sino se cumple la primera condición, entra a else
            else
            {
                ObjDocente.NumeroMaes = int.Parse(txtNumDoc.Text);
                ObjDocente.Sueldo = sueldo;
                //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                ObjDocente.MateriasImparte = new string[100];
                //Se indica la posición del arreglo
                ObjDocente.MateriasImparte[0] = txtMateriasImp.Text;

                //Método para limpiar el textbox
                txtMateriasImp.Clear();
            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            //Método para que se limpien las filas de datagridview
            dgvDocente.Rows.Clear();

            //Ciclo for que se cumplira siempre y cuando la variable i, sea menor a la 
            //Longitud del arreglo 
            for (int i = 0; i < ObjDocente.MateriasImparte.Length; i++)
            {
                //En caso de que el ciclo for se cumpla, entra a una condición que se cumplirá
                //siempre y cuando las posiciones del arreglo no queden vacias 
                if (ObjDocente.MateriasImparte[i] != "")
                {
                    //Agrega la posicion del arreglo al datagridview
                    dgvDocente.Rows.Add(ObjDocente.MateriasImparte[i]);

                    archivo.WriteLine("Materia: " + ObjDocente.MateriasImparte[i]);
                }
            }
            archivo.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salir del form
            this.Close();
        }

    }
}
