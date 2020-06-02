using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta11 : CPreguntas //Clase Pregunta11 que hereda lo de la Clase CPreguntas
    {
        public override string ResultadoCorrecto()//Métodos que heredan de la Clase CPreguntas, pero ya cada uno con una implementación distinta a las demás clases
        {
            return "¡Muy bien! la mitad de 2 + 2 es igual a 3";
        }
        public override string ResultadoIncorrecto()
        {
            return "La mitad de 2 es iugal a 1 + 2 es igual a 3, por lo que 3 es la respuesta correcta";
        }
    }
}
