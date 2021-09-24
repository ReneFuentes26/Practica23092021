using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2309
{
    class Professor
    {
        //Definir miembros de la clase
        //propiedades|atributos|datos
        private int _ProfesorId;
        private string _Titulo;
        private string _Materias;
        private string _LugardeTrabajo;




        //metodos de propiedad
        //get-- obtiene el valor almacenado en la propiedad
        //sett .. asignar un valor a la variable de propiedad


        //ProfesorId
        public void setProfesorId(int ProfesorId)
        {
            _ProfesorId = ProfesorId;
        }

        public int getProfesorId()
        {
            return _ProfesorId;
        }

        //Titulo
        public void setTitulo(String titulo)
        {
            _Titulo = titulo;

        }

        public string getTitulo()
        {
            return _Titulo;
        }

        //Edad
        public void setMaterias(string Materias)
        {
            _Materias = Materias;
        }

        public string getMaterias()
        {
            return _Materias;
        }

        //Lugar de Trabajo
        public void setLugardeTrabajo(string LugardeTrabajo)
        {
            _LugardeTrabajo = LugardeTrabajo;
        }

        public string getLugardeTrabajo()
        {
            return _LugardeTrabajo;
        }
    }
}
