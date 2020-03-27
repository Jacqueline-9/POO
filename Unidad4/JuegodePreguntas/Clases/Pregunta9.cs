using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta9 : CPreguntas //Clase Pregunta9 que hereda lo de la Clase CPregunta
    {
        public override string ResultadoCorrecto()//Métodos que heredan de la Clase CPregunta, pero cada uno con una implementación distinta a las demás clases 
        {
            return "¡Excelente! 8 * 11 = 88 + el primer numero = 96";
        }
        public override string ResultadoIncorrecto()
        {
            return "Si multiplicas el primer numero por el segundo y al resultado le sumas el primer número, se obtiene 96";
        }
    }
}
