using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
namespace Proyecto_1.EnchufeSmart
{
    class Program26
    {
        static void Main(string[] args)
        {
            List<Frigorifico> lista = new List<Frigorifico>();
            lista.Add(new Frigorifico(5));
            lista.Add(new Frigorifico(20));
            lista.Add(new Frigorifico(25));
            lista.Add(new Frigorifico(30));
            lista.Add(new Frigorifico(5));
            lista.Sort(new ComparadorPotencia());
            foreach(Frigorifico f in lista)
            {
                Console.WriteLine(f.Potencia);
            }
            Console.ReadLine();
        }
    }
}
