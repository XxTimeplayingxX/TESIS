﻿// <auto-generated />
using System;
using DB.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20240730201422_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.CitaMedica", b =>
                {
                    b.Property<int>("CitaMedicaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CitaMedicaID"));

                    b.Property<int>("CitaMedicaDiagnosticoID")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicoID")
                        .HasColumnType("int");

                    b.Property<int>("PacienteID")
                        .HasColumnType("int");

                    b.Property<int>("RecetaID")
                        .HasColumnType("int");

                    b.HasKey("CitaMedicaID");

                    b.HasIndex("MedicoID");

                    b.HasIndex("PacienteID");

                    b.HasIndex("RecetaID");

                    b.ToTable("CitaMedicas");
                });

            modelBuilder.Entity("DB.CitaMedicaDiagnostico", b =>
                {
                    b.Property<int>("CitaMedicaDiagnosticoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CitaMedicaDiagnosticoID"));

                    b.Property<int>("CitaMedicaID")
                        .HasColumnType("int");

                    b.Property<int>("DiagnosticoID")
                        .HasColumnType("int");

                    b.HasKey("CitaMedicaDiagnosticoID");

                    b.HasIndex("CitaMedicaID")
                        .IsUnique();

                    b.HasIndex("DiagnosticoID");

                    b.ToTable("CitaMedicaDiagnosticos");
                });

            modelBuilder.Entity("DB.DetalleReceta", b =>
                {
                    b.Property<int>("DetalleRecetaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleRecetaID"));

                    b.Property<string>("Dosis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duracion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frecuencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instrucciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecetaID")
                        .HasColumnType("int");

                    b.HasKey("DetalleRecetaID");

                    b.HasIndex("RecetaID");

                    b.ToTable("DetalleRecetas");
                });

            modelBuilder.Entity("DB.Diagnostico", b =>
                {
                    b.Property<int>("DiagnosticoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosticoID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiagnosticoGeneralEnfermedadesID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Recomendaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Severidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiagnosticoID");

                    b.HasIndex("DiagnosticoGeneralEnfermedadesID");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("DB.DiagnosticoGeneralEnfermedades", b =>
                {
                    b.Property<int>("DiagnosticoGeneraEnfermedadesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosticoGeneraEnfermedadesID"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiagnosticoGeneraEnfermedadesID");

                    b.ToTable("DiagnosticoGeneralEnfermedades");
                });

            modelBuilder.Entity("DB.Medico", b =>
                {
                    b.Property<int>("MedicoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicoID"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaID")
                        .HasColumnType("int");

                    b.HasKey("MedicoID");

                    b.HasIndex("PersonaID");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("DB.Paciente", b =>
                {
                    b.Property<int>("PacienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteID"));

                    b.Property<string>("HistorialMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaID")
                        .HasColumnType("int");

                    b.HasKey("PacienteID");

                    b.HasIndex("PersonaID");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("DB.Persona", b =>
                {
                    b.Property<int>("PersonaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonaID"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaID");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("DB.Receta", b =>
                {
                    b.Property<int>("RecetaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecetaID"));

                    b.Property<string>("Comentarios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime2");

                    b.HasKey("RecetaID");

                    b.ToTable("Recetas");
                });

            modelBuilder.Entity("DB.SignosVitales", b =>
                {
                    b.Property<int>("SignosVitalesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SignosVitalesID"));

                    b.Property<string>("FrecuenciaCardiaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacienteID")
                        .HasColumnType("int");

                    b.Property<string>("PresionArterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pulso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SignosVitalesID");

                    b.HasIndex("PacienteID");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("DB.CitaMedica", b =>
                {
                    b.HasOne("DB.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DB.Receta", "Receta")
                        .WithMany()
                        .HasForeignKey("RecetaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");

                    b.Navigation("Receta");
                });

            modelBuilder.Entity("DB.CitaMedicaDiagnostico", b =>
                {
                    b.HasOne("DB.CitaMedica", "CitaMedica")
                        .WithOne("CitaMedicaDiagnostico")
                        .HasForeignKey("DB.CitaMedicaDiagnostico", "CitaMedicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Diagnostico", "Diagnostico")
                        .WithMany()
                        .HasForeignKey("DiagnosticoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CitaMedica");

                    b.Navigation("Diagnostico");
                });

            modelBuilder.Entity("DB.DetalleReceta", b =>
                {
                    b.HasOne("DB.Receta", "Receta")
                        .WithMany()
                        .HasForeignKey("RecetaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receta");
                });

            modelBuilder.Entity("DB.Diagnostico", b =>
                {
                    b.HasOne("DB.DiagnosticoGeneralEnfermedades", "DiagnosticoGeneralEnfermedades")
                        .WithMany()
                        .HasForeignKey("DiagnosticoGeneralEnfermedadesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiagnosticoGeneralEnfermedades");
                });

            modelBuilder.Entity("DB.Medico", b =>
                {
                    b.HasOne("DB.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("DB.Paciente", b =>
                {
                    b.HasOne("DB.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("DB.SignosVitales", b =>
                {
                    b.HasOne("DB.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("DB.CitaMedica", b =>
                {
                    b.Navigation("CitaMedicaDiagnostico")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
