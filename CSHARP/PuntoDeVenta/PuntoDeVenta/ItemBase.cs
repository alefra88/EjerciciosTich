using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public abstract class ItemBase
    {
        public ItemBase()
        {
        }

        protected ItemBase(Articulo articulo, decimal cantidad)
        {
            this.Id = articulo.Id;
            this.nombre = articulo.Nombre;
            this.precio = articulo.Precio;
            this.cantidad = cantidad;
        }

        public int Id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public decimal cantidad { get; set; }

        public virtual decimal SubTotal()
        {
            decimal subtotal = precio * cantidad;
            return subtotal;
        }
        public virtual decimal Total()
        {
            decimal total = precio * cantidad;
            return total;
        }
        public abstract void Imprimir();



    }

}
