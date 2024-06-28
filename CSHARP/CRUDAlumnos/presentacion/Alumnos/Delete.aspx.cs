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
            if (!IsPostBack)
            {
                Alumno oAlumno = new Alumno();
                int id = Convert.ToInt32(Request.QueryString["id"] ?? "30");
                oAlumno = nAlumno.Consultar(id);
                lblId.Text = Convert.ToString(oAlumno.id);
                lblNombre.Text = Convert.ToString(oAlumno.nombre);
                lblPA.Text = Convert.ToString(oAlumno.primerApellido);
                lblSA.Text = Convert.ToString(oAlumno.segundoApellido);
                lblCorreo.Text = Convert.ToString(oAlumno.correo);
                lblTel.Text = Convert.ToString(oAlumno.telefono);
                lblFecNac.Text = Convert.ToString(oAlumno.fechaNacimiento);
                lblCURP.Text = Convert.ToString(oAlumno.curp);
                lblEstado.Text = Convert.ToString(oAlumno.idEstadoOrigen);
                lblEstatus.Text = Convert.ToString(oAlumno.idEstatus);
            }
        }



        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            NAlumno oNalumno = new NAlumno();
            int id = Convert.ToInt32(lblId.Text);
            oNalumno.Eliminar(id);
            Response.Redirect($"index.aspx");
        }
    }
}