using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones2intento
{
    class ClassCalificaciones
    {
        //Atributos de la clase 
        public int calLeida = 0;
        public int aprobados = 0;
        public int reprobados = 0;
        int contador = 0;
        public double promedio = 0;
        int suma = 0;
        
        //Métodos para retornar promedio 
        public void capturarCalificación()     
        {
            if (calLeida >= 70)
            {
                aprobados = aprobados + 1;
                suma = suma + calLeida;
            }       
            else
            {
                reprobados = reprobados + 1;
                suma = suma + calLeida;
            }
            contador++;
            promedio = suma / contador;   
        }
    }
}
