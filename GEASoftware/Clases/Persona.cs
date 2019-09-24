using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    abstract class Persona
    {
        private string codigo, nombre, apellido, fechaNac, telefono, nroIdentificacion, userName, password;

        //Setters
        public void setCodigo(string cod)
        {
            this.codigo = cod;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setFechaNacimiento(string fecha)
        {
            this.fechaNac = fecha;
        }
        public void setTelefono(string tel)
        {
            this.telefono = tel;
        }
        public void setNroIdentificacion(string nro)
        {
            this.nroIdentificacion = nro;
        }
        public void setUserName(string user)
        {
            this.userName = user;
        }
        public void setPassword(string pass)
        {
            this.password = pass;
        }
        //Getters
        //private string codigo, nombre, apellido, fechaNac, telefono, nroIdentificacion, userName, password;
        public string getCodigo()
        {
            return this.codigo;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public string getFechaNacimiento()
        {
            return this.fechaNac;
        }
        public string getTelefono()
        {
            return this.telefono;
        }
        public string getNroIdentificacion()
        {
            return this.nroIdentificacion;
        }
        public string getUserName()
        {
            return this.userName;
        }
        public string getPass()
        {
            return this.password;
        }

    }
}
