using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoches
{
    internal struct StructCoche
    {
        public StructCoche(int id, string marca, string modelo, string km, decimal precio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
        }

        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string km { get; set; }
        public decimal precio {get; set; }


    }
}
