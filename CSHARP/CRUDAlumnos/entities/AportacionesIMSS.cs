﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class AportacionesIMSS
    {
        public AportacionesIMSS()
        {
        }

        public AportacionesIMSS(decimal enfermedadMaternidad, decimal invalidezVida, decimal retiro, decimal cesantia, decimal infonavit)
        {
            EnfermedadMaternidad = enfermedadMaternidad;
            InvalidezVida = invalidezVida;
            Retiro = retiro;
            Cesantia = cesantia;
            Infonavit = infonavit;
        }

        public decimal EnfermedadMaternidad { get; set; }
        public decimal InvalidezVida { get; set; }
        public decimal Retiro { get; set; }
        public decimal Cesantia { get; set; }
        public decimal Infonavit { get; set; }

    }
}
