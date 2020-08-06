using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
namespace Proyecto_1
{
    class Program19
    {
        static void Main(string[] args)
        {
            // Estableciendo primero Animal, se hace un concepto mas generalista (polimorfismo)
            //Animal p1 = new Perro("Blanco", 30);          
            //Animal g1 = new Gato("Negro", 10);
            //VacunarAnimal(p1);
            //VacunarAnimal(g1);

            Animal p1 = FactoriaAnimal.GetAnimal("Perro", 30, "Marron");
            Animal g1 = FactoriaAnimal.GetAnimal("Gato", 12, "Blanco");
            VacunarAnimal(p1);
            VacunarAnimal(g1);
            Perro p2 = new Perro("Negro", 20);
            Perro p3 = new Perro("Negro", 20);
            Console.WriteLine("¿Es igual el {0} al {1}? : {2}", p2.GetType().Name, p3.GetType().Name, p2.Equals(p3) ? "Si" : "No");
            Console.ReadLine();
        }

        public static void VacunarAnimal(Animal a)
        {
            a.Vacunar();
            Console.WriteLine("¿Esta vacunado el {0}?: {1}", a.GetType().Name, a.EstaVacunado == true ? "Si" : "No");
        }
    }
}
