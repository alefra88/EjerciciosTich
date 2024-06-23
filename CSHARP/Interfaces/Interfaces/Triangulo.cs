using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Itriangulo : IFigura
    {
        public decimal bBase { get; set; }
        public decimal lLado { get; set; }
       
        public decimal Altura
        {
            get
            {
                return (decimal)Math.Sqrt((double)(lLado * lLado - bBase * bBase * bBase/4));
            }
        }
        public decimal Area()
        {
            return (bBase * Altura) /2;
        }
        public decimal Perimetro()
        {
            return 2 * lLado * bBase;
        }
    }
}