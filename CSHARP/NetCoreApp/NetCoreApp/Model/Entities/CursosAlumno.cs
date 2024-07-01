using System;
using System.Collections.Generic;

namespace NetCoreApp.Model.Entities
{
    public partial class CursosAlumno
    {
        public short Id { get; set; }
        public short? IdCurso { get; set; }
        public int? IdAlumno { get; set; }
        public DateTime? FechaInscripcion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public byte? Calificacion { get; set; }

        public virtual Alumno? IdAlumnoNavigation { get; set; }
        public virtual Curso IdNavigation { get; set; } = null!;
    }
}
