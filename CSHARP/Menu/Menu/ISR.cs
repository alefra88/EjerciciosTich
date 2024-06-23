using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Menu
{
    internal class ISR
    {
        

        public static void CrearTabla(string nombreArchivo)
        {
            
            try
            {
                
                string linea;
                int i = 0;
                StreamReader archivoList = new StreamReader(@"C:\Users\Tichs\Desktop\bootcamp-AEOG\CSHARP\Menu\" + nombreArchivo);
                decimal[,] ISR = new decimal[21,6];
                while ((linea = archivoList.ReadLine()) != null)
                {
                    string[] lineas = linea.Split(',');

                    ISR[i,0] = Convert.ToDecimal(lineas[1]);
                    ISR[i,1] = Convert.ToDecimal(lineas[2]);
                    ISR[i,2] = Convert.ToDecimal(lineas[3]);
                    ISR[i,3] = Convert.ToDecimal(lineas[4]);
                    ISR[i,4] = Convert.ToDecimal(lineas[5]);
                    i++;
                    

                }
                Calcular(ISR);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error al leer el archivo"+ e.Message);
            }
            finally
            {
               
            }
            


        }
        public static void Calcular(decimal[,] ISR)
        {
            Console.WriteLine("Ingresa tu sueldo");
            decimal sueldoIngresado = Convert.ToDecimal(Console.ReadLine());
            sueldoIngresado = sueldoIngresado / 2;
            decimal limInf = 0;
            decimal limSup = 0;
            decimal cuotaFija = 0;
            decimal subsidio = 0;
            decimal porcentaje = 0;
            for (int i = 0; i < ISR.GetLength(0); i++)
            {
                for (int j =0; j < ISR.GetLength(0); j++)
                {
                    if(sueldoIngresado>= ISR[j, 0] && sueldoIngresado <= ISR[j,1])
                    {
                        limInf = ISR[j, 0];
                        limSup = ISR[j, 1];
                        cuotaFija = ISR[j, 2];
                        porcentaje = ISR[j, 3];
                        subsidio = ISR[j, 4];
                        
                    }
                }
            }
            
            decimal excedente = (sueldoIngresado - limInf) * porcentaje / 100;
            decimal impuesto = (cuotaFija + excedente) - subsidio;
            Console.WriteLine(impuesto);
        }
        public static void Presentacion()
        {
            Console.WriteLine("Ingresa el nombre del archivo");
            string nombreArchivo = Console.ReadLine();
            CrearTabla(nombreArchivo);
        }
    }
}
