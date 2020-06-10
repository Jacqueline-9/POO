using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimetroCuadrado
{
    class ClassCuadrado
    {
        //Atributos de la Clase 
        public int lado, area, perimetro;

        //Metodos de la clase 
        public void CalcularArea()
        {
            area = lado * lado;
        }
        public void CalcularPerimetro()
        {
            perimetro = lado * 4;
        }
    }
}
