using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Dpto : Vivienda
    {
        private int nroPiso;
        private int nroDpto;

        //Constructor de la clase sin parametros
        public Dpto():base()
        {
            this.nroDpto = 0;
            this.nroPiso = 0;
        }

        //Propiedades de los atributos
        public int NroPiso
        {
            set { this.nroPiso = value; }
            get { return this.nroPiso; }
        }
        
        public int NroDpto
        {
            set { this.nroDpto = value; }
            get { return this.nroDpto; }
        }
    }
}
