using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    interface Bebida
    {
        string Alcohol { set; get; }
        string Marca { set; get; }
        int Cantidad { set; get; }
        int SobranteFaltante { set; get; }
        int NuevaCantidad { set; get; }
        int SumaV { set; get; }
        int SumaC { set; get; }

        void sumar();
        void Llenar();
        string Mostrar();
    }
}
