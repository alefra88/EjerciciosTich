using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal class CalculadoraIMSS
    {
        public static decimal EnfermedadMaternidad(decimal operSBC, decimal operUMA, decimal tipoPersona)
        {
            decimal resultado = 0;
            if (tipoPersona == 1)
                resultado = operUMA * 3 * operSBC * 0.011m;
            else if (tipoPersona == 2)
                resultado = 3 * operSBC * 0.004m;
            return resultado;
        }
        public static decimal InvalidezVida(decimal operSBC, decimal tipoPersona)
        {
            decimal resultado = 0;
            if (tipoPersona == 1)
                resultado = operSBC * 0.0175m;
            else if (tipoPersona == 2)
                resultado = operSBC * 0.00625m;
            return resultado;
        }
        public static decimal Retiro(decimal operSBC, decimal tipoPersona)
        {
            decimal resultado = 0;
            if (tipoPersona == 1)
                resultado = operSBC * 0.02m;
            else if (tipoPersona == 2)
                resultado = operSBC;
            return resultado;
        }
        public static decimal Cesantia(decimal operSBC, decimal tipoPersona)
        {
            decimal resultado = 0;
            if (tipoPersona == 1)
                resultado = operSBC * 0.0315m;
            else if (tipoPersona == 2)
                resultado = operSBC * 0.01125m;
            return resultado;
        }
        public static decimal Infonavit(decimal operSBC, decimal tipoPersona)
        {
            decimal resultado = 0;
            if (tipoPersona == 1)
                resultado = operSBC * 0.05m;
            else if (tipoPersona == 2)
                resultado = operSBC;
            return (decimal)resultado;
        }
        public static decimal Calcular(TipoOperaciones tipoOperacionesIMSS, decimal TipoPersona)
        {
            decimal resultado = 0;
            if (tipoOperacionesIMSS.tOperacion == tipoOperacion.EnfermedadMaternidad)
                resultado = EnfermedadMaternidad(tipoOperacionesIMSS.operSBC, tipoOperacionesIMSS.operUMA, TipoPersona);
            else if (tipoOperacionesIMSS.tOperacion == tipoOperacion.InvalidezVida)
                resultado = InvalidezVida(tipoOperacionesIMSS.operSBC, TipoPersona);
            else if (tipoOperacionesIMSS.tOperacion == tipoOperacion.Retiro)
                resultado = Retiro(tipoOperacionesIMSS.operSBC, TipoPersona);
            else if (tipoOperacionesIMSS.tOperacion == tipoOperacion.Cesantia)
                resultado = Cesantia(tipoOperacionesIMSS.operSBC, TipoPersona);
            else if (tipoOperacionesIMSS.tOperacion == tipoOperacion.Infonavit)
                resultado = Infonavit(tipoOperacionesIMSS.operSBC, TipoPersona);
            return resultado;
        }
        public static void presentacion()
        {
            TipoOperaciones operacionesIMSS = new TipoOperaciones();
            Console.WriteLine("operación a realizar\n1.-Enfermedades y maternidad\n2.-Invalidez y vida\n3.-Retiro\n4.-Cesantia\n5.-Infonavit");
            Console.WriteLine("Selecciona la operacion a realizar ");
            int operacion = Convert.ToInt16(Console.ReadLine());
            operacionesIMSS.tOperacion = (tipoOperacion)operacion;
            Console.WriteLine("Proporcione salario base de cotizacion");
            operacionesIMSS.operSBC = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Proporcione UMA");
            operacionesIMSS.operUMA = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Eres patrón o trabajador\n1.-Patrón\n2.-Trabajador");
            decimal operacionPersona = Convert.ToDecimal(Console.ReadLine());
            operacionesIMSS.tPersona = (tipoPersona)operacionPersona;
            if (operacionPersona < 5)
            {

                if (operacionPersona == 1)
                {
                    decimal resultado = Calcular(operacionesIMSS, operacion);
                    Console.WriteLine($"{operacionesIMSS.tPersona.ToString()} es: {resultado}");
                }
                else
                {
                    decimal resultado = Calcular(operacionesIMSS, operacion);
                    Console.WriteLine($"{operacionesIMSS.tPersona.ToString()} es: {resultado}");
                }
                //if (Console.ReadLine() == string)
                //{

                //}
            }
        }
    }
}
