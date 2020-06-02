using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1Propuesto
{
    class Program
    {
        class Trabajador
        {
            public string nombre, apellidos, puestoTrabajo;
            public int numIdentificacion;
        }

        static void Main(string[] args)
        {
            int tamVector;

            Trabajador objTrabajador = new Trabajador();
            Console.Write("Trabajadores a Registrar: ");
            tamVector = int.Parse(Console.ReadLine());
            Trabajador[] vecTrabajador = new Trabajador[tamVector];

            for (int i=0; i < vecTrabajador.Length; i++ )
            {
                Console.Write("Nombres: ");
                objTrabajador.nombre = Console.ReadLine();
                Console.Write("Apellidos: ");
                objTrabajador.nombre = Console.ReadLine();
                Console.Write("Puesto de Trabajo: ");
                objTrabajador.nombre = Console.ReadLine();
                Console.Write("Número de Identificación: ");
                objTrabajador.nombre = Console.ReadLine();

                vecTrabajador[i] = objTrabajador;
            }
            Console.ReadKey();
        }
    }
}
