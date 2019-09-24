using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Facultad : Academica
    {
        public Facultad(string codigo, string nombre)
        {
            this.setNombre(nombre);
            this.setCodigo(codigo);
        }
    }
}
