using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeVersusJacque
{
    interface Interface
    {
         int Ancho { set; get; }
         int X { set; get; }
         int Y { set; get; }

        Boolean Interseccion(Abstract O);
    }
}
