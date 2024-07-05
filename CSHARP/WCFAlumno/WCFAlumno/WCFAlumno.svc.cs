using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using entities;
using business;
using Newtonsoft.Json;
using System.Configuration;


namespace WCFAlumno
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFAlumno" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFAlumno.svc o WCFAlumno.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFAlumno : IWCFAlumno
    {
        NAlumno _oNAlumno = new NAlumno();
        AportacionesIMSS _oAportacionesIMSS = new AportacionesIMSS();
        public AportacionesIMSS CalcularIMSS(int id)
        {
            entities.AportacionesIMSS oAportacionesIMSS2 = _oNAlumno.CalcularIMSS(id);
            string serializatedIMSS = JsonConvert.SerializeObject(oAportacionesIMSS2);
            AportacionesIMSS oAportacionesIMSS = JsonConvert.DeserializeObject<AportacionesIMSS>(serializatedIMSS);
            return oAportacionesIMSS;

        }

        public ItemTablaISR CalcularISR(int id)
        {
           entities.ItemTablaISR oItemTablaISR2 =  _oNAlumno.CalcularISR(id);
            string serializatedTableISR= JsonConvert.SerializeObject(oItemTablaISR2);
            ItemTablaISR oItemTablaISR = JsonConvert.DeserializeObject<ItemTablaISR>(serializatedTableISR);
            return oItemTablaISR;
        }
    }
}
