using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using business;
using entities;

namespace presentacion.Alumnos
{
    public partial class Create : System.Web.UI.Page
    {
    NAlumno _oNAlumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {

            Alumno oAlumno = new Alumno();
            oAlumno.nombre = "Pedro";
            oAlumno.primerApellido = "Paramo";
            oAlumno.segundoApellido = "Chilaquiles";
            oAlumno.correo = "mequiero@morir.com";
            oAlumno.telefono = "1234566666";
            oAlumno.fechaNacimiento = DateTime.Today;
            oAlumno.curp = "DWAP560816MMNTCK59";
            oAlumno.sueldoMensual = 50000;
            oAlumno.idEstadoOrigen = 11;
            oAlumno.idEstatus = 5;
            _oNAlumno.Agregrar(oAlumno);
        }
    }
}