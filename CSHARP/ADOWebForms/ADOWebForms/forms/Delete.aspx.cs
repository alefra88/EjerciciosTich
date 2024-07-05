using ADOWebForm.ADO;
using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.forms
{
    public partial class Delete : System.Web.UI.Page
    {
    ADOEstatusAlumno _oADOEstatusALumno = new ADOEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EstatusAlumno> list = _oADOEstatusALumno.ConsultarT();
            int id = Convert.ToInt16(Request.QueryString["id"]);

            EstatusAlumno estatus = list.Find(x => x.Id == id);
            lbliddef.Text = estatus.Id.ToString();
            lblclavedef.Text = estatus.Clave.ToString();
            lblnombredef.Text = estatus.Nombre.ToString();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
           int idEliminar = Convert.ToInt16(Request.QueryString["id"]);
            _oADOEstatusALumno.Eliminar(idEliminar);
            Response.Redirect($"Index.aspx");
        }
    }
}