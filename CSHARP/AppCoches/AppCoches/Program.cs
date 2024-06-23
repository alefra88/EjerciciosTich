using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un arreglo de coches para inicializar el StructConcesionario
            Coche[] coches = new Coche[5]; // Por ejemplo, un concesionario con capacidad para 5 coches
            StructConcecionario structConcesionario = new StructConcecionario(coches, 5);

            // Crear un objeto Concecionario utilizando el StructConcesionario inicializado
            Concecionario concesionario = new Concecionario(structConcesionario);
            Console.WriteLine("Ingrese el ID del coche:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la marca del coche:");
            string marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del coche:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese los kilómetros del coche:");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del coche:");
            decimal precio = Convert.ToDecimal(Console.ReadLine());
            Coche miCoche = new Coche(id, marca, modelo, km, precio);
            Console.WriteLine(miCoche.ToString());
            concesionario.aniadirCoche(miCoche);
            concesionario.mostrarCoches();
            Console.ReadLine();
            
        }
       
        
    }
}
