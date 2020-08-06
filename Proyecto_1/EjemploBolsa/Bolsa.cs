using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.EjemploBolsa
{
     class Bolsa<T> where T : IPrecio
    {
        public int Tope { get; set; }
        public List<T> Elementos = new List<T>();

        public Bolsa(int tope)
        {
            Tope = tope;
        }

        public void AddElemento(T Elemento)
        {
            if (Elementos.Count < Tope)
            {
                Elementos.Add(Elemento);
            }
            else
            {
                Console.WriteLine("Limite de la bolsa alcanzado");
            }
        }

        public void RemoveElemento(T Elemento)
        {
            Elementos.Remove(Elemento);
        }

        public double Total()
        {
            double total = 0;
            foreach(T e in Elementos)
            {
                total += e.Importe;
            }
            return total;
        }
    }
}
