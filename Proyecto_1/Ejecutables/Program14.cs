using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program14
    {
        static void Main(string[] args)
        {
            List<Nota> listaNotas = new List<Nota>();
            listaNotas.Add(new Nota(6));
            listaNotas.Add(new Nota(2));
            listaNotas.Add(new Nota(3));
            listaNotas.Add(new Nota(4));
            listaNotas.Add(new Nota(5));
            listaNotas.Add(new Nota(6));
            listaNotas.Add(new Nota(7));
            foreach (Nota n in listaNotas)
            {
                Console.WriteLine("Nota: {0}\tTipo: {1}", n.Valor, n.TipoNota());
            }           
            Nota notaMayor = new Nota(0);
            foreach (Nota n in listaNotas)
            {
                notaMayor = n.EsMayor(notaMayor);
            }
            double acum = 0;
            foreach (Nota n in listaNotas)
            {
                acum += n.Valor;
            }
            Console.WriteLine("La nota media es de {0} puntos", acum/listaNotas.Count);
            Console.WriteLine("La nota mayor es de {0} puntos", notaMayor.Valor);
            Console.ReadLine();
        }

        


    }
}
