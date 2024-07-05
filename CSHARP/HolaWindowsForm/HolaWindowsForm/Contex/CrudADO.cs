using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaWindowsForm.Contex
{
    internal class CrudADO
    {
        List<Estado> _ListaEstado = new List<Estado>();
        public List<Estado> Consultar()
        {
            return _ListaEstado;
        }
        public Estado Consultar(int id)
        {
            return _ListaEstado.Find(x => x.id == id);
        }
    }
}
