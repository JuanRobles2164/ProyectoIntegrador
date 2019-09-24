using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Docente : Persona
    {
        private string codDocente;
        public Docente(string codigo, string nombre, string apellido, string fechaNac, string telefono, string nroIdentificacion, string userName, string password, string codProfesor)
        {
            this.codDocente = codProfesor;
            this.setCodigo(codigo);
            this.setNombre(nombre);
            this.setApellido(apellido);
            this.setFechaNacimiento(fechaNac);
            this.setTelefono(telefono);
            this.setNroIdentificacion(nroIdentificacion);
            this.setUserName(userName);
            this.setPassword(password);
        }
        public string getCodigoDocente()
        {
            return this.codDocente;
        }
    }
}
