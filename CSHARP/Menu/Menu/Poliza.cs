using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//b) Crear la Clase Poliza y dentro de ella el método llamado Calcular, el cual 
//recibirá los siguientes parámetros: 
//a.Fecha de inicio de Vigencia 
//b. El tipo de periodo por el que se desea la póliza (años, meses, días), 
//c.La cantidad de periodos que se desean que tenga duración la póliza 
//d. SumaAsegurada 
//e. Fecha de Nacimiento 
//f. 
//Género del asegurado: 
//El método deberá calcular los siguientes valores y regresarlos en un tipo de 
//dato PolizaResultado: 
//a.Fecha de Término de la Póliza 
//b. Prima 
//Prima = Suma Asegurada por el Factor correspondiente por (días de duración de 
//la póliza/360)
namespace Menu
{
    internal class Poliza
    {
        private decimal[,] factoresPrima = new decimal[12, 4]
        {
            //primer col edad minima,segunda col edad max, tercera col género, cuarta col factor
        // Edad 0-20 fem
        { 0m, 20m, 0m, 0.05m },
        // Edad 21-30 fem
        { 21m, 30m, 0m, 0.1m },
        // Edad 31-40 fem
        { 31m, 40m, 0m, 0.4m },
        // Edad 41-50 fem
        { 41m, 50m, 0m, 0.5m },
        // Edad 51-60 fem
        { 51m, 60m, 0m, 0.65m },
        // Edad 61 y más fem
        { 61m, 80m, 0m, 0.85m },
        //edad 0-20 hom
        {0m,20m,1m,0.05m },
        // edad 21-30 hom
        {21m, 30m,1 , 0.1m },
        // edad 31-40 hom
        {31m,40m,1,0.4m },
        //edad 41-50 hom
        {41m,50m,1m,0.55m },
        //edad 51-60 hom
        {51m,60m,1,0.7m },
        //edad 61-80
        {61m,80m,1,0.9m }
        };
        //metodo Calcular
        public PolizaResultado Calcular(DateTime fechaInicioVigencia, string tipoPeriodo, int cantidadDePeriodos, decimal sumaAsegurada, DateTime fechaNacimiento, bool genero)
        {
            PolizaResultado polizaResultado = new PolizaResultado();


            switch (tipoPeriodo.ToLower())
            {
                case "años":
                    polizaResultado.FechaTermino = fechaInicioVigencia.AddYears(cantidadDePeriodos);
                    break;
                case "meses":
                    polizaResultado.FechaTermino = fechaInicioVigencia.AddMonths(cantidadDePeriodos);
                    break;
                case "días":
                    polizaResultado.FechaTermino = fechaInicioVigencia.AddDays(cantidadDePeriodos);
                    break;
                default:
                    throw new ArgumentException("El tipo de periodo especificado no es válido.");
            }

            // Calcular la edad del asegurado
            DateTime ahora = DateTime.Today;
            int edad = ahora.Year - fechaNacimiento.Year;

            TimeSpan difFechas = polizaResultado.FechaTermino.Subtract(fechaInicioVigencia);
            // Buscar en la matriz factoresPrima
            for (int i = 0; i < factoresPrima.GetLength(0); i++)
            {
                decimal edadMinima = factoresPrima[i, 0];
                decimal edadMaxima = factoresPrima[i, 1];
                decimal generoMatriz = factoresPrima[i, 2];
                decimal factor = factoresPrima[i, 3];

                // Comprobar si la edad del asegurado está dentro del rango y si el género coincide
                if (edad >= edadMinima && edad <= edadMaxima && (genero ? 1 : 0) == generoMatriz)
                {
                    // Calcular la prima
                    polizaResultado.Prima = sumaAsegurada * factor * ((decimal)difFechas.Days / 360);
                }
            }




            return polizaResultado;
        }

       
        public static void Presentacion()
        {
            Poliza poliza = new Poliza();
            Console.WriteLine("proporciona la fecha de inicio de vigencia formato yyyy-MM-dd");
            DateTime fechaInicioVigencia;
            while (true)
            {
                if (DateTime.TryParse(Console.ReadLine(), out fechaInicioVigencia))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Formato de fecha incorrecto. Ingresa yyyy-MM-dd");
                }
            }
            Console.WriteLine("¿Para cuanto tiempo quieres la poliza? ejemplo 2 años, 3 meses, 11 dias");
            string[] partesPeriodo = Console.ReadLine().Split(' ');
            if (partesPeriodo.Length != 2)
            {
                throw new ArgumentException("Proporciona la información correcta, ejemplo 2 años, 3 meses,  11 días");
            }
            int cantidadPeriodos = int.Parse(partesPeriodo[0]);
            string tipoPeriodo = partesPeriodo[1].ToLower();

            Console.WriteLine("Proporciona la suma asegurada, ejem, 10000");
            decimal sAsegurada = decimal.Parse(Console.ReadLine());

            Console.WriteLine("proporciona la fecha de nacimiento del asegurado ejem,(yyyy-MM-dd)");
            DateTime fechaNacimiento;
            while (true)
            {
                if (DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
                    break;
                else
                {
                    Console.WriteLine("proporciona una fecha correcta de acuerdo al ejemplo, (yyyy-MM-dd)");
                }
            }
            Console.WriteLine("Proporciona el genero del asegurado(masculino/femenino)");
            string generoStr = Console.ReadLine();
            bool generoMasc = generoStr.ToLower() == "masculino";

            // Calcular los resultados utilizando el método Calcular
            PolizaResultado resultado = poliza.Calcular(fechaInicioVigencia, tipoPeriodo, cantidadPeriodos, sAsegurada, fechaNacimiento, generoMasc);

            // Mostrar los resultados formateados
            Console.WriteLine($"La Póliza vencerá el: {resultado.FechaTermino:dd 'de' MMMM 'de' yyyy}");
            Console.WriteLine($"La prima a pagar es de: {resultado.Prima.ToString("C")}");

        }
    }
}
