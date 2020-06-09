using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseProg101
{
    class Program
    {
        public static FileStream Stream { get; private set; }

        static void Main(string[] args)
        {
           Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);

           long quantity = fs.Length;    //Obtener el número de bytes 
           Console.WriteLine($"El archivo tiene una longitud de: {quantity} bytes");

            //For para leer desde el pricipio, byte 1 al byte n
            /*for (long count = 0; count < quantity; count++)
            {
                fs.Seek(count, SeekOrigin.Begin);
                int valor = fs.ReadByte();
                Console.WriteLine($"Posición {count}: {(char)valor}");
            }*/


            //for para leer del final al principio, byte n al byte 
            /*for (long count = quantity; count > 0; count--)
            {
                fs.Seek(-count, SeekOrigin.End);
                int valor = fs.ReadByte();
                Console.WriteLine($"Posición {count}: {(char)valor}");
            }*/


            //Leer mediante un bucle 
            /*int valor = 0;
            while (valor != 1)
            {
                valor = fs.ReadByte();

                if (valor != -1)
                    {
                        Console.WriteLine($"{(char)valor}");
                    }
             }*/

            //leer de mejor manera 
            fs.Seek(0, SeekOrigin.Begin);

            StreamReader sr = new StreamReader(fs);

            //linea
            //string line = sr.ReadLine();
            //Console.WriteLine(line);

            //Leer linea por linea 
            /* while (!sr.EndOfStream)
             {
                 Console.WriteLine(sr.ReadLine());
             }*/

            //leer todo el streams 
            string todo = sr.ReadToEnd();
            Console.WriteLine(todo);


            //Leer archivos grandes 
            /*using (Stream ms = new MemoryStream())
            {
                using (Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read))
                {
                    fs.CopyTo(ms);
                }

                ms.Seek(0, SeekOrigin.Begin);

                using (StreamReader sr = new StreamReader(ms))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }

                using (Stream fs = new FileStream("./archivo.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Hola");
                        sw.WriteLine("Otra vez");
                        sw.WriteLine("Y otra vez");
                    }
                }
            }*/

                //Cerrar el stream
                sr.Close();
                fs.Close();

            Console.ReadKey();
        }
    }
}
