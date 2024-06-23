using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Menu
{
    internal class Arreglos
    {
        //         Crear la Clase Arreglos, dentro de ella crear el método estático Cadenas, el
        //cual deberá tener la siguiente Interacción
        public static string[] Cadenas(string nombreCompleto)
        {


            string[] partesNombre = nombreCompleto.Split(' ');
            Console.WriteLine("Hola");
            foreach (string parte in partesNombre)
                Console.WriteLine(parte);

            if (partesNombre.Length >= 2)
            {
                string primerApellido = partesNombre[1];
                Console.WriteLine("Apellido Vertical");


                for (int i = 0; i < primerApellido.Length; i++)
                {
                    Console.WriteLine(primerApellido[i]);
                }


            }
            else
            {
                Console.WriteLine("Ponga algo coherente xuxasumare");
            }
            return partesNombre;
        }
        //Crear el método estático Enteros en la clase Arreglos, el cual deberá
        //solicitar 5 números enteros y determinar cual número es el que tiene el
        //valor máximo
        public static int Enteros(int[] numerosIngresados)
        {

            int mayor = numerosIngresados.Max();

            return mayor;
        }
        //        c) En la Clase Arreglos  crear un método estático ConvierteATipoOracion que
        //tome como parámetro un string y regrese otro string habiendo colocado la
        //primera letra de cada palabra en mayúscula.
        //Invocar el método ConvierteATipoOracion de la clase Arreglos, cuando se
        //seleccione la Opción 3 del Menú General.
        public static string ConvierteATipo(string cadenaEntrada)
        {
            //verificamos que no pasen vacios o nulos
            if (string.IsNullOrEmpty(cadenaEntrada))
                return cadenaEntrada;
            //Usamos la clase StringBuilder de System.Text. La cual esta diseñada para construir y manipular cadenas
            StringBuilder resultado = new StringBuilder();
            // variable para ayudarnos a condicionar la capitalizacion true es mayus false es minus
            bool isMayus = true;
            //iteramos a travez del parametro de entrada 
            for (int i = 0; i < cadenaEntrada.Length; i++)
            {
                //accedemos al caracter en la posición i y lo asignamos a c el cual solo almacena un caracter
                char c = cadenaEntrada[i];
                //verificamos que el caracter sea letra, nos devuelve verdadero de serlo
                if (char.IsLetter(c))
                {
                    //verificamos la bandera de Mayus o Minus si da true la vuelve Mayuscula
                    if (isMayus)
                    {
                        //Agregamos el caracter a la cadena que creamos
                        resultado.Append(char.ToUpper(c));
                        //seteamos isMayus a false para que el siguiente caracter sea minus
                        isMayus = false;
                    }
                    else
                    {
                        //si isMayus es falso entonces agregamos el caracter en minuscula
                        resultado.Append(char.ToLower(c));
                    }
                }
                else if (char.IsWhiteSpace(c))
                {
                    resultado.Append(c);
                    isMayus = true;
                }
                else
                {

                    //sino es letra agregamos el caracter sin modificar y seteamos
                    //isMayus a verdadero para que la siguiente letra sea mayus
                    resultado.Append(c);
                    isMayus = false;

                }
            }
            return resultado.ToString();
        }
    }
}
