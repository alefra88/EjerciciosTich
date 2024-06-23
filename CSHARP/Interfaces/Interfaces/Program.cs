using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura[] figuras = new IFigura[2];
            figuras[0] = new Itriangulo() { bBase = 3, lLado = 5 };
            figuras[1] = new Icuadrado() { Lado = 4 };


            foreach (var figura in figuras)
            {

                Console.WriteLine($"Area: {figura.Area()} Perimetro: {figura.Perimetro()}");

               
            }
            Console.ReadKey();
        }
    }
}