using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Prueba : Academica
    {
        private int cantidadPreguntas;
        public Prueba(string codigo, string nombre, int cantidadPreguntas)
        {
            this.setCodigo(codigo);
            this.setNombre(nombre);
            this.cantidadPreguntas = cantidadPreguntas;
        }
        public void setCantidadPreguntas(int cantidadPreguntas)
        {
            this.cantidadPreguntas = cantidadPreguntas;
        }
        public int getCantidadPreguntas()
        {
            return this.cantidadPreguntas;
        }

    }
}
