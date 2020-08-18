using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Directorio d1 = new Directorio("Carpeta", 2);
            d1.AddFichero(new FicheroSencillo("f1.txt", 20));
            d1.AddFichero(new FicheroSencillo("f2.txt", 20));
            Directorio d2 = new Directorio("otra", 4);
            d1.AddFichero(d2);
            d2.AddFichero(new FicheroSencillo("Hola.txt", 5));
            d2.AddFichero(new FicheroSencillo("Hola2.txt", 5));
            d2.AddFichero(new FicheroSencillo("Hola3.txt", 5));
            foreach (Fichero f in d1.Ficheros) {
                Console.WriteLine(f.Nombre);
                if(f is Directorio)
                {
                    Directorio miDirectorio = (Directorio) f;
                    foreach (Fichero f2 in miDirectorio.Ficheros)
                    {
                        Console.WriteLine("|--- {0}", f2.Nombre);
                    }
                }
            }
                
            Console.ReadLine();            
        }
    }
}
