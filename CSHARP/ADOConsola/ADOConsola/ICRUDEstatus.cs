using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOConsola
{
    interface ICRUDEstatus
    {
        List<Estatus> ConsultarT();
        Estatus Consultar(int id);
        int Agregar(Estatus status);
        void Actualizar(Estatus status);
        void Eliminar(int id);

    }
}
