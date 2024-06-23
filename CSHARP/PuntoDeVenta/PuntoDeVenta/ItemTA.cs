using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    internal class ItemTA : ItemBase
    {
        public ItemTA()
        {
        }

        public ItemTA(Articulo articulo, string telefono, string compania, decimal comision, decimal cantidad) : base(articulo, cantidad)
        {
            this.telefono = telefono;
            this.compania = compania;
            this.comision = comision;
        }

        public string telefono { get; set; }
        public string compania { get; set; }
        public decimal comision { get; set; }

        public override decimal Total()
        {
            return base.SubTotal() + comision;
        }
        public override void Imprimir()
        {
            Console.WriteLine($"Tiempo aire id: {Id}, Telefono:{telefono}, Compañia: {compania}, precio: {precio}");
        }
    }

}
