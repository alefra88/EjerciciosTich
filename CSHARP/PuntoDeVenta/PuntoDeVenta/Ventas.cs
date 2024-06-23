using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PuntoDeVenta
{

    public class Ventas
    {
        //Generamos la lista
        public static List<Articulo> articulosLista = new List<Articulo>();
        internal static void CrearLista()
        {
            //pasamos el endpoint de la lista a una variable
            string archivoLista = @"C:\Users\Tichs\Desktop\bootcamp-AEOG\CSHARP\PuntoDeVenta\Articulos.json";
            StreamReader leerJson = File.OpenText(archivoLista);

            var json = leerJson.ReadToEnd();
            articulosLista = JsonConvert.DeserializeObject<List<Articulo>>(json);
            leerJson.Close();
        }
        public static List<ItemBase> prodNormales = new List<ItemBase>();
        public static decimal CalcularTotal()
        {
            decimal totalVenta = 0.0m;
            foreach (var p in prodNormales)
            {
                totalVenta += p.SubTotal();
            }
            return totalVenta;
        }
        //resumen venta
        public static void Resumen()
        {
            Console.WriteLine("\nResumen venta");
            foreach(var prod in prodNormales)
            {
                prod.Imprimir();
                Console.WriteLine($"Subtotal: {prod.SubTotal():0.00}");
            }
            Console.WriteLine($"Total de venta: ${CalcularTotal()}:0.00");
        }
            
            public static void VentasMethod()
        {
            Articulo articulo = new Articulo();
            while (true)
            {
                Console.WriteLine($"(V) para iniciar una venta o (TV) para terminar la venta");
                string decision = Console.ReadLine().ToLower();
                if (decision == "v")
                {
                    CrearLista();
                    while (true)
                    {
                        Console.WriteLine("Ingresa ID u oprime T para terminar y realizar cobro");
                        string IDProducto = Console.ReadLine();
                        if (IDProducto.ToUpper() == "T")
                        {
                            break;
                        }
                        int IDProductoVenta = Convert.ToInt16(IDProducto);
                        Articulo TVenta = articulosLista.Find(x => x.Id == IDProductoVenta);
                        int tOperacion = TVenta.Tipo;
                        articulo.tOperacion = (TipoVenta)TVenta.Tipo;
                        if (tOperacion == 1)
                        {
                            Console.WriteLine("Ingresa la cantidad de productos");
                            int cantidadVentas = Convert.ToInt32(Console.ReadLine());
                            Item item = new Item(TVenta, cantidadVentas);
                            prodNormales.Add(item);
                        }
                        else if (tOperacion == 2)
                        {
                            Console.WriteLine("Ingresa cantidad productos");
                            int cantidad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresa el porcentaje a descontar");
                            int porcentajeADescontar = Convert.ToInt32(Console.ReadLine());

                            ItemDescuento itemDescuento = new ItemDescuento(TVenta, porcentajeADescontar, cantidad);
                            prodNormales.Add(itemDescuento);
                        }
                        else if (tOperacion == 3)
                        {
                            Console.WriteLine("Ingresa el numero telefonico");
                            string numTel = Console.ReadLine();
                            Console.WriteLine("Ingresa compañia");
                            string compania = Console.ReadLine();
                            Console.WriteLine("Ingresa comision");
                            decimal comision = Convert.ToDecimal(Console.ReadLine());
                            ItemTA itemTa = new ItemTA(TVenta, numTel, compania, comision, 1);
                            prodNormales.Add(itemTa);
                        }

                        //producto nuevo
                        ItemBase nuevoProducto;
                        if (IDProducto.ToLower().Contains("descuento"))
                        {
                            decimal descuento;
                            while (true)
                            {
                                Console.WriteLine("Ingresa el descuento %: ");
                                if (decimal.TryParse(Console.ReadLine(), out descuento))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ingresa un descuento valido, por favor");
                                }
                            }
                        }
                        else if (IDProducto.ToLower().Contains("tiempo aire"))
                        {
                            Console.WriteLine("Ingresa el telefono: ");
                            string telefono = Console.ReadLine();
                            Console.WriteLine("Ingresa la compañia: ");
                            string compania = Console.ReadLine();
                            decimal comision;
                            while (true)
                            {
                                Console.WriteLine("Ingresa comision");
                                if (decimal.TryParse(Console.ReadLine(), out comision))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ingresa comision valida");
                                }
                            }
                        }
                    }
                }
                else if (decision == "tv")
                {
                    Console.WriteLine("Tienda TICH");
                    foreach (var item in prodNormales)
                    {
                        item.Imprimir();
                    }
                    decimal total = prodNormales.Sum(x => x.Total());
                    decimal descuento = prodNormales.Sum(x => x.Total());
                    Console.WriteLine("Total" + total.ToString("c"));
                    break;
                }
                else
                {
                    Console.WriteLine("Ingresa (V) para iniciar venta o (TV) para terminarla");
                }
            }

        }
    }
}
