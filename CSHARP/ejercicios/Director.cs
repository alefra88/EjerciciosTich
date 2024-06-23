using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Director : Trabajador
    {
        public decimal bono { get; set; }

        public Director()
        {

        }
        public Director(string nombre, string apellidos, DateTime fechaNacimiento) : base(nombre, apellidos, fechaNacimiento)
        {
            

        }
        public override decimal Aguinaldo(int diaslaborados)
        {
            decimal aguinaldo;
            aguinaldo = sueldo / 24 * (diaslaborados / 365) + 4 * bono;
            return aguinaldo;
        }

        public override string ToString()
        {
            return "Director: " + nombre + " " + apellidos + "bono: " + sueldo.ToString();
        }
    }
}
