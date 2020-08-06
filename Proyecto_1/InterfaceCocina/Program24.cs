using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.InterfaceCocina
{
    class Program24
    {
        static void Main(string[] args)
        {
            IEncendible f = new Frigorifico();
            IEncendible l = new Lavadora();
            Cocina c = new Cocina(f, l);
            c.AddBombilla(new Bombilla());
            c.AddBombilla(new Bombilla());
            EntrarCocina(c);
            SalirCocina(c);

            Console.ReadLine();
        }

        public static void EntrarCocina(Cocina c)
        {
            foreach(Bombilla b in c.Luces)
            {
                b.Encender();
            }
            c.Frigorifico.Encender();
            c.Lavadora.Encender();
        }

        public static void SalirCocina(Cocina c)
        {
            foreach (Bombilla b in c.Luces)
            {
                b.Apagar();
            }
            c.Frigorifico.Apagar();
            c.Lavadora.Apagar();
        }


    }
}
