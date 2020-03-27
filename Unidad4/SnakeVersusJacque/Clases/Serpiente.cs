using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeVersusJacque
{
    class Serpiente : Papa
    {
        Serpiente cola;

        public Serpiente(int x, int y)
        {
            this.X = x;
            this.Y = y;
            cola = null;
        }

        public void Dibujar(Graphics g)
        {
            if (cola != null )
            {
                cola.Dibujar(g);
            }
            g.FillRectangle(new SolidBrush(Color.Crimson), this.X, this.Y, this.Ancho, this.Ancho);
        }
        public void  setxy( int x, int y)
        {
            if (cola != null)
            {
                cola.setxy(this.X, this.Y);
            }
            this.X = x;
            this.Y = y;
        }

        public void Siguiente()
        {
            if (cola == null)
            {
                cola = new Serpiente(this.X, this.Y);
            }
            else
            {
                cola.Siguiente();

            }
        }
        public Serpiente VerSiguiente()
        {
            return cola;
        }

        public int VerX()
        {
            return this.X;
        }
        public int VerY()
        {
            return this.Y;
        }
    }
}
