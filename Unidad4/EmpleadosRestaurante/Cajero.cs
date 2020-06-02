using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Cajero : Empleado
    {
        private string numeroCaja;

        public string NumeroCaja
        {
            set
            {
                numeroCaja = value;
            }
            get
            {
                return numeroCaja;
            }
        }

        public override string CalcularSueldo()
        {
            if (numeroCaja == "2")
            {
                Sueldo = (((3 * Sueldo) / 100) + Sueldo) * DiasTrabajados;
            }
            else
            {
                Sueldo = (DiasTrabajados * Sueldo);
            }
            return "El sueldo es de : " + Sueldo;
        }
    }
}
