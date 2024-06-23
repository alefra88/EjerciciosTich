using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class Estatus
    {
        public Estatus()
        {
        }

        public Estatus(int id, string status)
        {
            this.id = id;
            this.status = status;
        }

        public int id { get; set; }
        public string status { get; set; }
    }
}
