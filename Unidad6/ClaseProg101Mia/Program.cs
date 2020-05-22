using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseProg101Mia
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo objArchivo = new Archivo();

            objArchivo.Leer();
            objArchivo.Aniadir();
            objArchivo.Escribir();
        }
    }
}
