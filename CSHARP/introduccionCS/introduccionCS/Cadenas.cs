using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccionCS
{
    internal class Cadenas
    {
        public static string HolaMundo(string nom, string pApellido, string sApellido, string edad)
        {
            return "Hola " + nom + ' ' + pApellido + ' ' + sApellido;
        }
        public static string HolaMundo2(string nom, string pApellido, string sApellido, string Edad)
        {
            return string.Format("Hola {0} {1} {2} tiene {3} años", nom, pApellido, sApellido, Edad);
        }
        public static string HolaMundo3(string nom, string pApellido, string sApellido, string Edad)
        {
            string res;
            return  res = $"Gusto en conocerte {nom} {pApellido} {sApellido} ".ToUpper();
        }
        public static string GuardarEn()
        {
            return @"El archivo fue almancenado en: C:\Documentos\Diplomado.Net\JorgeValdiviaRosas.docx";
        }
    }
}



