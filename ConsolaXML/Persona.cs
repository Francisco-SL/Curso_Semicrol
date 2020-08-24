using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsolaXML
{
    class Persona
    {
        public Persona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public Persona()
        {

        }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public override string ToString() => Nombre + " " + Apellidos + ", " + Edad;

        public XmlElement AddPersona(XmlDocument documento)
        {
            XmlElement Persona = documento.CreateElement("Persona");
            XmlElement eNombre = documento.CreateElement("Nombre");
            XmlElement eApellidos = documento.CreateElement("Apellidos");
            XmlElement eEdad = documento.CreateElement("Edad");
            eNombre.InnerText = Convert.ToString(Nombre);
            eApellidos.InnerText = Convert.ToString(Apellidos);
            eEdad.InnerText = Convert.ToString(Edad);
            Persona.AppendChild(eNombre);
            Persona.AppendChild(eApellidos);
            Persona.AppendChild(eEdad);
            return Persona;
        }

        public static List<Persona> BuscarPersonas()
        {
            List<Persona> Personas = new List<Persona>();
            XmlReader lector = new XmlTextReader("Personas.xml");
            Persona p= new Persona();
            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Element)
                {
                    
                    if (lector.Name.Equals("Nombre"))
                    {
                        lector.Read();
                        p.Nombre = lector.Value;
                    }
                    else if (lector.Name.Equals("Apellidos"))
                    {
                        lector.Read();
                        p.Apellidos = lector.Value;
                    }
                    else if (lector.Name.Equals("Edad"))
                    {
                        lector.Read();
                        p.Edad = Convert.ToInt32(lector.Value);
                        Personas.Add(p);
                        p = new Persona();
                    }
                }
            }
            return Personas;
        }

    }
}
