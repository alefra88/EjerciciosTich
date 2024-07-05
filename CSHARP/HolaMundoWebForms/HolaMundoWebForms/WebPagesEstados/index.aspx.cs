using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundoWebForms.WebPagesEstados
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Estado> listaEstados = new List<Estado>
            {
                new Estado{id =1, nombre="Chiapas"},
                new Estado{id =2, nombre="Yucatan"},
                new Estado{id =3, nombre="Campeche"},
                new Estado{id =4, nombre="oaxaca"}

            };
                ddlEstados.DataSource = listaEstados;
                ddlEstados.DataTextField = "nombre";
                ddlEstados.DataValueField = "id";
                ddlEstados.DataBind();
            }


        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(ddlEstados.SelectedValue);
            Response.Redirect($"Details.aspx?id={id}");
        }
    }
}