using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegodePreguntas
{
    interface IPreguntas //Interface del programa 
    {
        string ResultadoCorrecto(); //Método que heredaran las demás clases
        string ResultadoIncorrecto();//Método que heredaran las demás clases 
    }
}
