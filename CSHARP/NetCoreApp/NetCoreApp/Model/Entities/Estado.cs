using System;
using System.Collections.Generic;

namespace NetCoreApp.Model.Entities
{
    public partial class Estado
    {
        public Estado()
        {
            Alumnos = new HashSet<Alumno>();
        }

        public short Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}
