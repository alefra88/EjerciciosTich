using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class EjemploController : Controller
    {
        // GET: Ejemplo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            // Lógica para determinar el saludo según la hora del día
            string saludo;
            if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 12)
            {
                saludo = "Buenos días guapo!";
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 19)
            {
                saludo = "Buenas tardes guapetón!";
            }
            else
            {
                saludo = "Buenas noches vampiro!";
            }

            // Construir el mensaje completo
            string mensaje = $"Bienvenido<br/>Hoy es {DateTime.Now:dd/MM/yyyy hh:mm:ss tt}<br/>{saludo}";

            ViewBag.Mensaje = mensaje; // Pasar el mensaje a la vista

            return View();
        }
      public ActionResult Ciclos()
        {
            Dictionary<string, string> newDictionary = new Dictionary<string, string>
        {
            {"HTTP","Es un  protocolo de acceso..." },
            {"Clase","Es una plantilla para la creacion de objetos" },
            {"HTML","Es un lenguaje de marcado que se utiliza" }
        };
            ViewBag.newDictionary = newDictionary;

            return View();
        }

        
    }
}
   
