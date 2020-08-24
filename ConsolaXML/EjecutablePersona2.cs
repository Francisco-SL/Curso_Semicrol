using System;
using System.Text;

namespace ConsolaXML
{
    class EjecutablePersona2
    {
        static void Main(string[] args)
        {
            StringBuilder cadena = new StringBuilder();
            for (int i=0; i<10000000;  i++)
            {
                cadena.Append("Hola");
                cadena.Append(i);
                cadena.Append("Adios");
                cadena.Append(i);
                cadena.Append("Hola2");
            }
            Console.WriteLine(cadena);
            Console.WriteLine("Termino");
            Console.ReadLine();
        }       
    }
}