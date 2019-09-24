using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Departamento
    {
        private string nombre, codigo;
        public Departamento(string nombre, string codigo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        //getters
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
