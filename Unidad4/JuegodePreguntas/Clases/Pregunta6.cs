using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    class Pregunta6 : CPreguntas //Clase Pregunta6 que hereda lo de la Clase CPregunta
    {
        public override string ResultadoCorrecto()//Métodos que heredan de la Clase CPregunta, pero cada uno con una implementación distinta a las demás clases
        {
            return "¡Excelente! El caballo de Napoleón no era blanco sino gris";
        }
        public override string ResultadoIncorrecto()
        {
            return "El caballo de Napoleón no era blanco sino gris";
        }
    }
}
