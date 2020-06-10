using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoElectricidad
{
    class ClassRecibo
    {
        //Atributos de la clase 
        public double kW, consumoelec;
        public string tipo;

        //Metodos de la clase 
        public void DeterminarConsumo()
        {
            switch (tipo)
            {
                case "Hogar":
                    {
                        if (kW > 0 & kW < 251)
                        {
                            consumoelec = kW * 0.65;
                        }
                        else if (kW > 250 & kW <= 500)
                        {
                            consumoelec = kW * 0.85;
                        }
                        else if (kW > 500 & kW <= 1200)
                        {
                            consumoelec = kW * 1.5;
                        }
                        else if (kW > 1200 & kW >= 2100)
                        {
                            consumoelec = kW * 2.5;
                        }
                        else
                        {
                            consumoelec = kW * 3;
                        }                    
                    }
                     break;

                case "Negocio":
                    {
                        consumoelec = kW * 5;
                        break;
                    }     
            }
        }
    }
}
