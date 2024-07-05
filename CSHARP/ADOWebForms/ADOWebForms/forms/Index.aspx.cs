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
    public partial class Index : System.Web.UI.Page
    {
        ADOEstatusAlumno _oADOEstatusAlumnos = new ADOEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<EstatusAlumno> listaEstatus = _oADOEstatusAlumnos.ConsultarT();
                {
                    ddlEstatusAlumnos.DataSource = listaEstatus;
                    ddlEstatusAlumnos.DataTextField = "nombre";
                    ddlEstatusAlumnos.DataValueField = "id";
                    ddlEstatusAlumnos.DataBind();
                    dgvEstatusAlumnos.DataSource = listaEstatus;
                    dgvEstatusAlumnos.DataBind();
                }
            }

        }

        protected void btbDetalles_Click(object sender, EventArgs e)
        {
            string id = ddlEstatusAlumnos.SelectedValue;
            Response.Redirect($"Details.aspx?id={id}");
            
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = ddlEstatusAlumnos.SelectedValue;
            Response.Redirect($"Create.aspx?id={id}");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = ddlEstatusAlumnos.SelectedValue;
            Response.Redirect($"Delete.aspx?id={id}");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string id = ddlEstatusAlumnos.SelectedValue;
            Response.Redirect($"Edit2.aspx?id={id}");
        }
    }
}