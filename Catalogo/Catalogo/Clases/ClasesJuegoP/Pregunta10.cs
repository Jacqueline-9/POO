using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta10 : CPreguntas //Clase Pregunta10 que hereda lo de la Clase CPreguntas 
    {
        public override string ResultadoCorrecto() //Métodos que heredan de la Clase CPreguntas, pero cada uno con una implementación distinta a las demás clases
        {
            return "Exacto, el texto dice que se cruzo con ellos, pero no que iban también a Villa Vieja";
        }
        public override string ResultadoIncorrecto()
        {
            return "El texto dice que se cruzo con ellos, pero no que iban también a Villa Vieja, por lo que ninguno iba a Villa Vieja";
        }
    }
}
