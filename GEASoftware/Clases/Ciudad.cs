using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Ciudad
    {
        private string nombre, codigo;
        public Ciudad(string nombre, string codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public string getCodigo()
        {
            return this.codigo;
        }
    }
}
