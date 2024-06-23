using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Instructor: Trabajador
    {
  
        public decimal cuotaHora { get; set; }

        public Instructor()
        {

        }
        public Instructor(string nombre, string apellidos, DateTime fechaNacimiento) : base(nombre, apellidos, fechaNacimiento)
        {

        }
        /// <summary>
        /// Polimorfirmo
        /// </summary>
        /// <returns></returns>
        public override string ClaveUnica()
        {
            return "I" + nombre.Substring(0, 2) + edad().ToString() + apellidos.Substring(0, 2);
        }
        public decimal CalcularSueldo(int horaslaborados)
        {
            return cuotaHora * horaslaborados;
        }
    }
}
