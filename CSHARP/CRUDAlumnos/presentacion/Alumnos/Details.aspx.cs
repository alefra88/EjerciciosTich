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
            if(!IsPostBack)
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
                lblCURP.Text = Convert.ToString(oAlumno.curp);
                lblSueldoMe.Text = Convert.ToString(oAlumno.sueldoMensual);
                lblEstado.Text = Convert.ToString(oAlumno.idEstadoOrigen);
                lblEstatus.Text = Convert.ToString(oAlumno.idEstatus);
            }

        }

        protected void btnCalcIMSS_Click(object sender, EventArgs e)
        {

            AportacionesIMSS oAportacionesIMSS = new AportacionesIMSS();
            Alumno oAlumno = new Alumno();
            oAlumno.id = Convert.ToInt16(Request.QueryString["id"]);
            oAportacionesIMSS = _oNalumno.CalcularIMSS(oAlumno.id);
            lblEnfermedadMat.Text = Convert.ToString(oAportacionesIMSS.EnfermedadMaternidad);
            lblInvalidezVida.Text = Convert.ToString(oAportacionesIMSS.InvalidezVida);
            lblRetiro.Text = Convert.ToString(oAportacionesIMSS.Retiro);
            lblCesantia.Text = Convert.ToString(oAportacionesIMSS.Cesantia);
            lblInfonavit.Text = Convert.ToString(oAportacionesIMSS.Infonavit);
            lblId.Text = oAlumno.id.ToString();

        }

        protected void btnCalcISR_Click(object sender, EventArgs e)
        {

            ItemTablaISR oItemTablaISR = new ItemTablaISR();
           
            
            oItemTablaISR = _oNalumno.CalcularISR(int.Parse(lblId.Text));
            lblModalLimInf.Text = oItemTablaISR.LimiteInferior.ToString();
            lblModalLimSup.Text = oItemTablaISR.LimiteSuperior.ToString();
            lblModalCuotaFija.Text = oItemTablaISR.CuotaFija.ToString();
            lblModalExcedente.Text = oItemTablaISR.Excedente.ToString();
            lblModalSubsidio.Text = oItemTablaISR.Subsidio.ToString();
            lblModalISR.Text = oItemTablaISR.ISR.ToString();  
          

            //Ventana modal
            string scriptModal = @"<script type='text/javascript'>
                        $(function () {
                            $('#ModalISR').modal('show');
                        });
                    </script>";
            ScriptManager.RegisterStartupScript(this,GetType(),"MuestraModal",scriptModal,false);

        }
    }
}