using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using business;
using entities;
namespace HolaMundoWebServiceASMX
{
    /// <summary>
    /// Descripción breve de WSAlumnos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WSAlumnos : System.Web.Services.WebService
    {

        NAlumno oNAlumno = new NAlumno();
        [WebMethod]//permite exponer el método
        public AportacionesIMSS CalCularIMSS(int id) => oNAlumno.CalcularIMSS(id);
        
         //AportacionesIMSS imss = oNAlumno.CalcularIMSS(id);
           // return oNAlumno.CalcularIMSS(id);// primera vertiente

        [WebMethod]//permite exponer el método
        public ItemTablaISR CalcularISR(int id)
        {
            return oNAlumno.CalcularISR(id);
        }

    }
}
