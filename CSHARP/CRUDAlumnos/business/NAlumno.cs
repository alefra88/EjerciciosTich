using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;
using System.Configuration;
using Newtonsoft.Json;
namespace business
{
    public class NAlumno
    {
        DAlumno _oDAlumno = new DAlumno();


        public List<Alumno> Consultar()
        {
            List<Alumno> alumnoList = new List<Alumno>();
            alumnoList = _oDAlumno.Consultar();
            return alumnoList;
        }
        public Alumno Consultar(int id)
        {
            Alumno oAlumno = new Alumno();
            oAlumno = _oDAlumno.Consultar(id);
            return oAlumno;
        }
        public void Agregrar(Alumno alumno)
        {

            _oDAlumno.Agregrar(alumno);
        }
        public void Actualizar(Alumno alumno)
        {

            _oDAlumno.Actualizar(alumno);
        }
        public void Eliminar(int id)
        {
            _oDAlumno.Eliminar(id);
        }

        /*4. Agregar a la Clase NAlumno el método CalcularISR, el cual recibirá el 
sueldo quincenal del cual se deberá calcular el ISR, y regresará un objeto 
tipo ItemTablaISR
*/
        public ItemTablaISR CalcularISR(int id)
        {
            //Alumno oAlumno = new Alumno();  Dos versiones para usar
            //oAlumno = Consultar(id);
            ItemTablaISR oitemTablaISR = new ItemTablaISR();

            try
            {
                ItemTablaISR oItemTablaISR = new ItemTablaISR();
                refWSAlumnos.WebService1SoapClient oIsrWebServiceSoapClient = new refWSAlumnos.WebService1SoapClient();
                refWSAlumnos.ItemTablaISR o2ItemTablaISR = oIsrWebServiceSoapClient.CalcularISR(id);
                string serializatedTIsr = JsonConvert.SerializeObject(o2ItemTablaISR);
                oItemTablaISR = JsonConvert.DeserializeObject<ItemTablaISR>(serializatedTIsr);
            }
            catch
            {
                Alumno oAlumno = Consultar(Convert.ToInt16(id));
                List<ItemTablaISR> listaISR = _oDAlumno.ConsultarTablaISR();
                decimal quincena = oAlumno.sueldoMensual / 2;
                decimal ISR = 0;
                var isrRango = listaISR.Find(l => quincena <= l.LimiteInferior && quincena <= l.LimiteSuperior);

                if (isrRango != null)
                {
                    ISR = isrRango.CuotaFija + (isrRango.Excedente / 100) * (quincena - isrRango.LimiteInferior);
                }
                oitemTablaISR.LimiteInferior = isrRango.LimiteInferior;
                oitemTablaISR.LimiteSuperior = isrRango.LimiteSuperior;
                oitemTablaISR.CuotaFija = isrRango.CuotaFija;
                oitemTablaISR.Excedente = isrRango.Excedente;
                oitemTablaISR.Subsidio = isrRango.Subsidio;
                oitemTablaISR.ISR = ISR;
            }

            return oitemTablaISR;
        }
        public AportacionesIMSS CalcularIMSS(int id)
        {
            //modificamosp para que funcione el Web Service
            AportacionesIMSS oAportacionesIMSS = new AportacionesIMSS();


            try
            {

                refWSAlumnos.WebService1SoapClient oWebService1SoapClient = new refWSAlumnos.WebService1SoapClient();
                refWSAlumnos.AportacionesIMSS o2AportacionesIMSS = oWebService1SoapClient.CalcularIMSS(id);
                string serializated = JsonConvert.SerializeObject(o2AportacionesIMSS);
                oAportacionesIMSS = JsonConvert.DeserializeObject<AportacionesIMSS>(serializated);




            }
            catch 
            {
                Alumno oAlumno = Consultar(id);
                decimal SBC = oAlumno.sueldoMensual;
                decimal UMA = Convert.ToDecimal(ConfigurationManager.AppSettings["UMA"]);

                decimal enfermedadMaternidad = 0;
                decimal invalidezVida = 0;
                decimal retiro = 0;
                decimal cesantia = 0;
                decimal infonavit = 0;

                enfermedadMaternidad = UMA - 3 * SBC * 0.4m / 100;
                invalidezVida = SBC * 0.625m / 100;
                retiro = SBC * 0 / 100;
                cesantia = SBC * 1.125m / 100;
                infonavit = SBC * 0 / 100;
                AportacionesIMSS aportacionesIMSS = new AportacionesIMSS();
                aportacionesIMSS.EnfermedadMaternidad = enfermedadMaternidad;
                aportacionesIMSS.InvalidezVida = invalidezVida;
                aportacionesIMSS.Retiro = retiro;
                aportacionesIMSS.Cesantia = cesantia;
                aportacionesIMSS.Infonavit = infonavit;
            }
            return oAportacionesIMSS;
        }
    }
}