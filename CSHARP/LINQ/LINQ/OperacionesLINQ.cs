using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LINQ
{


    internal class OperacionesLINQ
    {

        private static List<Alumno> _listAlumnos;
        private static List<Estado> _listEstados;
        private static List<Estatus> _listEstatus;
        private static List<itemISR> _listISR;
        string json, linea;

        public void CargarLists()
        {

            try
            {


                StreamReader archivoJson = new StreamReader(@"C:\Users\Tichs\Desktop\bootcamp-AEOG\CSHARP\LINQ\Alumnos.json");
                json = archivoJson.ReadToEnd();
                archivoJson.Close();
                _listAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(json);

                StreamReader archivoJsonE = new StreamReader(@"C:\Users\Tichs\Desktop\bootcamp-AEOG\CSHARP\LINQ\Estados.json");
                json = archivoJsonE.ReadToEnd();
                archivoJson.Close();
                _listEstados = JsonConvert.DeserializeObject<List<Estado>>(json);

                StreamReader archivoJsonEs = new StreamReader(@"C:\Users\Tichs\Desktop\bootcamp-AEOG\CSHARP\LINQ\Estatus.json");
                json = archivoJsonEs.ReadToEnd();
                archivoJson.Close();
                _listEstatus = JsonConvert.DeserializeObject<List<Estatus>>(json);

                StreamReader archivoJsonList = new StreamReader(@"C:\Users\Tichs\Desktop\bootcamp-AEOG\CSHARP\LINQ\tISR.csv");
                _listISR = new List<itemISR>();
                while ((linea = archivoJsonList.ReadLine()) != null)
                {
                    string[] lineas = linea.Split(',');
                    itemISR oISR = new itemISR();
                    oISR.LimInf = Convert.ToDecimal(lineas[1]);
                    oISR.LimSup = Convert.ToDecimal(lineas[2]);
                    oISR.CuotaFija = Convert.ToDecimal(lineas[3]);
                    oISR.PorExced = Convert.ToDecimal(lineas[4]);
                    oISR.Subsidio = Convert.ToDecimal(lineas[5]);
                    _listISR.Add(oISR);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo algún problema, verifica bien la info");
                Console.WriteLine(e.Message);
            }
            finally
            {
            }
        }
        public void Consultar()
        {
            //De la lista de estados, obtener el estado que tiene el id = 5  
            Estado estadoIDFive = _listEstados.Find(x => x.Id == 5);
            Console.WriteLine($"id encontrado:{estadoIDFive.Id}");
            //De la lista de alumnos obtener a los alumnos cuyo idEstado 
            //29 y 13, Ordenado por nombre
            var oAlumnos =
    from alumno in _listAlumnos where alumno.Id == 3 || alumno.Id == 4 orderby alumno.Nombre ascending select alumno;  /*_listAlumnos.FindAll(x => x.Id == 1 || x.Id == 1);*/
            foreach (var a in oAlumnos)
            {

                Console.WriteLine($"ID del alumno: {a.Id}, Nombre del alumno: {a.Nombre}");
            }
            //De la lista de alumnos obtener los alumnos que son IdEstado
            //19 y 20 y además de que estén en el estatus 4 o 5

            var oAlumnos2 = from alumno in _listAlumnos
                            where alumno.IdEstado == 19 && alumno.IdEstado == 20 && alumno.IdEstatus == 4 && alumno.IdEstatus == 5
                            select alumno;
            foreach (var a in oAlumnos2)
            {
                Console.WriteLine(@"El alumno tiene el id de estado: {a.IdEstado} y el id de estatus: {a.IdEstatus}");
            }
            //            Obtener una lista de los alumnos que tienen calificación
            //aprobatoria, considerando esta como 6 o mayor, ordenado por
            //calificación del mayor al menor
            var alumnosListCal = (from alumno in _listAlumnos
                                  where alumno.Calificacion >= 6
                                  orderby alumno.Calificacion descending
                                  select alumno).ToList();
            foreach (var a in alumnosListCal)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"ID:{a.Id} Nombre: {a.Nombre} Calificacion: {a.Calificacion}");
            }
            /*Obtener la calificación promedio de los alumnos */
            var promedioAlumnos = _listAlumnos.Average(a => a.Calificacion);
            Console.WriteLine("\n");
            Console.WriteLine(@"El promedio de calificación es: {0}", promedioAlumnos);
            Console.WriteLine("------------------------------------------------------\n----------------------------------");

            /*En caso de que ningún alumno tenga 10, sumarles un punto 
            de calificación, y en caso de que todos estén entre 6 y 7 sumarles 
            dos puntos.  */
            bool aumentarCal = _listAlumnos.All(x => x.Calificacion != 10);
            if (aumentarCal)
            {
                _listAlumnos.ForEach(a => a.Calificacion++);
            }
            bool alumnosConSeis = _listAlumnos.All(x => x.Calificacion >= 6 && x.Calificacion <= 7);
            if (alumnosConSeis)
            {
                _listAlumnos.ForEach(a => a.Calificacion += 2);
            }
            foreach (var a in _listAlumnos)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"ID:{a.Id} Nombre: {a.Nombre} Calificacion: {a.Calificacion}");
            }
            /*Mostar en la consola los siguientes datos, de aquellos 
            alumnos que estén en estatus 3: 
                • idAlumnos, 
                • nombreAlumno, 
                • nombre del Estado al que pertenece*/
            var alumnosStatusTres = from alumno in _listAlumnos
                                    join estado in _listEstados on alumno.Id equals estado.Id
                                    where alumno.IdEstatus == 4
                                    select new { nombreEstado = estado.Nombre, nombreAlumno = alumno.Nombre, idAlumnos = alumno.Id };
            foreach (var a in alumnosStatusTres)
            {
               
                Console.WriteLine($"ID:{a.idAlumnos} Nombre: {a.nombreAlumno}  estado: {a.nombreEstado}");

            }
            /*Mostar en la consola los siguientes datos, de aquellos 
            alumnos que estén en estatus 2, ordenado por nombre del Alumno: 
            • idAlumnos, 
            • nombreAlumno, 
            • nombre del Estatus en que se encuentran */
            var alumnosStatusDos = from alumno in _listAlumnos
                                   join estatus in _listEstatus on alumno.Id equals estatus.Id
                                   orderby alumno.Nombre
                                   where alumno.IdEstatus == 4
                                   select new {nombreEstatus = estatus.Nombre,nombreAlumno=alumno.Nombre, idAlumnos=alumno.Id };
                                    
            foreach (var a in alumnosStatusDos)
            {

                Console.WriteLine($"ID:{a.idAlumnos} Nombre: {a.nombreAlumno}  estatus: {a.nombreEstatus}");
            }
            /*Calcular el impuesto para un sueldo mensual de 22,000, y 
            mostrarlo en la consola: */
            decimal sueldoMensual = 50000;
            var isrParaSueldo = _listISR.FirstOrDefault(isr =>
    sueldoMensual >= isr.LimInf && (sueldoMensual <= isr.LimSup || isr.LimSup == 0));

            // Verificamos que se encontró un rango de ISR válido
            if (isrParaSueldo != null)
            {
                // Calculamos el excedente sobre el límite inferior del rango
                decimal excedente = Math.Max(0, sueldoMensual - isrParaSueldo.LimInf);

                // Calculamos el ISR para la quincena según la fórmula especificada
                decimal isrCalculado = (excedente * isrParaSueldo.PorExced) + isrParaSueldo.CuotaFija - isrParaSueldo.Subsidio;

                // Mostramos el ISR calculado en la consola
                Console.WriteLine($"El ISR para la quincena es: {isrCalculado}");
            }
            else
            {
                Console.WriteLine("No se encontró un rango de ISR válido para el sueldo quincenal proporcionado.");
            }

        }
    }
}
