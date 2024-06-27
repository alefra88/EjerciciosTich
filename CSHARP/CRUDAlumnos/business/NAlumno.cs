using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;

namespace business
{
    public class NAlumno
    {
        DAlumno _oDAlumno = new DAlumno();


        public List<Alumno> Consultar()
        {
            List<Alumno> alumnoList = new List<Alumno>();
            alumnoList =  _oDAlumno.Consultar();
            return alumnoList;
        }
        public Alumno Consultar(int id)
        {
            Alumno oAlumno = new Alumno();
           oAlumno = _oDAlumno.Consultar(id);
            return oAlumno;
        }
        public void Agregrar(Alumno alumno)
        {
            
            _oDAlumno.Agregrar(alumno);
        }
        public void Actualizar(Alumno alumno)
        {
            
            _oDAlumno.Actualizar(alumno);
        }
        public void Eliminar(int id)
        {
            _oDAlumno.Eliminar(id);
        }
    }
}
