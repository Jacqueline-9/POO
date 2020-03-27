using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta1 : CPreguntas //Clase Pregunta1 que hereda de la Clase CPreguntas
    {
        public override string ResultadoCorrecto() //Métodos que heredan de la clase CPreguntas, pero cada uno con una implementación distinta a las demás clases
        {
            return "¡Bien hecho! La Luna NO es de queso";
        } 
        public override string ResultadoIncorrecto()
        {
            return "La respuesta es No, ya que, la Luna  NO es de queso";
        }
    }
}
