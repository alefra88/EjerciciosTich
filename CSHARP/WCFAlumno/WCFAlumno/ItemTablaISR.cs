using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCFAlumno
{
    [DataContract]
    public class ItemTablaISR
    {
        [DataMember]
        public decimal LimiteInferior { get; set; }
        [DataMember]

        public decimal LimiteSuperior { get; set; }
        [DataMember]

        public decimal CuotaFija { get; set; }
        [DataMember]

        public decimal Excedente { get; set; }
        [DataMember]

        public decimal Subsidio { get; set; }
        [DataMember]

        public decimal ISR { get; set; }
    }
}