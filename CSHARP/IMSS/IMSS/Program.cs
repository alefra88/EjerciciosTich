using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                CalculadoraIMSS.presentacion();
                Console.ReadKey();
                //limpia la consola
                Console.Clear();
                Console.WriteLine("¿Quieres hacer otro calculo? presiona (S/N)");
                string respuesta = Console.ReadLine();
                if (respuesta.Trim().ToUpper() != "S")
                {
                    continuar = false;
                }
                else
                {
                    continuar=true;                   
                    Console.ReadKey();
                }
            }
            
        }
    }
}
