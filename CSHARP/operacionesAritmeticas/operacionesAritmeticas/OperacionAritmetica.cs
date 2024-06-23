using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesAritmeticas
{
    public struct OperacionAritmetica
    {
        public OperacionAritmetica(decimal operandoA, decimal operandoB, tipoOperacion tOperacion)
        {
            this.operandoA = operandoA;
            this.operandoB = operandoB;
            this.tOperacion = tOperacion;
        }

        public decimal operandoA { get; set; }
        public decimal operandoB { get; set; }
        public tipoOperacion tOperacion { get; set; }
    }
}

