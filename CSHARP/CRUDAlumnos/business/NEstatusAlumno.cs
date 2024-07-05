using entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;

namespace business
{
    public class NEstatusAlumno
    {

        

        public List<EstatusAlumno> Consultar()
        {
            NEstatusAlumno _oNEstatusAlumno = new NEstatusAlumno();
            List<EstatusAlumno> listaEstatus = new List<EstatusAlumno>();
           listaEstatus = _oNEstatusAlumno.Consultar();
            return listaEstatus;
        }
    }
}
