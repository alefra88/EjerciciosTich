using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ADOEstatus oADOEstatus = new ADOEstatus();
            int Elect;
            do
            {

                Console.WriteLine("1.-Consultar todos \n2.- Consultar por id \n3.- Agregar \n4.- Actualizar\n5.- Eliminar");
                Elect = int.Parse(Console.ReadLine());

                switch (Elect)
                {
                    case 1:

                        List<Estatus> _ListEstatus = oADOEstatus.ConsultarT();
                        foreach (Estatus _Estatus in _ListEstatus)
                        {
                            Console.WriteLine($"id:{_Estatus.Id} clave: {_Estatus.Clave} nombre: {_Estatus.Nombre}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Escribe el ID a consultar");
                        int id = Convert.ToInt32(Console.ReadLine());
                        ADOEstatus oADOEstatusID = new ADOEstatus();
                        Estatus estatus = oADOEstatusID.Consultar(id);
                        Console.WriteLine($"id:{estatus.Id} clave: {estatus.Clave} nombre: {estatus.Nombre}");

                        break;

                    case 3:
                        Estatus estatusAgregar = new Estatus();
                        ADOEstatus oADOEstatusClave = new ADOEstatus();
                        Console.WriteLine("Escribe la clave para agregar");
                        estatusAgregar.Clave = (Console.ReadLine());
                        Console.WriteLine("Escribe el nombre del estatus nuevo para agregar");
                        estatusAgregar.Nombre = (Console.ReadLine());
                        oADOEstatusClave.Agregar(estatusAgregar);
                        break;

                    case 4:
                        Estatus estatusActualizar = new Estatus();
                        Console.WriteLine("ID para actualizar");
                        estatusActualizar.Id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Escribe la clave para agregar");
                        estatusActualizar.Clave = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Escribe el nombre del nuevo estatus para actualizar");
                        estatusActualizar.Nombre = Convert.ToString((Console.ReadLine()));
                        oADOEstatus.Actualizar(estatusActualizar);
                        break;
                    case 5:
                       
                        Console.WriteLine("Ingresa el ID a eliminar");
                        int idEliminar = Convert.ToInt16(Console.ReadLine());
                        oADOEstatus.Eliminar(idEliminar);
                        break;

                }
      
            } while (true);
           
        }

    }

}
