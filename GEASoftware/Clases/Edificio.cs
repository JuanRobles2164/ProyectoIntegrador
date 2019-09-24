using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Edificio : Academica
    {
       
        public Edificio(string codigo, string nombre)
        {
            this.setCodigo(codigo);
            this.setNombre(nombre);
        }
    }
}
