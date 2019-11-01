using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WebApplication2.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Costo> Costo { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Entregable> Entregable { get; set; }
        public virtual DbSet<Facultad> Facultad { get; set; }
        public virtual DbSet<Gammificacion> Gammificacion { get; set; }
        public virtual DbSet<InformacionBachiller> InformacionBachiller { get; set; }
        public virtual DbSet<InformacionTitulo> InformacionTitulo { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Requisito> Requisito { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tesis> Tesis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.codigoAlumno)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.claveAlumno)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.dniPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.codigoFacultad)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.codigoPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Tesis)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Costo>()
                .Property(e => e.nombreCosto)
                .IsUnicode(false);

            modelBuilder.Entity<Costo>()
                .Property(e => e.CantidadCosto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Costo>()
                .HasMany(e => e.Requisito)
                .WithOptional(e => e.Costo)
                .HasForeignKey(e => e.costoRequisito);

            modelBuilder.Entity<Docente>()
                .Property(e => e.codigoDocente)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.claveDocente)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.dniPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.codigoFacultad)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .Property(e => e.codigoPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Docente>()
                .HasMany(e => e.Tesis)
                .WithRequired(e => e.Docente)
                .HasForeignKey(e => e.codigoAsesor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entregable>()
                .Property(e => e.archivo)
                .IsUnicode(false);

            modelBuilder.Entity<Entregable>()
                .Property(e => e.medalla)
                .IsUnicode(false);

            modelBuilder.Entity<Entregable>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Entregable>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Facultad>()
                .Property(e => e.codigoFacultad)
                .IsUnicode(false);

            modelBuilder.Entity<Facultad>()
                .Property(e => e.nombreFacultad)
                .IsUnicode(false);

            modelBuilder.Entity<Facultad>()
                .Property(e => e.acronimo)
                .IsUnicode(false);

            modelBuilder.Entity<Gammificacion>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Gammificacion>()
                .Property(e => e.imagen)
                .IsUnicode(false);

            modelBuilder.Entity<Gammificacion>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<InformacionBachiller>()
                .Property(e => e.codigoAlumnoCorrespondenciaInformacionBachiller)
                .IsUnicode(false);

            modelBuilder.Entity<InformacionBachiller>()
                .Property(e => e.nombreInformacionBachiller)
                .IsUnicode(false);

            modelBuilder.Entity<InformacionBachiller>()
                .Property(e => e.descrpcionInformacionBachiller)
                .IsUnicode(false);

            modelBuilder.Entity<InformacionTitulo>()
                .Property(e => e.codigoAlumnoCorrespondenciaInformacionTitulo)
                .IsUnicode(false);

            modelBuilder.Entity<InformacionTitulo>()
                .Property(e => e.nombreInformacionTitulo)
                .IsUnicode(false);

            modelBuilder.Entity<InformacionTitulo>()
                .Property(e => e.descripcionInformacionTitulo)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.codigoPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.dniPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.nombrePersona)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.apellidoPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Alumno)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Docente)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requisito>()
                .Property(e => e.nombreRequisito)
                .IsUnicode(false);

            modelBuilder.Entity<Requisito>()
                .Property(e => e.descripcionRequisito)
                .IsUnicode(false);

            modelBuilder.Entity<Requisito>()
                .Property(e => e.tiempoEstimadoRequisito)
                .IsUnicode(false);

            modelBuilder.Entity<Requisito>()
                .HasMany(e => e.InformacionBachiller)
                .WithRequired(e => e.Requisito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requisito>()
                .HasMany(e => e.InformacionTitulo)
                .WithRequired(e => e.Requisito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tesis>()
                .Property(e => e.nombreTesis)
                .IsUnicode(false);

            modelBuilder.Entity<Tesis>()
                .Property(e => e.codigoAsesor)
                .IsUnicode(false);

            modelBuilder.Entity<Tesis>()
                .Property(e => e.codigoAlumno)
                .IsUnicode(false);
        }
    }
}
