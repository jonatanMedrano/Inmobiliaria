using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Casa : Vivienda
    {
        private int m2Terreno;

        //Constructor de la clase sin parametros
        public Casa()
        {
            this.m2Terreno = 0;
        }

        //Propiedades de los atributos
        public int M2Terreno
        {
            set { m2Terreno = value; }
            get { return this.m2Terreno; }
        }
    }
}
