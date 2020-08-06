using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program15
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Pedro");
            a1.AddNota(new Nota(1));
            a1.AddNota(new Nota(6));
            a1.AddNota(new Nota(10));
            a1.AddNota(new Nota(5));
            a1.AddNota(new Nota(9));
            Console.WriteLine("El alumno {0} tiene un total de {1} notas", a1.Nombre, a1.Notas.Count);
            Console.WriteLine("La nota media de {0} es de {1} puntos ({2}), su nota mayor es de {3} puntos", a1.Nombre, a1.NotaMedia().Valor, a1.NotaMedia().TipoNota(), a1.NotaMayor().Valor);
            Console.ReadLine();
        }

        


    }
}
