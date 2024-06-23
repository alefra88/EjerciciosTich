using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Alumno : Persona
    {
        public Alumno()
        {

        }
        public Alumno(string nombre, string apellidos, DateTime fechaNacimiento) : base(nombre, apellidos, fechaNacimiento)
        {

        }
        public override string ClaveUnica()
        {
            return nombre.Substring(0, 2) + apellidos.Substring(0, 2) + fechaNacimiento.ToString().Substring(0, 4);
        }
    }
}
