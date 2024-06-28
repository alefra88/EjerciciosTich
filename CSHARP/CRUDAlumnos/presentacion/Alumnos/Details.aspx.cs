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
    public partial class Details : System.Web.UI.Page
    {
        NAlumno _oNalumno = new NAlumno();
        int GId = 0;
        decimal Gsueldo = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Alumno oAlumno = new Alumno();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            GId = id;
            Gsueldo = oAlumno.sueldoMensual;
            oAlumno = _oNalumno.Consultar(id);
            lblId.Text = Convert.ToString(oAlumno.id);        
            lblNombre.Text = Convert.ToString(oAlumno.nombre);
            lblPA.Text = Convert.ToString(oAlumno.primerApellido);
            lblSA.Text = Convert.ToString(oAlumno.segundoApellido);
            lblCorreo.Text = Convert.ToString(oAlumno.correo);
            lblTel.Text = Convert.ToString(oAlumno.telefono);
            lblFecNac.Text = Convert.ToString(oAlumno.fechaNacimiento);
            lblCURP.Text= Convert.ToString(oAlumno.curp);
            lblSueldoMe.Text = Convert.ToString(oAlumno.sueldoMensual);
            lblEstado.Text = Convert.ToString(oAlumno.idEstadoOrigen);
            lblEstatus.Text = Convert.ToString(oAlumno.idEstatus);     
            
        }

        protected void btnCalcIMSS_Click(object sender, EventArgs e)
        {
          
            AportacionesIMSS oAportacionesIMSS = new AportacionesIMSS();
            Alumno oAlumno = new Alumno();
            oAlumno.sueldoMensual = Convert.ToDecimal(Request.QueryString["sueldoMensual"]);
            oAportacionesIMSS = _oNalumno.CalcularIMSS(oAlumno.sueldoMensual);
            lblEnfermedadMat.Text = Convert.ToString(oAportacionesIMSS.EnfermedadMaternidad);
            lblInvalidezVida.Text = Convert.ToString(oAportacionesIMSS.InvalidezVida);
            lblRetiro.Text = Convert.ToString(oAportacionesIMSS.Retiro);
            lblCesantia.Text = Convert.ToString(oAportacionesIMSS.Cesantia);
            lblInfonavit.Text = Convert.ToString(oAportacionesIMSS.Infonavit);

        }

        protected void btnCalcISR_Click(object sender, EventArgs e)
        {
            
            ItemTablaISR oItemTablaISR = new ItemTablaISR();
            Alumno oAlumno = new Alumno();
            oAlumno.sueldoMensual = Convert.ToDecimal(Request.QueryString["sueldoMensual"]);
            oItemTablaISR = _oNalumno.CalcularISR(oAlumno.sueldoMensual);
            lblExedLimInf.Text = oItemTablaISR.LimiteInferior.ToString();
            lblLimSup.Text = oItemTablaISR.LimiteSuperior.ToString();
            lblCuotaFija.Text = oItemTablaISR.CuotaFija.ToString();
            lblExedLimInf.Text = oItemTablaISR.Excedente.ToString();
            lblSubsidio.Text = oItemTablaISR.Subsidio.ToString();
            lblISR.Text = oItemTablaISR.ISR.ToString();

        }
    }
}