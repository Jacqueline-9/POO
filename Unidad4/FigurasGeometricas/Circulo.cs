using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Circulo : Figura
    {
   
        public override double CalArea()
        {
            Area = (3.2416) * (Lado * Lado);
            return Area;  
        }
        public override double CalPerimetro()
        {
            Perimetro = ((3.1416 * 2) * Lado);
            return Perimetro;
        }
    }
}
