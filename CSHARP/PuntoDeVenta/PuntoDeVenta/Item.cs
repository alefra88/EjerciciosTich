using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    internal class Item :ItemBase
    {
        public Item()
        {
        }

        public Item(Articulo articulo, decimal cantidad) : base(articulo,cantidad)
        {
        }

        public override void Imprimir()
        {
            Console.WriteLine($"ID: {Id}\n nombre: {nombre}\n precio: {precio}\n Cantidad: {cantidad}\n subtotal: {SubTotal()}\n total: {Total()} \nGracias por su compra");
        }
    }
}
