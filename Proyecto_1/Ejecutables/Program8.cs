using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program8
    {
        static void Main(string[] args)
        {
            //Persona p1 = new Persona("Pedro", "Gomez", 18);
            Persona p1 = new Persona();
            p1.Nombre = "Pedro";
            p1.Apellidos = "Alvarez";
            p1.Edad = 20;
            Console.WriteLine("Nombre: " + p1.Nombre);
            Console.WriteLine("Apellidos: " + p1.Apellidos);
            Console.WriteLine("Edad: " + p1.Edad);
            Console.WriteLine("Tiempo para jubilarse: " + p1.TiempoParaJubilarse() + " años");
            Console.ReadLine();
        }
    }
}
