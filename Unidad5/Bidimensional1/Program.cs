using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidimensional1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Estilo Pascal 

            // 2 bloques (filas) de 2 datos (Columnas)
            int[,] notas1 = new int[2, 2]; 
            notas1[0, 0] = 1;
            notas1[0, 1] = 2;
            notas1[1, 0] = 3;
            notas1[1, 1] = 4;

            // 2 blosques de 10 datos
            int[,] notas2 = { { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 } };

            Console.WriteLine("La nota1 del segundo alumno del grupo 1 es {0}", notas1[0,1]);

            Console.WriteLine("La nota2 del tercer alumno del grupo 1 es {0}", notas2[0,2]);

            Console.ReadLine();
        }
    }
}
