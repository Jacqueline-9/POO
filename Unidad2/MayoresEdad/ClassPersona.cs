using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayoresEdad
{
    class ClassPersona
    {
        //Atributos de la clase 
        public int diaN, diaA, mesN, mesA, anioN, anioA;
        public string mayorEdad;

       //Metodos de la clase 
       public void MayoresEdad()
        {
            if (anioA - anioN > 18)
            {
                mayorEdad = "Es Mayor de Edad";
            }
            else if (anioA - anioN == 18)
            {
                if (mesA > mesN)
                {
                    mayorEdad = "Es Mayor de Edad";
                }
                else if (mesA == mesN)
                {
                    if (diaA >= diaN)
                    {

                        mayorEdad = "Es Mayor de Edad";
                    }
                }
            }
           
        }
    }
}
