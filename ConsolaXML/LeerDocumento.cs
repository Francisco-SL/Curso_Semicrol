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
            XmlReader lector = new XmlTextReader("personas.xml");
            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(lector.Value);
                }
            }
            
            Console.ReadLine();
        }
    }
}
