using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Asignatura : Academica
    {
        //Codigo, nombre
        public Asignatura(string nombre, string codigo)
        {
            this.setNombre(nombre);
            this.setCodigo(codigo);
        }
    }
}
