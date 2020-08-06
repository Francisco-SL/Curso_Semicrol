using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program7
    {
        static void Main(string[] args)
        {
            Magdalena m1 = new Magdalena();
            m1.Color = "Amarilla";
            m1.Precio = 2;
            m1.Peso = 12;
            Console.WriteLine(m1.Color);
            Console.WriteLine(m1.Precio);
            Console.WriteLine(m1.Peso);
            Console.ReadLine();
        }
    }
}
