using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.TratamientoExcepciones
{
    class Program31
    {
        delegate int Operacion(int a, int b);//referencia a una funcion

        static void Main(string[] args)
        {
            
            Operacion o=new Operacion(Sumar);
            int resultado = o(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);
            Console.ReadLine();
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
