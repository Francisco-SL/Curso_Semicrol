using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaSemicrol;
using Proyecto_1.Clases;
using Proyecto_1.EmpresaAlquiler;

namespace Proyecto_1
{
    class Program22
    {
        static void Main(string[] args)
        {
            Dictionary<string, Persona> diccionario = new Dictionary<string, Persona>();
            Persona p1 = new Persona();
            p1.Nombre = "Pedro";
            p1.Apellidos = "Gomez";
            p1.Edad = 50;
            Persona p2 = new Persona();
            p2.Nombre = "Ana";
            p2.Apellidos = "Perez";
            p2.Edad = 25;
            Persona p3 = new Persona();
            p3.Nombre = "Miguel";
            p3.Apellidos = "Garcia";
            p3.Edad = 33;
            diccionario.Add(p1.Nombre, p1);
            diccionario.Add(p2.Nombre, p2);
            diccionario.Add(p3.Nombre, p3);
            Console.WriteLine("Apellidos de Pedro: {0}", diccionario["Pedro"].Apellidos);
            Console.WriteLine("Personas en el diccionario:");
            foreach (Persona p in diccionario.Values)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Claves en el diccionario");
            foreach (String clave in diccionario.Keys)
            {
                Console.WriteLine(clave);
            }
            //Telefono t;
            Console.ReadLine();
        }
    }
}
