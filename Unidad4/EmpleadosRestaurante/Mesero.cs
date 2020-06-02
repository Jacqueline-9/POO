using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Mesero : Empleado
    {
        private double propinaSemanal;

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

        public override string CalcularSueldo()
        {
            Sueldo = Sueldo*DiasTrabajados + PropinaSemanal;
            return "El sueldo es de: " + Sueldo;
        }

    }
}
