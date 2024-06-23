using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class HolaMundo
    {
        public static string SaludarEstatico(string nom)

        {
            return " hola " + nom +  " Saludo desde un método estatico";
        }
        public string SaludarNoEstatico(string nombre)
        {
            return " Hola " + nombre + " Saludo desde un método no estatico";
        }
    }
}
