using System;
using System.Collections.Generic;

namespace NetCoreApp.Model.Entities
{
    public partial class Saldo
    {
        public Saldo()
        {
            Transacciones = new HashSet<Transaccione>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal? Saldo1 { get; set; }

        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
