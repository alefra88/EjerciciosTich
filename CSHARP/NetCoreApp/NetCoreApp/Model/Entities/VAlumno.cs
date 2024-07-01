using System;
using System.Collections.Generic;

namespace NetCoreApp.Model.Entities
{
    public partial class VAlumno
    {
        public int Id { get; set; }
        public string? NombreAlumno { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string Curp { get; set; } = null!;
        public string? NombreEstado { get; set; }
        public string? Estatus { get; set; }
    }
}
