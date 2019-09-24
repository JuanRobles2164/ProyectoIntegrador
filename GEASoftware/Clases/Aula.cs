using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Aula
    {
        private string id, nroAula, cantidadAlumnos;
        public Aula(string id, string nroAula, string cantidadAlumnos)
        {
            this.id = id;
            this.nroAula = nroAula;
            this.cantidadAlumnos = cantidadAlumnos;
        }
        //Getters
        public string getId()
        {
            return this.id;
        }
        public string getNroAula()
        {
            return this.nroAula;
        }
        public string getCantidadAlumnos()
        {
            return this.cantidadAlumnos;
        }
        //Setters
        public void setId(string id)
        {
            this.id = id;
        }
        public void setNroAula(string nroAula)
        {
            this.nroAula = nroAula;
        }
        public void setCantidadAlumnos(string cantidadAlumnos)
        {
            this.cantidadAlumnos = cantidadAlumnos;
        }
        //Otros métodos
    }
}
