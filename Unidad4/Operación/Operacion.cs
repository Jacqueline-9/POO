using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operación
{
    class Operacion
    {
        // Atributos de la clase 
        private double valor1, valor2, resultado;

        /*Constructor de la clase */
         public Operacion()
         {
             valor1 = 0;
             valor2 = 0;
             resultado = 0;
         }

        /*Setter y getters*/
        public double Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }

        public double Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }

        public double Resultado
        {
            set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
        
         /*Metodos de la clase */
        public string ImprimirValor1()
         {
           return "El valor 1 es: " + valor1;
         }
        public string ImprimirValor2()
        {
            return "El valor 2 es: " + valor2;
        }
    }
}
