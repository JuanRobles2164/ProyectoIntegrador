using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    abstract class Academica
    {
        private string codigo, nombre;

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getCodigo()
        {
            return this.codigo;
        }
        public string getNombre()
        {
            return this.nombre;
        }
    }
}
