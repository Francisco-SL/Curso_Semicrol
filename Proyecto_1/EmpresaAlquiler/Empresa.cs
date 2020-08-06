using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_1.Clases;

namespace Proyecto_1.EmpresaAlquiler
{
    class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Alquiler> listaAlquileres = new List<Alquiler>();

        public Empresa(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public void AddAlquiler(Alquiler a)
        {
            listaAlquileres.Add(a);
        }

        public double obtenerTotal()
        {
            double total=0;
            foreach (Alquiler a in listaAlquileres)
            {
                total += a.ImporteTotal();
            }
            return total;
        }

        public Alquiler importeMayor()
        {
            Alquiler a = listaAlquileres[0];
            foreach (Alquiler al in listaAlquileres)
            {
                if (al.ImporteTotal() > a.ImporteTotal())
                {
                    a = al;
                }
            }
            return a;
        }

        public void EliminarAlquiler(Alquiler a)
        {
            listaAlquileres.Remove(a);
        }

        public int NumeroAlquileres()
        {
            return listaAlquileres.Count;
        }

        public void ListarAlquiler()
        {
            foreach (Alquiler a in listaAlquileres)
            {
                Console.WriteLine("Tipo: {0} \t\t Id: {1} \t\t Importe: {2} \t\t Importe Total: {3}", a.GetType().Name, a.Numero, a.Importe, Math.Round(a.ImporteTotal(),2));
            }
        }

        public bool ContieneAlquiler(Alquiler a)
        {
            return listaAlquileres.Contains(a);
        }
    }
}
