using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasDeVacaciones
{
    class ClassEmpleado
    {
        //Atributos de la clase
        public int aniosTrabajados, diasVacaciones;

        //Métodos de la clase 
        public void CalcularDias()
        {
            if (aniosTrabajados < 6)
            {
                diasVacaciones = 5;
            }
            else if (aniosTrabajados > 5 & aniosTrabajados <= 10)
            {
                diasVacaciones = 10;
            }
            else if (aniosTrabajados > 10 & aniosTrabajados <= 20)
            {
                diasVacaciones = aniosTrabajados;
            }
            else if (aniosTrabajados > 20 & aniosTrabajados < 33)
            {
                diasVacaciones = (aniosTrabajados + 10)+ 2;
            }
        }

    }
}
