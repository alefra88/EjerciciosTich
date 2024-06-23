using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Icuadrado : IFigura
    {
        public decimal Lado { get; set; }

        public decimal Area()
            
        {
            return Lado * Lado;
        }
        public decimal Perimetro()
        
        {
            return 4 * Lado;
        }
    }
}
