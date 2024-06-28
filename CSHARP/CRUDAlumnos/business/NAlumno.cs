using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;
using System.Configuration;

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
        public ItemTablaISR CalcularISR(decimal sueldo)
        {
            List<ItemTablaISR> listaISR = _oDAlumno.ConsultarTablaISR();
            decimal quincena = sueldo/2;
            decimal ISR = 0;
            var isrRango = listaISR.Find(l => quincena <= l.LimiteInferior && quincena <= l.LimiteSuperior);

            if(isrRango != null)
            {
                ISR = isrRango.CuotaFija + (isrRango.Excedente / 100) * (quincena - isrRango.LimiteInferior);
            }
            ItemTablaISR oitemTablaISR = new ItemTablaISR();
            oitemTablaISR.LimiteInferior = isrRango.LimiteInferior;
            oitemTablaISR.LimiteSuperior = isrRango.LimiteSuperior;
            oitemTablaISR.CuotaFija = isrRango.CuotaFija;
            oitemTablaISR.Excedente = isrRango.Excedente;
            oitemTablaISR.Subsidio = isrRango.Subsidio;
            oitemTablaISR.ISR = ISR;
            return oitemTablaISR;
        }
        public AportacionesIMSS CalcularIMSS(decimal sueldo)
        {
            
            decimal SBC = sueldo;
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

            return aportacionesIMSS;
        }
    }
}