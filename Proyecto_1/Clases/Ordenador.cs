using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.Clases
{
    class Ordenador
    {
        public Ordenador(CPU cPU, Monitor monitor)
        {
            CPU = cPU;
            Monitor = monitor;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public CPU CPU { get; set; }
        public Monitor Monitor { get; set; }

        //virtual permite que el metodo se pueda modificar en las clases que hereden de este objeto
        public virtual void Encender()
        {
            CPU.Encender();
            Monitor.Encender();
        }

        public virtual void Apagar()
        {
            Console.WriteLine("El ordenador esta apagado");
        }

        public virtual void Reiniciar()
        {
            Console.WriteLine("El ordenador esta reiniciando");
        }

        protected virtual void EncenderCPU()
        {
            CPU.Encender();
        }
        
        protected virtual void EncenderMonitor()
        {
            Monitor.Encender();
        }
    }

}
