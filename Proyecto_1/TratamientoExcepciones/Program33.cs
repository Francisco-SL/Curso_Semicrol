using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.TratamientoExcepciones
{
    class Program33
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(new Persona("Pepe", 30));
            listaPersonas.Add(new Persona("Juan", 40));
            listaPersonas.Add(new Persona("Maria", 10));
            listaPersonas.Add(new Persona("Andres", 50));
            var resultado = listaPersonas.Where((personita) => personita.Edad > 40);
            foreach (Persona p in resultado)
            {
                Console.WriteLine(p.Nombre);
            }
            Console.ReadLine();
        }
    }
}