using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
namespace Proyecto_1.EjemploBolsa
{
    class Program27
    {
        static void Main(string[] args)
        {
            Bolsa<Golosina> bolsa = new Bolsa<Golosina>(5);
            bolsa.AddElemento(new Golosina("Fresa",5));
            bolsa.AddElemento(new Golosina("Limon", 5));
            bolsa.AddElemento(new Golosina("Platano", 5));
            bolsa.AddElemento(new Golosina("Naranja", 5));
            bolsa.AddElemento(new Golosina("Sandia", 5));
            bolsa.AddElemento(new Golosina("Melon", 5));
            foreach (Golosina g in bolsa.Elementos)
            {
               Console.WriteLine(g.Sabor);
            }
            Console.ReadLine();
        }
    }
}
