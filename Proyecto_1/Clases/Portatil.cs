using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;
namespace Proyecto_1.Clases
{
    class Portatil : Ordenador
    {
        public Portatil(CPU CPU) : base(CPU, new Monitor(15))
        {

        }

        public override void Encender()
        {
            Console.WriteLine("El portatil se enciende despacio");
            // base.Encender(); // se llama al metodo del objeto heredado (padre)
            base.Encender();
            Console.WriteLine("El portatil termino de encender");
        }
    }
}