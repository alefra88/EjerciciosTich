using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOWebForms.ADO
{
    interface ICRUD
    {       
            List<EstatusAlumno> ConsultarT();
            EstatusAlumno Consultar(int id);
            int Agregar(EstatusAlumno estatusAlumno);
            void Actualizar(EstatusAlumno estatusAlumno);
            void Eliminar(int id);        
    }
}
