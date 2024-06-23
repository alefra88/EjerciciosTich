using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class CRUD
    {
        internal static List<Estatus> _ListaEstatus = new List<Estatus>();
        //consultar todos
        internal List<Estatus> ConsultarTodos()
        {
            return _ListaEstatus;
        }
        //consultar uno
        internal Estatus ConsultarSoloUno(int id)
        {
            return _ListaEstatus.FirstOrDefault(e=>e.id==id);
        }
        //agregar 
        internal void Agregar(Estatus estatus)
        {
            if (_ListaEstatus.Any(e => e.id == estatus.id))
            {
                throw new ArgumentException($"Ya existe un estatus con el ID {estatus.id}");
            }
            _ListaEstatus.Add(estatus);
        }
        internal void Actualizar(int id, string nuevoEstatus)
        {
            Estatus estatus = _ListaEstatus.FirstOrDefault(e=> e.id == id);
            if(estatus != null)
            {
                estatus.status = Convert.ToString(nuevoEstatus);
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un estatus con el ID {id}");
            }
        }
        internal void Eliminar(int id)
        {
            Estatus estatus = _ListaEstatus.FirstOrDefault(e=>e.id==id);
            if(estatus != null)
            {
                _ListaEstatus.Remove(estatus);
                Console.WriteLine("Estatus eliminado correctamente");
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un estatus con el id {id}");
            }
        }

    }
}
