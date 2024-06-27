using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using business;

namespace presentacion.Alumnos
{
    public partial class Index : System.Web.UI.Page
    {
        NAlumno _oAlumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Alumno> listAlumnos = _oAlumno.Consultar();
            //if (!IsPostBack)
            //{
            //    List<Alumno> listAlumnos = _oAlumno.Consultar();
            //}
        }
    }
}