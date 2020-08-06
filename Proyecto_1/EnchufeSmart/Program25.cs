using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
namespace Proyecto_1.EnchufeSmart
{
    class Program25
    {
        static void Main(string[] args)
        {
            Cocina c = new Cocina();
            c.AddEncendible(new Bombilla());
            c.AddEncendible(new Bombilla());
            c.AddEncendible(new Bombilla());
            c.AddEncendible(new BombillaSmart("1"));
        //    c.AddEncendible(new Frigorifico());
            c.EncenderTodo();

            c.AddEncendible(new EnchufeSmartAdaptador("2", new Bombilla()));
            c.EncenderVoz("2");
           // c.EncenderVoz("1");
            Console.ReadLine();
        }
    }
}
