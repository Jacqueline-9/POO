using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operación
{
    class Multiplicacion : Operacion
    {
        public void Multiplicar()
        {
           Resultado = Valor1 * Valor2;
        }
    }
}
