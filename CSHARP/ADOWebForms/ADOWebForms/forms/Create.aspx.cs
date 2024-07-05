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
    public partial class Create : System.Web.UI.Page
    {
        ADOEstatusAlumno _oADOEstatusAlumno = new ADOEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            EstatusAlumno oEstatusAlumno = new EstatusAlumno();
            oEstatusAlumno.Clave = txtclave.Text;
            oEstatusAlumno.Nombre = txtnombre.Text;
            int idResultado = _oADOEstatusAlumno.Agregar(oEstatusAlumno);
            lblresultado.Text = "Registrado correctamente";
            txtclave.Text = "";
            txtnombre.Text = "";
        }
    }
}