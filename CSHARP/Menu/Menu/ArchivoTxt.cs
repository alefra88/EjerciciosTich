using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Menu
{
    internal class ArchivoTxt
    {
        //2. Leer Archivo txt
        //Crear el método MostrarTxt a fin de que muestre en pantalla todos los registros del
        //archivo cuyo nombre recibe como parámetro;
        public static void MostrarTxt(string nombre)
        {
            StreamReader sr = new StreamReader(nombre);
            try
            {


                string str = sr.ReadToEnd();
                Console.WriteLine(str);


            }
            catch (Exception e)
            {
                Console.WriteLine("Ingresa un archivo valido wn");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
        }

        public static void MostrarCSV(string nombre)
        {
            try
            {

                StreamReader sr = new StreamReader(nombre);
                string str = sr.ReadLine();


                while ((str = sr.ReadLine()) != null)
                {
                    foreach (string line in str.Split(','))
                    {
                        Console.WriteLine(line);

                    }

                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Ingresa un archivo valido wn");
                Console.WriteLine(e.Message);
            }
        }
        public static void EscribirTxt(string nombre, bool esNuevo, string formato)
        {
            do
            {
                try
                {
                    string laRuta = @"C:\Users\Tichs\Desktop\bootcamp-AEOG\CSHARP\Menu\" + nombre;

                    Encoding codigo;
                    switch (formato)
                    {
                        case "1":
                            codigo = Encoding.UTF7;
                            break;
                        case "2":
                            codigo = Encoding.UTF8;
                            break;
                        case "3":
                            codigo = Encoding.Unicode;
                            break;
                        case "4":
                            codigo = Encoding.UTF32;
                            break;
                        case "5":
                            codigo = Encoding.ASCII;
                            break;
                        default:
                            codigo = Encoding.ASCII;
                            break;
                    }


                    Console.WriteLine("Escribe el nombre dl alumno");
                    string nombrePersona = Console.ReadLine();
                    Console.WriteLine("Escribe el primero apellido");
                    string apellidoPersona = Console.ReadLine();
                    Console.WriteLine("Escribe el segundo Apellido");
                    string segundoApellido = Console.ReadLine();
                    Console.WriteLine("Escribe la edad del alumno");
                    string edadPersona = Console.ReadLine() + "años";
                    Console.WriteLine("Ingresa el estado del Alumno");
                    string estadoPersona = Console.ReadLine();
                    StreamWriter sr = new StreamWriter(laRuta, esNuevo, codigo);
                    sr.WriteLine($"{nombrePersona},{apellidoPersona},{segundoApellido},{edadPersona},{estadoPersona}");
                    Console.WriteLine("¿Desea agregar otro alumno? (S/N)");
                    string respuesta = Console.ReadLine().Trim().ToUpper();
                    if (respuesta == "N")
                    {
                        esNuevo = false;
                    }
                    sr.Close();
                }


                catch (Exception e)
                {
                    Console.WriteLine("Hubo un error en el procesamiento de archivos");
                    Console.WriteLine(e.Message);
                }

            } while (esNuevo == true);
        }
        public static void Presentacion()
        {

            Console.WriteLine("Ingresa el nombre del archivo");
            string nombreArchivo = Console.ReadLine().Trim();
            if (nombreArchivo.Contains(".txt"))
            {
                Console.WriteLine("Ingresa la ruta del archivo:");
                string rutaArchivo = Console.ReadLine().Trim(); // Leer y limpiar la ruta del archivo

                // Combinar nombre del archivo y ruta para obtener la ruta completa
                string rutaCompleta = Path.Combine(rutaArchivo, nombreArchivo);

                // Llamada al método estático MostrarTxt de la clase ArchivoTxt
                ArchivoTxt.MostrarTxt(rutaCompleta);

            }
            else
            {
                Console.WriteLine("Ingresa la ruta del archivo:");
                string rutaArchivo = Console.ReadLine().Trim(); // Leer y limpiar la ruta del archivo

                // Combinar nombre del archivo y ruta para obtener la ruta completa
                string rutaCompleta = Path.Combine(rutaArchivo, nombreArchivo);

                // Llamada al método estático MostrarTxt de la clase ArchivoTxt
                ArchivoTxt.MostrarCSV(rutaCompleta);
            }
        }
    }
}
