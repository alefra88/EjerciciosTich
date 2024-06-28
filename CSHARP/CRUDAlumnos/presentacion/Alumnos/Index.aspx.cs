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
            CargarGrid();
        }

        protected void gvAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="Page")
            {
                return;
            }
            int numRow = Convert.ToInt16(e.CommandArgument);
            GridViewRow row = gvAlumnos.Rows[numRow];
            TableCell oCelda = row.Cells[0];
            int id = Convert.ToInt16(oCelda.Text);
                switch(e.CommandName)
            {
                case "btnDetalles":
                    Response.Redirect($"Details.aspx?id={id}");
                        break;

                case "btnEditar":
                    Response.Redirect($"Edit.aspx?id={id}");
                    break;
                case "btnEliminar":
                    Response.Redirect($"Delete.aspx?id={id}");
                    break;
            }
        }

        protected void gvAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAlumnos.PageIndex = e.NewPageIndex;
            CargarGrid();
            
        }
        private void CargarGrid()
        {
            List<Alumno> listAlumnos = _oAlumno.Consultar();
            gvAlumnos.DataSource = listAlumnos;
            gvAlumnos.DataBind();
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            Alumno oAlumno = new Alumno();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            oAlumno.id = id;
            Response.Redirect($"Create.aspx?id={id}");
        }
    }
}