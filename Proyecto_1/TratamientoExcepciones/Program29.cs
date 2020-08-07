using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.TratamientoExcepciones
{
    class Program29
    {
        static void Main(string[] args)
        {
            string path = @"c:\Ficheros\MiDocumento.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path)) //se encarga de cerrar cualquier flujo, sin necesidad de usar el metodo Close()
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {
                //   Console.WriteLine("No se encuentra el directorio");
                Console.WriteLine(e.Message);
                // Console.WriteLine(e.StackTrace);
            }
            catch (FileNotFoundException e)
            {
                //   Console.WriteLine("No se encuentra el fichero");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
