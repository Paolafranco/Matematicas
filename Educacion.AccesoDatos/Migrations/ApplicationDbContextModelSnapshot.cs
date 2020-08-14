﻿// <auto-generated />
using Educacion.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Educacion.AccesoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Educacion.Negocio.Asignatura", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AsignaturaId");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("Educacion.Negocio.Estudiante", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Educacion.Negocio.EstudianteAsignatura", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.HasKey("AsignaturaId", "EstudianteId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("EstudiantePorAsignatura");
                });

            modelBuilder.Entity("Educacion.Negocio.EstudianteAsignatura", b =>
                {
                    b.HasOne("Educacion.Negocio.Asignatura", "Asignatura")
                        .WithMany("EstudianteAsignaturas")
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Educacion.Negocio.Estudiante", "Estudiante")
                        .WithMany("EstudianteAsignaturas")
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
