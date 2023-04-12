using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Cliente : Usuario
    {
        private int nroCli;

        //Contructor de la clase sin parametros
        public Cliente()
        {
            this.nroCli = 0;
        }

        //Propiedades de los atributos
        public int NroCli
        {
            set { this.nroCli = value; }
            get { return this.nroCli; }
        }
    }
}
