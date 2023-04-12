using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public abstract class Usuario
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected string direccion;

        //Constructor de la clase sin parametros
        public Usuario()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
            this.direccion = "";
        }

        //Propiedades de los atributos
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public string Apellido
        {
            set { this.apellido = value; }
            get { return this.apellido; }
        }

        public string Direccion
        {
            set { this.direccion = value; }
            get { return this.direccion; }
        }

        public int Dni
        {
            set { this.dni = value; }
            get { return this.dni; }
        }
    }
}
