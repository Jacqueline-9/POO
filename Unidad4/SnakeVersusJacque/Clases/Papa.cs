using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeVersusJacque
{
    class Papa : Abstract
    {


        public override bool Interseccion(Abstract O)
        {
            int difx = Math.Abs(this.X - O.X);
            int dify = Math.Abs(this.Y - O.Y);

            if(difx >= 0 &&  difx < Ancho && dify >= 0 && dify < Ancho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
