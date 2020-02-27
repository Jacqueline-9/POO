using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadGradosCF
{
    class ClassTemperatura
    {
        //Atributos de la Clase
        public double grados;
        public string unidad;

        //Métodos de la Clase 
        public void ConvertirUnidad()
        {
            if (unidad == "Centígrados")
            {
                grados = (grados * 1.8000) + 32;
            }
            else
            {
                grados = (grados - 32) / 1.8000;
            }
        }
    }
}
