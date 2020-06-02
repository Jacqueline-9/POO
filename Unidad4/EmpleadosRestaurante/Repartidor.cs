using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Repartidor : Empleado
    {
        private double propinaSemanal, abonosCobrados;
        private String zonaRepartir;

        public double PropinaSemanal
        {
            set
            {
                propinaSemanal = value;
            }
            get
            {
                return propinaSemanal;
            }
        }

        public double AbonosCobrados
        {
            set
            {
                abonosCobrados = value;
            }
            get
            {
                return abonosCobrados;
            }
        }

        public String ZonaRepartir
        {
            set
            {
                zonaRepartir = value;
            }
            get
            {
                return zonaRepartir;
            }
        }

        public override string CalcularSueldo()
        {
            if ( zonaRepartir == "1")
            {
                Sueldo = (DiasTrabajados*Sueldo) + (5 * abonosCobrados);
            }
            else
            {
                Sueldo = (DiasTrabajados*Sueldo) + (2 * abonosCobrados);
            }
            return "El sueldo es: " + Sueldo;
        }
    }
}
