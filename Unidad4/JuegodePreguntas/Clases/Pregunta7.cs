using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta7 : CPreguntas //Clase Pregunta7 que hereda lo de la Clase CPreguntas
    {
        public override string ResultadoCorrecto() //Métodos que heredan de la Clase CPreguntas, pero cada uno con una implementación distinta a las demás clases
        {
            return "Si aun número le sumas el 25% y para que vuelva a ser el mismo número de antes tendrás que quitarleel 20%";
        }
        public override string ResultadoIncorrecto()
        {
            return "Si aun número le sumas el 25% y para que vuelva a ser el mismo número de antes tendrás que quitarleel 20%, por lo tanto, la respuesta correcta es 20%";
        }
    }
}
