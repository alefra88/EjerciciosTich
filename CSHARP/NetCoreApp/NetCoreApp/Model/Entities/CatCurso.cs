﻿using System;
using System.Collections.Generic;

namespace NetCoreApp.Model.Entities
{
    public partial class CatCurso
    {
        public CatCurso()
        {
            Cursos = new HashSet<Curso>();
            InverseIdPreRequisitoNavigation = new HashSet<CatCurso>();
        }

        public short Id { get; set; }
        public string? Clave { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public byte? Horas { get; set; }
        public short? IdPreRequisito { get; set; }
        public bool? Activo { get; set; }

        public virtual CatCurso? IdPreRequisitoNavigation { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<CatCurso> InverseIdPreRequisitoNavigation { get; set; }
    }
}
