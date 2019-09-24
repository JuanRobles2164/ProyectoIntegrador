using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Opcion
    {
        private string id, descripcion;
        private bool correcta;

        public Opcion(string id, string descripcion, bool correcta)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.correcta = correcta;
        }

        public string getId()
        {
            return this.id;
        }
        public string getDescripcion()
        {
            return this.descripcion;
        }
        public bool getCorrecta()
        {
            return this.correcta;
        }

        public void setId(string id)
        {
            this.id = id;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public void setCorrecta(bool correcta)
        {
            this.correcta = correcta;
        }
    }
}
