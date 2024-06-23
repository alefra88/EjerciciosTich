using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    internal class ItemDescuento : ItemBase
    {
        public static decimal _descuento = 0;

        public ItemDescuento()
        {
        }

        public ItemDescuento(Articulo articulo,decimal descuento, decimal cantidad ):base(articulo,cantidad)
        {
            this.descuento = descuento;

        }

        public decimal descuento { get; set; }
        public decimal ImpDescuento
        {
            get
            {


                return base.SubTotal() - ImpDescuento;
            }
        }

        public override void Imprimir()
        {
            Console.WriteLine($"ID: {Id} Nombre{nombre}, Precio: {precio}, Cantidad: {cantidad}, subtotal: {SubTotal()}\n Descuento:{ImpDescuento} {descuento}%,\n Total: {Total()}");
        }

    }

}
