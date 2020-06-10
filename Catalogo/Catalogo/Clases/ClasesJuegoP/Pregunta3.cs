using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta3 : CPreguntas //Clase Pregunta3 que hereda lo de la Clase CPreguntas
    {
        public override string ResultadoCorrecto() //Métodos que heredan de la Clase CPreguntas, pero cada uno con una implementación distinta a las demás clases 
        {
            return "¡Muy Bien! Se necesita una vela apagada, para poder prenderla";
        }
        public override string ResultadoIncorrecto()
        {
            return "La respuesta correcta es ´Ninguna de las anteriores´, debido a que, se necesita una vela apagada, para poder prenderla";
        }
    }
}
