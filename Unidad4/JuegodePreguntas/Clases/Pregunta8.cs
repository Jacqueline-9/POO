using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta8 : CPreguntas //Clase Pregunta8 que hereda lo de la Clase CPreguntas
    {
        public override string ResultadoCorrecto()//Métodos que heredan de la Clase CPreguntas, pero cada uno con una implementación distinta a las demás clases 
        {
            return "¡Muy bien! Las máquinas también tardarian 5 minutos";
        }
        public override string ResultadoIncorrecto()
        {
            return "Las 100 maquinas también tardarían 5 minutos, por lo que tu respueta es incorrecta :c";
        }
    }
}
