using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasetaAutopista
{
    class ClassVehículo
    {
        //Atrinutos de la clase 
        public int cantidadCobrar;
        public string tipoVehiculo;

        //Metodos de la clase 
        public void CalcularCantidadCobrar()
        {
            switch (tipoVehiculo)
            {
                case "Motociclista":
                    {
                        cantidadCobrar = 50;
                        break;
                    }
                case "Automóvil":
                    {
                        cantidadCobrar = 112;
                            break;
                    }
                case "Autobús":
                    {
                        cantidadCobrar = 170;
                        break;
                    }
                default:
                    {
                        cantidadCobrar = 250;
                        break;
                    }
            }
        }
    }
}
