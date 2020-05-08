using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilasColumnasDiagonal
{
    class Arreglos
    {
        public int[,] Bidimensional { set; get; }
        public int[] SumFilas { set; get; }
        public int[] SumColumnas { set; get; }
        public int[] Diagonal { set; get; }


        public void SumaFilas()
        {
            for (int f = 0; f < Bidimensional.GetLength(0); f++)
            {
                int suma = 0;
                int acum = 0;

                for (int c = 0; c < Bidimensional.GetLength(1); c++)
                {
                    suma = Bidimensional[c, f];
                    acum += suma;
                }
                SumFilas[f] = acum;
            }
        }

        public void SumaColumnas()
        {

            for (int f = 0; f < Bidimensional.GetLength(0); f++)
            {
                int suma = 0;
                int acum = 0;

                for (int c = 0; c < Bidimensional.GetLength(1); c++)
                {
                    suma = Bidimensional[f, c];
                    acum += suma;
                }
                SumColumnas[f] = acum;
            }
        }

        public string SumaDiagonal()
        {
            string sumaDiagonal = "";
            int acum = 0;

            for (int f = 0; f < Bidimensional.GetLength(0); f++)
            {
                int suma = 0;

                for (int c = 0; c < Bidimensional.GetLength(1); c++)
                {
                    if (f == c)
                    {
                        suma = Bidimensional[f, c];
                        acum += suma;
                    }
                }
            }
            sumaDiagonal = acum.ToString();
            return sumaDiagonal;
        }

    }
}
