using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Program13
    {
        static void Main(string[] args)
        {
            Paciente p1 = new Paciente("94562301G", "Ana", new HistorialMedico(156, DateTime.Today));
            Console.WriteLine("Paciente: {0}\tDNI: {1}", p1.Nombre, p1.DNI);
            Console.WriteLine("Historial Medico de {0}: nº: {1}\tFecha: {2}", p1.Nombre, p1.Historial.NumeroHistorial, p1.Historial.Fecha);
            Console.ReadLine();
        }
    }
}
