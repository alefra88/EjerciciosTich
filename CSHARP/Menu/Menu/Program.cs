using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Console.WriteLine("\n1.- Iterar nombre\n2.- Numero Máximo\n3.- Primer letra a Mayuscula\n4.- Poliza\n5.- leer archivos txt\n6.- Escribir archivos txt\n7.- Calculo ISR\n8.- condicionales\n9.- ciclos\n10.- cuerpo expresion\n11.- pase por valor y referencia\n12.- manejo de excepciones\n13.- listas\n14.- nivel de acceso\n15.- POO\n16.- F(salir)");
                opcion = Console.ReadLine().ToUpper();



                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingresa tu nombre completo");
                        string nombreCompleto = Console.ReadLine();
                        string[] partesNom = Arreglos.Cadenas(nombreCompleto);

                        break;
                    case "2":
                        Console.WriteLine("Ingresa 5 números");
                        int[] numerosIngresados = new int[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"Número {i + 1}:");
                            while (!int.TryParse(Console.ReadLine(), out numerosIngresados[i]))
                            {
                                Console.WriteLine("Ingresa un número válido");
                                Console.WriteLine($"Número {i + 1}:");
                            }
                        }
                        int numeroMaximo = Arreglos.Enteros(numerosIngresados);
                        Console.WriteLine($"El número máximo ingresado es: {numeroMaximo}");

                        break;

                    case "3":
                        Console.WriteLine("Ingresa un texto por favor");
                        string cadenaDeMain = Console.ReadLine();
                        string cadenaDeNombre = Arreglos.ConvierteATipo(cadenaDeMain);
                        Console.WriteLine(cadenaDeNombre);
                        break;
                    case "4":
                        Poliza.Presentacion();
                        break;
                    case "5":
                        ArchivoTxt.Presentacion();
                        break;
                    case "6":
                        
                        Console.WriteLine("Escribe el nombre del archivo:");
                        string nombreArchivo = Console.ReadLine().Trim();
                        Console.WriteLine("¿Es un archivo nuevo o desea escribir s/n?");
                        bool continuar = Console.ReadLine().Trim().ToUpper() == "S";
                        Console.WriteLine("Elige el tipo de encoding que quiere escribir:\n1.-UTF7\n2.-UTF8\n3.-Unicod\n4.-UTF32\n5.ASCII");
                        string formato = Console.ReadLine().ToUpper();
                        ArchivoTxt.EscribirTxt(nombreArchivo, continuar,formato);
                        break;


                    case "7":
                        ISR.Presentacion();
                        break;
                    case "8":
                        Console.WriteLine("Usted seleccionó condicionales");
                        break;
                    case "9":
                        Console.WriteLine("Usted seleccionó ciclos");
                        break;
                    case "10":
                        Console.WriteLine("Usted seleccionó cuerpo de la expresión");
                        break;
                    case "11":
                        Console.WriteLine("Usted seleccionó pase por valir y referencia");
                        break;
                    case "12":
                        Console.WriteLine("Usted seleccionó Manejo de excepciones");
                        break;
                    case "13":
                        Console.WriteLine("Usted seleccionó listas");
                        break;
                    case "14":
                        Console.WriteLine("Usted seleccionó nivel de acceso");
                        break;
                    case "15":
                        Console.WriteLine("Usted seleccionó POO");
                        break;
                    case "F":

                        break;
                    default:
                        Console.WriteLine("No existe la opción elegida");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            }
            while (opcion != "F");










        }
    }
}
