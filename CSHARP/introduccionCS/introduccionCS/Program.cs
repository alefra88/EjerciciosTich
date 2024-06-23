using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccionCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaramos variables
            string nombre;
            string primerApellido;
            string segundoApellido;
            string edad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine().Trim();
            Console.WriteLine("Escribe tu primer apellido");
            primerApellido = Console.ReadLine().Trim();
            Console.WriteLine("Escribe tu segundo apellido");
            segundoApellido = Console.ReadLine().Trim();
            Console.WriteLine("Escribe tu edad");
            edad = Console.ReadLine().Trim();
            //retornamos método
            string retornoMetodo = Cadenas.HolaMundo(nombre, primerApellido, segundoApellido, edad);
            Console.WriteLine(retornoMetodo);
            retornoMetodo = Cadenas.HolaMundo2(nombre, primerApellido, segundoApellido, edad);
            Console.WriteLine(retornoMetodo);
            retornoMetodo = Cadenas.HolaMundo3(nombre, primerApellido, segundoApellido, edad);
            Console.WriteLine(retornoMetodo);
            retornoMetodo = Cadenas.GuardarEn();
            Console.WriteLine(retornoMetodo);
            Console.ReadKey();
        }
    }
}
