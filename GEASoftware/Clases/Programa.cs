using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Programa : Academica
    {
        //Código y nombre
        public Programa(string codigo, string nombre)
        {
            this.setCodigo(codigo);
            this.setNombre(nombre);
        }
    }
}
