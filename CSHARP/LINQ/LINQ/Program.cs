using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperacionesLINQ oper = new OperacionesLINQ();
            oper.CargarLists();
            oper.Consultar();
            Console.ReadKey();
        }
    }
}
