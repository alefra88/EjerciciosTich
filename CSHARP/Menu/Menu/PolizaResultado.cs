using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a) Crear la Estructura PolizaResultado Con las siguientes propiedades: 
//a.FechaTermino tipo Datetime 
//b. Prima tipo decimal 
namespace Menu
{
    internal struct PolizaResultado
    {
        public PolizaResultado(DateTime fechaTermino, decimal prima)
        {
            FechaTermino = fechaTermino;
            Prima = prima;
        }

        public DateTime FechaTermino { get; set; }
        public decimal Prima { get; set; }
    }
}
