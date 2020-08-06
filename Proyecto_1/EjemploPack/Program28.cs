using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaSemicrol;
using Proyecto_1.Clases;
using Proyecto_1.EmpresaAlquiler;

namespace Proyecto_1.EjemploPack

{
    class Program28
    {
        static void Main(string[] args)
        {
            Pack<Golosina, Golosina> p1 = new Pack<Golosina, Golosina>(new Golosina("Fresa", 5), new Golosina("Limon", 6));
            Console.WriteLine("Sabores: {0} y {1}", p1.Producto1.Sabor, p1.Producto2.Sabor);
            Console.WriteLine("El importe de los dos productos es de: {0}", p1.ImporteTotal());
            Console.ReadLine();
        }
    }
}