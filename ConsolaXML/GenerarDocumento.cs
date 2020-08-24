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
            XmlDocument documento = new XmlDocument();
            XmlElement arbol =documento.CreateElement("personas");
            XmlElement elemento = documento.CreateElement("persona");
            XmlElement elemento2 = documento.CreateElement("persona");

            documento.AppendChild(arbol);
            arbol.AppendChild(elemento);
            arbol.AppendChild(elemento2);
            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = "pedro";
            elemento.AppendChild(nombre);

            XmlAttribute attributo = documento.CreateAttribute("telefono");
            attributo.InnerText = "123456";
            elemento.Attributes.Append(attributo);
            XmlElement apellidos = documento.CreateElement("apellidos");
            apellidos.InnerText = "alvarez";
            elemento.AppendChild(apellidos);

            XmlElement edad = documento.CreateElement("edad");
            edad.InnerText = "20";
            elemento.AppendChild(edad);
            XmlWriter escritor = new XmlTextWriter("persona.xml", null);
            documento.Save(escritor);
            Console.ReadLine();
        }


    }
}
