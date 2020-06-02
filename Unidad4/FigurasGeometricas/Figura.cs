using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    abstract class Figura
    {
        /*Atributos de la clase*/
        private double lado, area, perimetro;

        /*Constructor*/
        public Figura()
        {
            lado = 0;
            area = 0;
            perimetro = 0;
        }

        /*Setters y getters*/
        public double Lado
        {
            set
            {
                lado = value;
            }
            get
            {
                return lado;
            }
        }

        public double Area
        {
            set
            {
                area = value;
            }
            get
            {
                return area;
            }
        }

        public double Perimetro
        {
            set
            {
                perimetro = value;
            }
            get
            {
                return perimetro;
            }
        }

        /*Metodos de la clase*/
        public abstract double CalArea();
        public abstract double CalPerimetro();
    }
}
