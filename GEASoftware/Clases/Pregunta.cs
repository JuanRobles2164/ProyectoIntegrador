using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEASoftware
{
    class Pregunta
    {
        private string id, respuesta, creadorPregunta, imagenUbicacion;
        public Pregunta(string id, string respuesta, string creadorPregunta, string imagenUbicacion) //Constructor en caso de que la pregunta tenga imagen incluida
        {
            this.id = id;
            this.respuesta = respuesta;
            this.creadorPregunta = creadorPregunta;
            this.imagenUbicacion = imagenUbicacion;
        }
        public Pregunta(string id, string respuesta, string creadorPregunta) //Constructor en caso de que la pregunta no tenga imagen
        {
            this.id = id;
            this.respuesta = respuesta;
            this.creadorPregunta = creadorPregunta;
            this.imagenUbicacion = "";
        }

        //Setters
        public void setId(string id)
        {
            this.id = id;
        }
        public void setRespuesta(string respuesta)
        {
            this.respuesta = respuesta;
        }
        public void setCreadorPregunta(string creadorPregunta)
        {
            this.creadorPregunta = creadorPregunta;
        }
        public void setImagenUri(string imagenUri)
        {
            this.imagenUbicacion = imagenUri;
        }


        //getters
        public string getIdPregunta()
        {
            return this.id;
        }
        public string getRespuesta()
        {
            return this.respuesta;
        }
        public string getCreadorPregunta()
        {
            return this.creadorPregunta;
        }
        public string getImagenUri()
        {
            return this.imagenUbicacion;
        }

    }
}
