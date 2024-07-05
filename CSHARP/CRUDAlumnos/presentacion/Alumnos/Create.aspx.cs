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
    public partial class Create : System.Web.UI.Page
    {
    NAlumno _oNAlumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {

            Alumno oAlumno = new Alumno();
            oAlumno.nombre = "Pedro";
            oAlumno.primerApellido = "Paramo";
            oAlumno.segundoApellido = "Chilaquiles";
            oAlumno.correo = "mequiero@morir.com";
            oAlumno.telefono = "1234566666";
            oAlumno.fechaNacimiento = DateTime.Today;
            oAlumno.curp = "DWAP560816MMNTCK59";
            oAlumno.sueldoMensual = 50000;
            oAlumno.idEstadoOrigen = 11;
            oAlumno.idEstatus = 5;
            //_oNAlumno.Agregrar(oAlumno);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno oAlumno = new Alumno();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            oAlumno.id = id;
            oAlumno.nombre = Convert.ToString(txtBxNombre.Text);
            oAlumno.primerApellido = Convert.ToString(txtBxPA.Text);
            oAlumno.segundoApellido = Convert.ToString(txtBxSA.Text);
            oAlumno.correo = Convert.ToString(txtBxCorreo.Text);
            oAlumno.telefono = Convert.ToString(txtBxTelefono.Text);
            oAlumno.fechaNacimiento = Convert.ToDateTime(txtBxFecNac.Text);
            oAlumno.curp = Convert.ToString(txtBxCurp.Text);
            oAlumno.sueldoMensual = Convert.ToDecimal(txtBxSueldo.Text);
            oAlumno.idEstadoOrigen = Convert.ToInt16(txtBxIdEdo.Text);
            oAlumno.idEstatus = Convert.ToInt16(txtBxIdEstatus.Text);
            _oNAlumno.Agregrar(oAlumno);
            Response.Redirect($"index.aspx");
        }

        protected void cvScriptJavascript_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
    }
}