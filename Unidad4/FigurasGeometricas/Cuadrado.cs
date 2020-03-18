using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Cuadrado : Figura
    {
        public override double CalArea()
        {
            Area = Lado * Lado;
            return Area; 
        }
        public override double CalPerimetro()
        {
            Perimetro = Lado * 4;
            return Perimetro; 
        }
    }
}
