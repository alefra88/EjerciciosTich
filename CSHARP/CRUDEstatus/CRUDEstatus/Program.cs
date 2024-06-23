using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD oCRUD = new CRUD();

            do
            {
                Console.WriteLine("\n1.- Consultar todos \n2.- Consultar uno \n3.-Agregar \n4.-Actualizar \n5.-Eliminar ");
                Console.WriteLine("selecciona una opcion");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        var listaTodos = oCRUD.ConsultarTodos();
                        foreach (var estatus in listaTodos)
                        {
                            Console.WriteLine($"ID:{estatus.id} nombre: {estatus.status}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("ingresa el id del estatus a consultar");
                        int idConsulta = Convert.ToInt16(Console.ReadLine());
                        var estatusConsulta = oCRUD.ConsultarSoloUno(idConsulta);
                        if (estatusConsulta != null)
                        {
                            Console.WriteLine($"ID: {estatusConsulta.id} estatus:{estatusConsulta.status}");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ningún estado con ese ID");
                        }
                        break;
                    case 3:
                        Estatus estatusAgregar = new Estatus();
                        Console.WriteLine("ingresa el id del estatus para agregar");
                        estatusAgregar.id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Ingresa el nombre del estatus paa agregar");
                        estatusAgregar.status = Convert.ToString(Console.ReadLine());
                        oCRUD.Agregar(estatusAgregar);
                        Console.WriteLine("Agregamos el estatus correctamente");
                        break;
                    case 4:

                        Console.WriteLine("ingresa el id del estatus para actualizar");
                        int idConsultarSiExiste = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Actualiza el estatus con su nuevo nombre");
                        string estatusNuevo = Console.ReadLine();
                        oCRUD.Actualizar(idConsultarSiExiste, estatusNuevo);
                        Console.WriteLine("Estatus actualizado conrrectamente");
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
