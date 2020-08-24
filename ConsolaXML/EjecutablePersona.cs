using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsolaXML
{
    class EjecutablePersona
    {
        static void Main(string[] args)
        {
            // EscribirFichero();
            BuscarPersonas();
            Console.ReadLine();
        }

        public static void EscribirFichero()
        {
            List<Persona> Personas = new List<Persona>();
            XmlDocument documento = new XmlDocument();
            XmlElement arbol = documento.CreateElement("Personas");
            documento.AppendChild(arbol);
            Personas.Add(new Persona("Ana", "Perez", 5));
            Personas.Add(new Persona("David", "Fernandez", 20));
            Personas.Add(new Persona("Juan", "Perez", 40));
            foreach (Persona p in Personas)
                arbol.AppendChild(p.AddPersona(documento));
            XmlWriter escritor = new XmlTextWriter("Personas.xml", null);
            documento.Save(escritor);
        }

        public static void BuscarPersonas()
        {
            List<Persona> Personas = Persona.BuscarPersonas();
            if (Personas.Count != 0)
                foreach (Persona p in Personas)
                    Console.WriteLine(p.ToString());
            else
                Console.WriteLine("No se encuentra nada");
        }
    }
}
