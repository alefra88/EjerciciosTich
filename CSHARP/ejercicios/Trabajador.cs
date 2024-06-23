using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Trabajador : Persona
    {
        public virtual decimal sueldo { get; set; }
        public Trabajador()
        {

        }
        public Trabajador(string nombre, string apellidos, DateTime fechaNacimiento) : base(nombre, apellidos, fechaNacimiento)
        {

        }
      
        public override string ClaveUnica()
        {
            return nombre.Substring(0, 2) + edad().ToString() + apellidos.Substring(0, 2);
        }
        public virtual  decimal Aguinaldo(int diaslaborados)
        {
            decimal aguinaldo;
            aguinaldo = sueldo / 24 * (diaslaborados / 365);
            return aguinaldo;
        }
        //Polimorfismo
        public override string ToString()
        {
            return "Trabajador: " + nombre + " " + apellidos + "sueldo: " + sueldo.ToString();
        }

    }
}
