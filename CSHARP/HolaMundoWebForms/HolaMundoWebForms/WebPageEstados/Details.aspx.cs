using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundoWebForms.WebPageEstados
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["id"]);
            Estado estado = listEstados.Find(x => x.id == id);
            lblidef.Text = estado.id.ToString();
            lblnombredef.Text = estado.nombre;
        }
    }
}