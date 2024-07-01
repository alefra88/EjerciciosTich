using System;
using System.Collections.Generic;

namespace NetCoreApp.Model.Entities
{
    public partial class CursosInstructore
    {
        public short Id { get; set; }
        public short? IdCurso { get; set; }
        public int? IdInstructor { get; set; }
        public DateTime? FechaContratacion { get; set; }

        public virtual Curso? IdCursoNavigation { get; set; }
    }
}
