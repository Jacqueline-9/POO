using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeVersusJacque
{
    class Comida : Papa
    {
       public Comida()
       {
            this.X = ComidaAleatoria(36);
            this.Y = ComidaAleatoria(25);
       }
        public void Dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), this.X, this.Y, this.Ancho, this.Ancho);
        }
        public int ComidaAleatoria(int n)
        {
            Random random = new Random();
            int rango = random.Next(0, n)* 10;
            return rango;
        }  
        public void NuevaPosicion()
        {
            this.X = ComidaAleatoria(36);
            this.Y = ComidaAleatoria(25);
        }

    }
}
