using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal struct Aportaciones
    {
        public Aportaciones(decimal enfermedadMaternal, decimal invalidezVida, decimal retiro, decimal cesantia, decimal infonavit)
        {
            EnfermedadMaternal = enfermedadMaternal;
            InvalidezVida = invalidezVida;
            Retiro = retiro;
            Cesantia = cesantia;
            Infonavit = infonavit;
        }

        public decimal EnfermedadMaternal { get; set; }
        public decimal InvalidezVida { get; set; }
        public decimal Retiro { get; set; }
        public decimal Cesantia { get; set; }
        public decimal Infonavit { get; set; }
    }
}
