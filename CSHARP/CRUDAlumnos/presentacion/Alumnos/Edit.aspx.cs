using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using entities;
using business;
namespace presentacion.Alumnos
{
    public partial class Edit : System.Web.UI.Page
    {
        NAlumno oNalumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            int id = Convert.ToInt32(Request.QueryString["id"] ?? "13");
            alumno = oNalumno.Consultar(id);
            alumno.nombre = "juanito";
            alumno.primerApellido = "Chamuco";
            alumno.segundoApellido = "Carnaval";
            alumno.correo = "perritotriste@gmail.com";
            alumno.telefono = "1234567891";
            alumno.fechaNacimiento = DateTime.Now;
            alumno.curp = "BMZP041226HSPYKD79";
            alumno.sueldoMensual = 40000;
            alumno.idEstadoOrigen = 12;
            alumno.idEstatus = 5;
            oNalumno.Actualizar(alumno);
        }
    }
}