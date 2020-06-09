using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAlumnoDocente
{
    class Alumnos : Persona
    {
        //Propiedades de la clase hija "Alumnos"
        public int NumControl { set; get; }
        public string Carrera { set; get; }
        public string[] Materia;
        public double[] Calificacion;
    }
}
