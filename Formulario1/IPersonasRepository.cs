using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario1
{
    interface IPersonasRepository
    {
        IList<Persona> BuscarTodos();
    }
}
