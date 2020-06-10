using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta4 : CPreguntas //Clase Pregunta4 que hereda lo de la Clase CPreguntas
    {
        public override string ResultadoCorrecto()//Métodos que heredan de la Clase CPreguntas, pero cada uno con una implementación distinta a las demás clases 
        {
            return "¡Excelente! Jueves antes que miércoles se encuentra, en el Diccionario";
        }
        public override string ResultadoIncorrecto()
        {
            return "Jueves antes que miércoles se encuentra EN EL DICCIONARIO, por lo que, la respuesta correcta es ´En otro lugar´";
        }      
    }
}
