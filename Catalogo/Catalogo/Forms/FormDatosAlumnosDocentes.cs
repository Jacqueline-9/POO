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
    public partial class FormDatosAlumnosDocentes: Form
    {
        int cont = 1; 
        Alumnos1 Alumno = new Alumnos1();
        Docentes1 Docente = new Docentes1();

        public FormDatosAlumnosDocentes()
        {
            InitializeComponent();

            Alumno.Usuario = new string[102];
            Docente.Usuario = new string[102];

            cmbUsuario.Items.Add("Alumno");
            cmbUsuario.Items.Add("Docente");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Alumno.Usuario.Length!=102)
            {
                if (cmbUsuario.Text == "Alumno")
                {
                    //las propiedades tomaran la posición que vaya indicando el contador
                    Alumno.Usuario[cont] = cmbUsuario.Text;

                    //se crea un objeto del form Alumno
                    DatosAlumnos objAlumno = new DatosAlumnos();
                    //se llama al form alumno
                    objAlumno.Show();

                }
                else if (cmbUsuario.Text == "Docente")
                {
                    //las propiedades tomaran la posición que vaya indicando el contador
                    Docente.Usuario[cont] = cmbUsuario.Text;

                    //se crea un objeto del form Alumno
                    DatosDocentes objDocentes = new DatosDocentes();
                    //se llama al form alumno
                    objDocentes.Show();
                }

                cont++;
            }
            else
            {
                if (cmbUsuario.Text == "Alumno")
                {
                    //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                    Alumno.Usuario = new string[100];
                    //Se indica la posición del arreglo
                    Alumno.Usuario[0] = cmbUsuario.Text;

                    //se crea un objeto del form Alumno
                    DatosAlumnos objAlumno = new DatosAlumnos();
                    //se llama al form alumno
                    objAlumno.Show();
                }
                else if (cmbUsuario.Text == "Docente")
                {
                    //se incializa de nuevo el arreglo, pero ahora con un tamaño de 100 y así, pueda entrar a la primera condición
                    Docente.Usuario = new string[100];
                    //Se indica la posición del arreglo
                    Docente.Usuario[0] = cmbUsuario.Text;

                    //se crea un objeto del form Alumno
                    DatosDocentes objDocentes = new DatosDocentes();
                    //se llama al form alumno
                    objDocentes.Show();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salir del programa
            Close();
        }
    }
}
