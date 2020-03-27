using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta2 : CPreguntas //Clase Pregunta2 que hereda lo de la Clase CPreguntas
    {
        public override string ResultadoCorrecto() //Métodos que heredan de la clase CPreguntas, pero cada uno con una implementación distinta a las demás clases
        {
            return "¡Muy bien! la caja de los aviones es color naranja";
        }
        public override string ResultadoIncorrecto()
        {
            return "¡Lo siento! La caja de los aviones es de color naranja";
        }
    }
}
