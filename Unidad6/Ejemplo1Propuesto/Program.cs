using System;
using System.Collections.Generic;
using System.IO;
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

            TextWriter archivo;
            string datosArchivos;

            archivo = new StreamWriter("archivo.txt");

            Trabajador objTrabajador = new Trabajador();
            Console.Write("Trabajadores a Registrar: ");
            tamVector = int.Parse(Console.ReadLine());
            Trabajador[] vecTrabajador = new Trabajador[tamVector];

            for (int i = 0; i < vecTrabajador.Length; i++)
            {
                Console.Write("Nombres: ");
                objTrabajador.nombre = Console.ReadLine();

                Console.Write("Apellidos: ");
                objTrabajador.apellidos = Console.ReadLine();

                Console.Write("Puesto de Trabajo: ");
                objTrabajador.puestoTrabajo = Console.ReadLine();

                Console.Write("Número de Identificación: ");
                objTrabajador.numIdentificacion = Convert.ToInt32(Console.ReadLine());

                vecTrabajador[i] = objTrabajador;

                archivo.WriteLine("Nombres: " + vecTrabajador[i].nombre + "\n" + "Apellidos: " + vecTrabajador[i].apellidos + "\n" +
                "Puesto de trabajo: " + vecTrabajador[i].puestoTrabajo + "\n" + "Número de identificación: " + 
                vecTrabajador[i].numIdentificacion + "\n");

            }

            Console.ReadKey();
            archivo.Close();
        }
    }
}
