using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.EnchufeSmart
{
    interface IEncendibleVoz : IEncendible
    {
        string Id { get; set; }
        void EncenderVoz();
        void ApagarVoz();
    }
}
