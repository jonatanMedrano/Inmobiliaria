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
        public Dpto(string c, int n, string l, string p, string pro, int m2c, int np, int nd) : base( c, n, l, p, pro, m2c)
        {
            this.nroDpto=nd;
            this.nroPiso=np;
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
