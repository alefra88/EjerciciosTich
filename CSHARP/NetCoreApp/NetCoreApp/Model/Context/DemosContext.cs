using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NetCoreApp.Model.Entities;

namespace NetCoreApp.Model.Context
{
    public partial class DemosContext : DbContext
    {
        public DemosContext()
        {
        }

        public DemosContext(DbContextOptions<DemosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;
        public virtual DbSet<AlumnosBaja> AlumnosBajas { get; set; } = null!;
        public virtual DbSet<AlumnosHgo> AlumnosHgos { get; set; } = null!;
        public virtual DbSet<AlumnosTodo> AlumnosTodos { get; set; } = null!;
        public virtual DbSet<CatCurso> CatCursos { get; set; } = null!;
        public virtual DbSet<Curso> Cursos { get; set; } = null!;
        public virtual DbSet<CursosAlumno> CursosAlumnos { get; set; } = null!;
        public virtual DbSet<CursosInstructore> CursosInstructores { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<EstatusAlumno> EstatusAlumnos { get; set; } = null!;
        public virtual DbSet<Instructore> Instructores { get; set; } = null!;
        public virtual DbSet<Saldo> Saldos { get; set; } = null!;
        public virtual DbSet<TablaIsr> TablaIsrs { get; set; } = null!;
        public virtual DbSet<Transaccione> Transacciones { get; set; } = null!;
        public virtual DbSet<VAlumno> VAlumnos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Correo)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength();

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.IdEstadoOrigen).HasColumnName("idEstadoOrigen");

                entity.Property(e => e.IdEstatus).HasColumnName("idEstatus");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.SueldoMensual)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("sueldoMensual");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength();

                entity.HasOne(d => d.IdEstadoOrigenNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdEstadoOrigen)
                    .HasConstraintName("FK_Alumnos_Estados");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_Alumnos_EstatusAlumnos");
            });

            modelBuilder.Entity<AlumnosBaja>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlumnosBaja");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");
            });

            modelBuilder.Entity<AlumnosHgo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlumnosHgo");

                entity.Property(e => e.Correo)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength();

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdEstadoOrigen).HasColumnName("idEstadoOrigen");

                entity.Property(e => e.IdEstatus).HasColumnName("idEstatus");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.SueldoMensual)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("sueldoMensual");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlumnosTodo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Correo)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength();

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdEstadoOrigen).HasColumnName("idEstadoOrigen");

                entity.Property(e => e.IdEstatus).HasColumnName("idEstatus");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.SueldoMensual)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("sueldoMensual");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatCurso>(entity =>
            {
                entity.ToTable("catCurso");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Clave)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Horas).HasColumnName("horas");

                entity.Property(e => e.IdPreRequisito).HasColumnName("idPreRequisito");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdPreRequisitoNavigation)
                    .WithMany(p => p.InverseIdPreRequisitoNavigation)
                    .HasForeignKey(d => d.IdPreRequisito)
                    .HasConstraintName("FK_catCurso_catCurso");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("date")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.IdCatCurso).HasColumnName("idCatCurso");

                entity.HasOne(d => d.IdCatCursoNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdCatCurso)
                    .HasConstraintName("FK_Cursos_catCurso");

                entity.HasOne(d => d.IdCatCurso1)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdCatCurso)
                    .HasConstraintName("FK_Cursos_Instructores");
            });

            modelBuilder.Entity<CursosAlumno>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Calificacion).HasColumnName("calificacion");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("date")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.FechaInscripcion)
                    .HasColumnType("date")
                    .HasColumnName("fechaInscripcion");

                entity.Property(e => e.IdAlumno).HasColumnName("idAlumno");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CursosAlumno)
                    .HasForeignKey<CursosAlumno>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_idCurso");

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.CursosAlumnos)
                    .HasForeignKey(d => d.IdAlumno)
                    .HasConstraintName("FK_CursosAlumnos_Alumnos");
            });

            modelBuilder.Entity<CursosInstructore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaContratacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaContratacion");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.Property(e => e.IdInstructor).HasColumnName("idInstructor");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.CursosInstructores)
                    .HasForeignKey(d => d.IdCurso)
                    .HasConstraintName("FK_CursosInstructores_Cursos");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<EstatusAlumno>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clave)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Instructore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Correo)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.CuotaHora)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("cuotaHora");

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength();

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("rfc")
                    .IsFixedLength();

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Saldo>(entity =>
            {
                entity.ToTable("saldos");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Saldo1)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("saldo");
            });

            modelBuilder.Entity<TablaIsr>(entity =>
            {
                entity.ToTable("TablaISR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CuotaFija).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ExedLimInf).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LimInf).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LimSup).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Subsidio).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<Transaccione>(entity =>
            {
                entity.ToTable("transacciones");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDestino).HasColumnName("idDestino");

                entity.Property(e => e.IdOrigen).HasColumnName("idOrigen");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("monto");

                entity.HasOne(d => d.IdOrigenNavigation)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.IdOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_transacciones_saldos");
            });

            modelBuilder.Entity<VAlumno>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Alumnos");

                entity.Property(e => e.Correo)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NombreAlumno)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Nombre Alumno");

                entity.Property(e => e.NombreEstado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre Estado");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
