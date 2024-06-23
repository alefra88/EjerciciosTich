using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class CRUD
    {
        internal Dictionary<int, Estado> _diccionarioEstados = new Dictionary<int, Estado>();
        internal Dictionary<int, Estado> ConsultarTodos()
        {
            return _diccionarioEstados;
        }
        internal Estado ConsultarSoloUno(int id)
        {
            return _diccionarioEstados[id];
        }
        internal void Agregar(Estado oEstado)
        {
            _diccionarioEstados.Add(oEstado.id, oEstado);
        }
        internal void Actualizar(Estado oEstado)
        {
            _diccionarioEstados[oEstado.id] = oEstado;
        }
        internal void Eliminar(int id)
        {
            _diccionarioEstados.Remove(id);
        }
    }
}
