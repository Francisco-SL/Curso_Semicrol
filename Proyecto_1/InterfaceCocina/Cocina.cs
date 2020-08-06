using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.InterfaceCocina
{
    class Cocina
    {
        public IEncendible Lavadora { get; set; }
        public IEncendible Frigorifico { get; set; }
        public List<Bombilla> listaLuces = new List<Bombilla>();

        public Cocina()
        {
        }

        public Cocina(IEncendible lavadora, IEncendible frigorifico)
        {
            Lavadora = lavadora;
            Frigorifico = frigorifico;
        }

        public List<Bombilla> Luces
        {
            get
            {
                return listaLuces;
            }
            set
            {
                listaLuces = value;
            }
        }

        public void AddBombilla(Bombilla b)
        {
            Luces.Add(b);
        }
    }
}
