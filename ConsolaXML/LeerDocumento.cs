using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsolaXML
{
    class LeerDocumento
    {
        static void Main(string[] args)
        {
            XmlReader lector = new XmlTextReader("../../Personas.xml");
            int valor = 0;
            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Element)
                {
                    if (lector.Name.Equals("edad"))
                    {
                        lector.Read();
                        valor += Convert.ToInt32(lector.Value);
                    }
                }
            }
            Console.WriteLine("Edad total: {0}", valor);
            Console.ReadLine();
        }
    }
}
