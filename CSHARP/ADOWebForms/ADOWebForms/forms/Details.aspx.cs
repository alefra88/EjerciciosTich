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
    public partial class Details : System.Web.UI.Page
    {
        ADOEstatusAlumno _oADOEstatusAlumno = new ADOEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                List<EstatusAlumno> list = _oADOEstatusAlumno.ConsultarT();
                int id = Convert.ToInt16(Request.QueryString["id"]);

                EstatusAlumno estatus = list.Find(x => x.Id == id);
                lbliddef.Text = estatus.Id.ToString();
                lblclavedef.Text = estatus.Clave.ToString();
               lblnombredef.Text = estatus.Nombre.ToString();
            
        }
    }
}