using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombre;

            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();
            //Para invocar un método estatico
            String retornoMetodo = HolaMundo.SaludarEstatico(nombre);
            Console.WriteLine(retornoMetodo);

            //Para invocar un método no estatico
            HolaMundo objetoSaludo = new HolaMundo();

            retornoMetodo = objetoSaludo.SaludarNoEstatico(nombre);

            Console.WriteLine(retornoMetodo);

            Console.ReadKey();
        }
    }
}
