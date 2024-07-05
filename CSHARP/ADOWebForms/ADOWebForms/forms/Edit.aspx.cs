using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ADOWebForm.ADO;

namespace ADOWebForms.forms
{
    public partial class Edit : System.Web.UI.Page
    {
        ADOEstatusAlumno _oADOEstatusAlumno = new ADOEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                List<EstatusAlumno> list = _oADOEstatusAlumno.ConsultarT();
                int id = Convert.ToInt16(Request.QueryString["id"]);
                EstatusAlumno estatus = list.Find(x => x.Id == id);
                txtID.Text = estatus.Id.ToString();
                txtclave.Text = estatus.Clave.ToString();
                txtnombre.Text = estatus.Nombre.ToString();
                
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            EstatusAlumno estatus = new EstatusAlumno();
            estatus.Id = Convert.ToInt16(lbl.Text);
            estatus.Clave =txtclave.Text;
            estatus.Nombre = txtnombre.Text;
            _oADOEstatusAlumno.Actualizar(estatus);
            Response.Redirect("Index.aspx");
        }
    }
}