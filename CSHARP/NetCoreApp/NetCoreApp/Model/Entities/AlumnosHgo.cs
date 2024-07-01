using System;
using System.Collections.Generic;

namespace NetCoreApp.Model.Entities
{
    public partial class AlumnosHgo
    {
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string Curp { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public short Id { get; set; }
        public short? IdEstadoOrigen { get; set; }
        public short? IdEstatus { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? Telefono { get; set; }
        public decimal? SueldoMensual { get; set; }
    }
}
