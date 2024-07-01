using System;
using System.Collections.Generic;

namespace NetCoreApp.Model.Entities
{
    public partial class Curso
    {
        public Curso()
        {
            CursosInstructores = new HashSet<CursosInstructore>();
        }

        public short Id { get; set; }
        public short? IdCatCurso { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public bool? Activo { get; set; }

        public virtual Instructore? IdCatCurso1 { get; set; }
        public virtual CatCurso? IdCatCursoNavigation { get; set; }
        public virtual CursosAlumno? CursosAlumno { get; set; }
        public virtual ICollection<CursosInstructore> CursosInstructores { get; set; }
    }
}
