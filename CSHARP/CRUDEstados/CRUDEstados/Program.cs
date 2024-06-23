using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD oCRUD = new CRUD();
            
            do
            {
                Console.WriteLine("\n1.- Consultar todos \n2.- Consultar uno \n3.-Agregar \n4.-Actualizar \n5.-Eliminar ");
                Console.WriteLine("selecciona una wea");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Dictionary<int, Estado> dictEstados = oCRUD.ConsultarTodos();
                        foreach (KeyValuePair<int, Estado> estado in dictEstados)
                        {
                            Console.WriteLine($"id:{estado.Key} nombre: {estado.Value.nombre}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("ingresa el id del estado");
                        int id = Convert.ToInt16(Console.ReadLine());
                        Estado estadoA = oCRUD.ConsultarSoloUno(id);
                        Console.WriteLine($"id: {estadoA.id} nombre: {estadoA.nombre}");
                        break;
                    case 3:
                        Estado oEstadoA = new Estado();
                        Console.WriteLine("ingresa el id del estado");
                        oEstadoA.id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Ingresa el nombre del estado");
                        oEstadoA.nombre = Console.ReadLine();
                        oCRUD.Agregar(oEstadoA);
                        break;
                    case 4:
                        Estado oEstadoB = new Estado();
                        Console.WriteLine("ingresa el id del estado");
                        oEstadoB.id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Ingresa el nombre del estado actualizado");
                        oEstadoB.nombre = Convert.ToString(Console.ReadLine());
                        oCRUD.Actualizar(oEstadoB);
                        break;
                    case 5:
                        Console.WriteLine("Ingresa el id del estado a eliminar");
                        int idE = Convert.ToInt16(Console.ReadLine());
                        oCRUD.Eliminar(idE);
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
