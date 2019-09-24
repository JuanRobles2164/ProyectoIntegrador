using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Institucion : Academica
    {
        public Institucion(string codigo, string nombre)
        {
            this.setCodigo(codigo);
            this.setNombre(nombre);
        }
    }
}
