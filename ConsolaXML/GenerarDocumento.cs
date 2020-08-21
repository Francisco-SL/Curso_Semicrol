using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsolaXML
{
    class GenerarDocumento
    {
        static void Main(string[] args)
        {
            //XmlDocument documento = new XmlDocument();
            //XmlElement ePersona = documento.CreateElement("Persona");
            //XmlElement eNombre = documento.CreateElement("Nombre");
            //XmlElement eApellidos = documento.CreateElement("Apellidos");
            //XmlElement eEdad = documento.CreateElement("Edad");
            //XmlWriter writer = new XmlTextWriter("persona.xml", null);
            //documento.AppendChild(ePersona);
            //ePersona.AppendChild(eNombre);
            //ePersona.AppendChild(eApellidos);
            //ePersona.AppendChild(eEdad);
            //eNombre.InnerText = "Pedro";
            //eApellidos.InnerText = "Garcia";
            //eEdad.InnerText = "18";
            //XmlAttribute atributo = documento.CreateAttribute("Telefono");
            //atributo.InnerText = "984847857";
            //ePersona.Attributes.Append(atributo);
            //documento.Save(writer);
            Personas();
            Console.ReadLine();
        }

        public static void Personas()
        {
            XmlDocument documento = new XmlDocument();
            XmlWriter writer = new XmlTextWriter("personas.xml", null);
            XmlElement ePersonas = documento.("Personas");
            XmlElement p1 = documento.CreateElement("Persona");
            XmlElement nombre1 = documento.CreateElement("Nombre");
            XmlElement apellidos1 = documento.CreateElement("Apellidos");
            XmlElement edad1 = documento.CreateElement("Edad");
            nombre1.InnerText = "Miguel";
            apellidos1.InnerText = "Garcia";
            edad1.InnerText = "30";
            p1.AppendChild(nombre1);
            p1.AppendChild(apellidos1);
            p1.AppendChild(edad1);

            XmlNode p2 = documento.CreateElement("Persona");
            XmlElement nombre2 = documento.CreateElement("Nombre");
            XmlElement apellidos2 = documento.CreateElement("Apellidos");
            XmlElement edad2 = documento.CreateElement("Edad");
            nombre2.InnerText = "Miguel";
            apellidos2.InnerText = "Garcia";
            edad2.InnerText = "30";
            p2.AppendChild(nombre2);
            p2.AppendChild(apellidos2);
            p2.AppendChild(edad2);

            documento.AppendChild(p1);
            documento.AppendChild(p2);


            documento.Save(writer);
        }
    }
}
