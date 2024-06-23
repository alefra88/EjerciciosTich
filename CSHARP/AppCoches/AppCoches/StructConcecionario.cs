using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoches
{
    internal class StructConcecionario
    {
        public StructConcecionario(Coche[] coches, int limite)
        {
            this.coches = coches;
            this.limite = limite;
        }

        public Coche[] coches { get; set; }
        public int limite { get; set; }
    }
}
