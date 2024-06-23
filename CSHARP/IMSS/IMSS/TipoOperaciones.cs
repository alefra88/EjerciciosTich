using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    public struct TipoOperaciones
    {
        public TipoOperaciones(decimal operSBC, decimal operUMA, tipoOperacion tOperacion, tipoPersona tPersona)
        {
            this.operSBC = operSBC;
            this.operUMA = operUMA;
            this.tOperacion = tOperacion;
            this.tPersona = tPersona;
        }

        public decimal operSBC { get; set; }
        public decimal operUMA { get; set; }
        public tipoOperacion tOperacion { get; set; }

        public tipoPersona tPersona { get; set; }

    }
}
