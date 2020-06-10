using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta5 : CPreguntas //Clase Pregunta5 que hereda lo de la Clase CPreguntas
    {
        public override string ResultadoCorrecto()//Métodos que heredan de la Clase CPreguntas, pero cada uno con una implementación distinta a las demás clases
        {
            return "¡Muy bien! La guerra de los 100 años duró 116 años";
        }
        public override string ResultadoIncorrecto()
        {
            return "La guerra de los 100 años duró 116 años";
        }
    }
}
