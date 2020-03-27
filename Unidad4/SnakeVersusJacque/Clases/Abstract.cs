using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeVersusJacque
{
    abstract class Abstract : Interface
    {
        private int x, y, ancho;

        public int Ancho { set; get;}
        public int X { set; get;}
        public int Y {set; get;}

        public Abstract()
        {
            Ancho = 10;
            X = 0;
            Y = 0;
        }

        public abstract Boolean Interseccion(Abstract O);
    }
}
