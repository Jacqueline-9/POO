using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_FCD
{
    class MatrizFCD
    {
        public int[,] Bidi { set; get; }
        public int[] SumFilas { set; get; }
        public int[] SumColumnas { set; get; }
        public int[] Diagonal { set; get; }


        public void SumaFilas()
        {
            for (int f = 0; f < SumFilas.Length; f++)
            {
                int suma = 0;
                int acum = 0;

                for (int c = 0; c < SumFilas.Length; c++)
                {
                    suma = Bidi[c, f];
                    acum += suma;
                }
                SumFilas[f] = acum;
            }
        }

        public void SumaColumnas()
        {
            for (int f = 0; f < SumColumnas.Length; f++)
            {
                int suma = 0;
                int acum = 0;

                for (int c = 0; c < SumColumnas.Length; c++)
                {
                    suma = Bidi[f, c];
                    acum += suma;
                }
                SumColumnas[f] = acum;
            }
        }

        public string SumaDiagonal()
        {
            string sumaDiagonal = "";
            int acum = 0;

            for (int f = 0; f < Diagonal.Length; f++)
            {
                int suma = 0;

                for (int c = 0; c < Diagonal.Length; c++)
                {
                    if (f == c)
                    {
                        suma = Bidi[f, c];
                        acum += suma;
                    }
                }
                Diagonal[f] = acum;
            }
            sumaDiagonal = acum.ToString();
            return sumaDiagonal;
        }
    }
}
