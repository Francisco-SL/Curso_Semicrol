using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.EnchufeSmart
{
    class Cocina
    {
        public List<IEncendible> Encendibles { get; set; }

        public Cocina()
        {
            Encendibles = new List<IEncendible>();
        }

        public void AddEncendible(IEncendible e)
        {
            Encendibles.Add(e);
        }

        public void EncenderTodo()
        {
            foreach (IEncendible e in Encendibles)
            {
                e.Encender();
            }
        }

        public void EncenderVoz(string id)
        {
                        foreach (IEncendible e in Encendibles)
            {
                if (e is IEncendibleVoz)
                {
                    IEncendibleVoz otro = (IEncendibleVoz)e;
                    if (otro.Id.Equals(id))
                    {
                        otro.EncenderVoz();
                        break;
                    }
                }
            }
        }


    }
}
