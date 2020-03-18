using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Triangulo : Figura
    {

        private double altura, ladoIz, ladoDe, lados;
        private string tipo;

        public double  Altura
        {
            set
            {
                altura = value;
            }
            get
            {
                return altura;
            }
        }
        public double LadoIz
        {
            set
            {
                ladoIz = value;
            }
            get
            {
                return ladoIz;
            }
        }
        public double LadoDe
        {
            set
            {
                ladoDe = value;
            }
            get
            {
                return ladoDe;
            }
        }
        public double Lados
        {
            set
            {
                lados = value;
            }
            get
            {
                return lados;
            }
        }
        public string Tipo
        {
            set
            {
                tipo = value;
            }
            get
            {
                return tipo;

            }
        }

        public override double CalArea()
        {
            Area = (Lado * altura) / 2;
            return Area;    
        }
        public override double CalPerimetro()
        {
            switch (Tipo)
            {
                case "Isosceles":
                    {
                        Perimetro = Lado + (lados * 2);
                        break;
                    }
                case "Escaleno":
                    {
                        Perimetro = Lado + LadoIz + ladoDe;
                        break;
                    }
                case "Equilatero":
                    {
                        Perimetro = Lado + Lado + Lado;
                        break;
                    }
            }
            
            return Area;   
        }
    }
}
