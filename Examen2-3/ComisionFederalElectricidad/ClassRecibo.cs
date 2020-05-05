using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComisionFederalElectricidad
{
    class ClassRecibo
    {
        //Atributos de la clase 
        public double KW, cantidadPagar;
        public string tipo;

        //Metodos de la clase 
        public void CalcularCantidadPagar()
        {
            switch (tipo)
            {
                case "Hogar":
                    {
                        if (KW >= 0 & KW <= 250)
                        {
                            cantidadPagar = KW * 0.65;
                        }
                        else if (KW > 250 & KW <= 500)
                        {
                            cantidadPagar = KW * 0.85;
                        }
                        else if (KW > 500 & KW <= 1200)
                        {
                            cantidadPagar = KW * 1.5;
                        }
                        else if( KW > 1200 & KW <= 2100)
                        {
                            cantidadPagar = KW * 2.5;
                        }
                        else if (KW > 2100)
                        {
                            cantidadPagar = KW * 3;
                        }
                        break;
                    }
                case "Negocio":
                    {
                        cantidadPagar = KW * 5;
                        break;
                    }
                    

            }
        }
    }
}
