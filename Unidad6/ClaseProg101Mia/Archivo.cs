using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseProg101Mia
{
    class Archivo
    {
        public void Leer()
        {
            Stream fs = new FileStream("./documento.txt", FileMode.Open, FileAccess.Read);

            long quantity = fs.Length;    //Obtener el número de bytes 
            Console.WriteLine($"El archivo tiene una longitud de: {quantity} bytes");

            fs.Seek(0, SeekOrigin.Begin);

            StreamReader sr = new StreamReader(fs);

            string todo = sr.ReadToEnd();
            Console.WriteLine(todo);

            sr.Close();
            fs.Close();
        }

        public void Aniadir()
        {
            using (Stream fs = new FileStream("./documento.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Hola");
                    sw.WriteLine("soy");
                    sw.WriteLine("Jacqueline");
                }
            }
        }

        public void Escribir()
        {
            using (Stream fs = new FileStream("./documentoescritura.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Hola, soy Jacqueline y escribo desde C#");
                }
            }

            Console.ReadKey();
        }
    }
}
