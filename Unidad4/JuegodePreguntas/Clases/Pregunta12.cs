using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta12 : CPreguntas //Clase Pregunta12 que hereda lo de la Clase CPreguntas
    {
        public override string ResultadoCorrecto() //Métodos que heredan de la clase CPreguntas, pero cada uno con una implementación distinta a las demás clases
        {
            return "¡Muy bien! 3 + 3 + 3 = 1";
        }
        public override string ResultadoIncorrecto()
        {
            return "3 = 1, por lo que 1 + 1 + 1 = 3, pere 3 = 1";
        }
    }
}
