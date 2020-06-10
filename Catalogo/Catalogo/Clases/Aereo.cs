using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehículos
{
    class Aereo : Vehiculos
    {
        public int numTurbinas, numAlas, numHelices;
        public string tipoAereo, estado;

        public Aereo()
        {
            numAlas = 0;
            numTurbinas = 0;
            numHelices = 0;
            tipoAereo = "";
        }

        public string enVuelo()
        {
            estado = " Volando";
            return "El " + tipoAereo + " está " + estado;
        }
    }
}
