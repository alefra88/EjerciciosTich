using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using business;
using entities;
namespace presentacion.Alumnos
{
    public partial class Delete : System.Web.UI.Page
    {
        NAlumno nAlumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            Alumno oAlumno = new Alumno();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            nAlumno.Eliminar(id);
        }
    }
}