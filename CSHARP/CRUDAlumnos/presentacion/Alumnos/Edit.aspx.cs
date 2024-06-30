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
        NAlumno _oNalumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Alumno alumno = new Alumno();
                int id = Convert.ToInt32(Request.QueryString["id"]);
                alumno = _oNalumno.Consultar(id);
                txtBxNombre.Text = Convert.ToString(alumno.nombre);
                txtBxPA.Text = Convert.ToString(alumno.primerApellido);
                txtBxSA.Text = Convert.ToString(alumno.segundoApellido);
                txtBxCorreo.Text = Convert.ToString(alumno.segundoApellido);
                txtBxTelefono.Text = Convert.ToString(alumno.telefono);
                txtBxFecNac.Text = Convert.ToString(alumno.fechaNacimiento);
                txtBxCurp.Text = Convert.ToString(alumno.curp);
               txtBxSueldo.Text = Convert.ToString(alumno.sueldoMensual);
                txtBxIdEdo.Text = Convert.ToString(alumno.idEstadoOrigen);
                txtBxIdEstatus.Text = Convert.ToString(alumno.idEstatus);
                
            }

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Alumno oNalumno = new Alumno();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            oNalumno.id = id;
           oNalumno= _oNalumno.Consultar(id);
            oNalumno.nombre = Convert.ToString(txtBxNombre.Text);
            oNalumno.primerApellido = Convert.ToString(txtBxPA.Text);
            oNalumno.segundoApellido = Convert.ToString(txtBxSA.Text);
            oNalumno.correo = Convert.ToString(txtBxPA.Text);
            oNalumno.fechaNacimiento=Convert.ToDateTime(txtBxFecNac.Text);
            oNalumno.curp = Convert.ToString(txtBxCurp.Text);
            oNalumno.idEstadoOrigen = int.Parse((txtBxIdEdo.Text));
            oNalumno.sueldoMensual=Convert.ToDecimal(txtBxSueldo.Text);
            oNalumno.idEstatus = int.Parse(txtBxIdEstatus.Text);
            _oNalumno.Actualizar(oNalumno);
            Response.Redirect($"index.aspx");
        }
    }
}