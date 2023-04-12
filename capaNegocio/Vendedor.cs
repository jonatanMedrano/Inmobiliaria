using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
   public class Vendedor : Usuario
    {
        private int legajo;

        //Contructor de la clase sin parametros
        public Vendedor()
        {
            this.legajo = 0;
        }

        //Propiedades de los atributos
        public int Legajo
        {
            set { this.legajo = value; }
            get { return this.legajo; }
        }
    }
}
