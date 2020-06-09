using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseProg101Escritura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stream fs = new FileStream("./archivoescritura.txt", FileMode.Create, FileAccess.Write);

            /* StreamWriter sw = new StreamWriter(fs);

             sw.WriteLine("Hola, esto es un archivo creado desde c#");

             sw.Close();

             fs.Close();*/

            //Cerrar automaticamente mediante un using 

            using (Stream fs = new FileStream("./archivoescritura.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Hola otra vez, esto es un archivo creado desde c#");
                }
            }

                Console.ReadKey();
        }
    }
}
