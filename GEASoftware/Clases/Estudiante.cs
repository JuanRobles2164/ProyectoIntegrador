using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Estudiante : Persona
    {
        private int nivel;
        public Estudiante(string codigo, string nombre, string apellido, string fechaNac, string telefono, string nroIdentificacion, string userName, string password, int lvl)
        {
            this.setCodigo(codigo);
            this.setApellido(nombre);
            this.setApellido(apellido);
            this.setFechaNacimiento(fechaNac);
            this.setTelefono(telefono);
            this.setNroIdentificacion(nroIdentificacion);
            this.setUserName(userName);
            this.setPassword(password);
            this.nivel = lvl;
        }
    }
}
