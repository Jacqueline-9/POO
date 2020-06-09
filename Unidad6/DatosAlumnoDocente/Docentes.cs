using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAlumnoDocente
{
    class Docentes : Persona
    {
        //Propiedades de la clase hija "Docentes"
        public int NumeroMaes { set; get; }
        public decimal Sueldo { set; get; }
        public string[] MateriasImparte;
    }
}
