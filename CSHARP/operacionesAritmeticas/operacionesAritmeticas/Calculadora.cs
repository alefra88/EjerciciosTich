using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesAritmeticas
{
    internal class Calculadora
    {
        public static decimal Sumar(decimal operA, decimal operB)
        {
            return operA + operB;
        }
        public static decimal Restar(decimal operA, decimal operB)
        {
            return operA - operB;
        }
        public static decimal Multiplicacion(decimal operA, decimal operB)
        {
            return operA * operB;
        }
        public static decimal Dividir(decimal operA, decimal operB)
        {
            return operA / operB;
        }
        public static decimal Producto(decimal operA, decimal operB)
        {
            return operA % operB;
        }
        public static decimal Operacion(OperacionAritmetica objetoOperacionAritmetica)
        {
            decimal resultado = 0;
            if (objetoOperacionAritmetica.tOperacion == tipoOperacion.sumar)
                resultado = Calculadora.Sumar(objetoOperacionAritmetica.operandoA, objetoOperacionAritmetica.operandoB);
            else if (objetoOperacionAritmetica.tOperacion == tipoOperacion.restar)
                resultado = Calculadora.Restar(objetoOperacionAritmetica.operandoA, objetoOperacionAritmetica.operandoB);
            else if (objetoOperacionAritmetica.tOperacion == tipoOperacion.multiplicar)
                resultado = Calculadora.Multiplicacion(objetoOperacionAritmetica.operandoA, objetoOperacionAritmetica.operandoB);
            else if (objetoOperacionAritmetica.tOperacion == tipoOperacion.dividir)
                resultado = Calculadora.Dividir(objetoOperacionAritmetica.operandoA, objetoOperacionAritmetica.operandoB);
            else if (objetoOperacionAritmetica.tOperacion == tipoOperacion.producto)
                resultado = Calculadora.Producto(objetoOperacionAritmetica.operandoA, objetoOperacionAritmetica.operandoB);
            return resultado;
        }
        internal static Resultado Simultaneas(decimal numA, decimal numB)
        {
            Resultado objetoResultado = new Resultado();
            objetoResultado.suma = Sumar(numA, numB);
            objetoResultado.resta = Restar(numA, numB);
            objetoResultado.multiplicacion = Multiplicacion(numA, numB);
            objetoResultado.division = Dividir(numA, numB);
            objetoResultado.producto = Producto(numA, numB);
            return objetoResultado;
        }
        public static void Presentacion()
        {
            OperacionAritmetica objOperacionAritmetica = new OperacionAritmetica();
            Console.WriteLine("Selecciona la operacion a realizar \n1.- sumar\n2.-Resta\n3. -Multiplicacion\n4.-Division\n5.Producto\n6.Todas");
            Console.WriteLine("Selecciona la operacion a realizar");
            int OperacionR = Convert.ToInt16(Console.ReadLine());
            objOperacionAritmetica.tOperacion = (tipoOperacion)OperacionR;
            Console.WriteLine("Proporciona el primer operador");
            objOperacionAritmetica.operandoA = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Proporciona el segundo operador");
            objOperacionAritmetica.operandoB = Convert.ToDecimal(Console.ReadLine());


            if (OperacionR < 6)
            {
                decimal resultado = Operacion(objOperacionAritmetica);
                Console.WriteLine($"El resultado de es: {resultado}");
            }
            else if (OperacionR == 6)
            {

                Resultado resultado = Simultaneas(objOperacionAritmetica.operandoA,objOperacionAritmetica.operandoB);
                Console.WriteLine($"La suma es: {resultado.suma}");
                Console.WriteLine($"La resta es: {resultado.resta}");
                Console.WriteLine($"La multiplicacion es: {resultado.multiplicacion}");
                Console.WriteLine($"La division es: {resultado.division}");
                Console.WriteLine($"El producto es: {resultado.producto}");
                
                
            };

        }
    }
}