using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.TratamientoExcepciones
{
    class Program32
    {
        //High Order Function
        // recibe dos parametros, T1, T1, y devuelve un resultado T3
       // public delegate int Operacion(int a, int b);

        static void Main(string[] args)
        {
            Func<int, int, int> miFuncion=Sumar;
            Func<int, int, int> FuncionLambda = (a, b) => a * b;    
            OperarPorPantalla(2, 3, miFuncion);
            OperarPorPantalla(2, 3, Restar);
            OperarPorPantalla(2, 3, FuncionLambda);
            OperarPorPantalla(2, 3, (a,b)=>a/b); // otra forma de declarar funciones lambda
            Console.ReadLine();
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        //public static void OperarPorPantalla(int a, int b, Operacion tipo)
        //{
        //    Console.WriteLine("Resultado: {0}", tipo(a, b));
        //}

        public static void OperarPorPantalla(int a, int b, Func<int, int, int> funcion)
        {
            Console.WriteLine("Resultado: {0}", funcion(a, b));
        }
    }
}
