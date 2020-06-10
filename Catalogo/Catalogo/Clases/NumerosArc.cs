using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumMayMen
{
    class NumerosArc
    {
        public int Mayor { set; get; }
        public int Menor { set; get; }
        public int[] arregloNum { set; get; }

        public string MayorMenor()
        {
            Menor = 10000000;
            Mayor = -1000000;
            string mayormenor = "";

            for (int i = 0; i < arregloNum.Length; i++)
            {
                if (arregloNum[i] > Mayor)
                {
                    Mayor = arregloNum[i];
                }
            }
            for (int i = 0; i < arregloNum.Length; i++)
            {
                if (arregloNum[i] < Menor)
                {
                    Menor = arregloNum[i];
                }
            }
            mayormenor = "El número mayor es: " + Mayor + "\n" + "El número menor es: " + Menor;
            return mayormenor;
        }
    }
}
