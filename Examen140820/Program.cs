using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen140820
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno("Mercedes");
            a.AddNota(new Nota(5));
            a.AddNota(new Nota(10));
            a.AddNota(new Nota(4.5));
            a.AddNota(new Nota(8));
            a.AddNota(new Nota(7));
            a.InformacionNotas();
            Console.ReadLine();
        }
    }
}
