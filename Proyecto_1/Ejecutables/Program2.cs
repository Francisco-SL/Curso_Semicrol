using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program2
    {
        static void Main(string[] args)
        {
            int num = 9;
            if (num > 0 && num < 3)
            {
                Console.WriteLine("Has aprobado");
            }
            else if (num >= 3 && num < 5)
            {
                Console.WriteLine("Has suspendido");
            }
            else if (num >= 5 && num < 7)
            {
                Console.WriteLine("Has aprobado");
            }
            else
            {
                Console.WriteLine("Buena nota");
            }
            Console.ReadLine();
        }
    }
}
