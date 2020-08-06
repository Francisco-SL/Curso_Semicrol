using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program11
    {
        static void Main(string[] args)
        {
            Nota n1 = new Nota(8);
            Console.WriteLine(n1.TipoNota());
            Console.WriteLine("La nota mayor es: {0}", n1.EsMayor(new Nota(9)).Valor);
            Console.ReadLine();
        }
    }
}
