using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public abstract class Vivienda
    {
        protected string calle;
        protected int nro;
        protected int m2Cubiertos;
        protected string localidad;
        protected string partido;
        protected string provincia;

        //Contructor de la clase sin parametros
        public Vivienda()
        {
            this.calle = "";
            this.nro = 0;
            this.localidad = "";
            this.partido = "";
            this.provincia = "";
        }

        //Propiedades de los atributos
        public int Nro
        {
            set { nro = value; }
            get { return this.nro; }
        }

        public int M2Cubiertos
        {
            set { m2Cubiertos = value; }
            get { return this.m2Cubiertos; }
        }

        public String Localidad
        {
            set { localidad = value; }
            get { return this.localidad; }
        }

        public String Partido
        {
            set { partido = value; }
            get { return this.provincia; }
        }

        public String Provincia
        {
            set { provincia = value; }
            get { return this.provincia; }
        }

    }
}
