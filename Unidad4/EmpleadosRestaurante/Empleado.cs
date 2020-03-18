using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    abstract class Empleado
    {
        private string nombre;
        private double diasTrabajados, sueldo;
        private int fechaNacimiento;

        public Empleado()
        {
            nombre = "";
            diasTrabajados = 0;
            sueldo = 0;
            fechaNacimiento = 0;
        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public double DiasTrabajados
        {
            set
            {
                diasTrabajados = value;
            }
            get
            {
                return diasTrabajados;

            }
        }

        public double Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;

            }
        }

        public int FechaNacimiento
        {
            set
            {
                fechaNacimiento = value;
            }
            get
            {
                return fechaNacimiento;
            }
        }

        public abstract string CalcularSueldo();
    }
}
