using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;
namespace business
{
    public class NEstado
    {
        List<Estado> Consultar()
        {
            DEstado oDEestad = new DEstado();
            List<Estado> listaEstado = new List<Estado>();
           listaEstado = oDEestad.Consultar();
            return listaEstado;
        }
    }
}
