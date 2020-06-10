using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto
{
    class ClassAsistente
    {
        //Atrutos de la clase 
        public string asistente;
        public int cantidad;
        //Variables para metodos 
        public int bebes = 0;
        public int ninos = 0;
        public int adultos = 0;
        public int adultoma = 0;

        //Metodos de la clase 
        public void ContabilizarAsistentes()

        {

            switch (asistente)
            {
                case "Bebés":
                    bebes = bebes += cantidad;
                    break;
                case "Niños":
                    ninos = ninos += cantidad;
                    break;
                case "Adultos":
                    adultos = adultos += cantidad;
                    break;
                case "Adultos Mayores":
                    adultoma = adultoma += cantidad;
                    break;
            }

        }
    }
}
