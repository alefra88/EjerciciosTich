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
    public partial class Details : System.Web.UI.Page
    {
    NAlumno _oNalumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            Alumno oAlumno = new Alumno();
             int id = Convert.ToInt32(Request.QueryString["id"]);
          oAlumno = _oNalumno.Consultar(id);

        }
    }
}