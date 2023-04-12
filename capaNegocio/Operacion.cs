using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Operacion
    {
        //la idea que sea tipo hastable
        //0 - VENTA
        //1 - ALQUILER
        private Dictionary<int, string> operacion;

        public Operacion()
        {
            this.operacion.Add(0, "VENTA");
            this.operacion.Add(1, "ALQUILER");
        }
    }
}
