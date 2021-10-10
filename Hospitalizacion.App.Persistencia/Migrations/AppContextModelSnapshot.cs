﻿// <auto-generated />
using System;
using Hospitalizacion.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hospitalizacion.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Historia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entorno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MascotaEnfermaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MascotaEnfermaId")
                        .IsUnique();

                    b.ToTable("Historias");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.MascotaEnferma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuxiliarVeterinario_designadoId")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.Property<int?>("MedicoEncargadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoMascota")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuxiliarVeterinario_designadoId");

                    b.HasIndex("MedicoEncargadoId");

                    b.ToTable("MascotasEnfermas");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.SignosVitales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FechaHora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MascotaEnfermaId")
                        .HasColumnType("int");

                    b.Property<int>("Signo")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MascotaEnfermaId");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaHora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistoriaPertenecienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaPertenecienteId");

                    b.ToTable("SugerenciasCuidado");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.AuxiliarVeterinario", b =>
                {
                    b.HasBaseType("Hospitalizacion.App.Dominio.Persona");

                    b.Property<int>("HorasLaborales")
                        .HasColumnType("int");

                    b.Property<int>("No_Certificado")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("AuxiliarVeterinario");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Dueño", b =>
                {
                    b.HasBaseType("Hospitalizacion.App.Dominio.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MascotaEnfermaId")
                        .HasColumnType("int");

                    b.HasIndex("MascotaEnfermaId")
                        .IsUnique()
                        .HasFilter("[MascotaEnfermaId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Dueño");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.MedicoVeterinario", b =>
                {
                    b.HasBaseType("Hospitalizacion.App.Dominio.Persona");

                    b.Property<int>("CetificadoVeterinario")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("MedicoVeterinario");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Historia", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.MascotaEnferma", null)
                        .WithOne("HistoriaMedica")
                        .HasForeignKey("Hospitalizacion.App.Dominio.Historia", "MascotaEnfermaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.MascotaEnferma", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.AuxiliarVeterinario", "AuxiliarVeterinario_designado")
                        .WithMany()
                        .HasForeignKey("AuxiliarVeterinario_designadoId");

                    b.HasOne("Hospitalizacion.App.Dominio.MedicoVeterinario", "MedicoEncargado")
                        .WithMany("MascotasAsignadas")
                        .HasForeignKey("MedicoEncargadoId");

                    b.Navigation("AuxiliarVeterinario_designado");

                    b.Navigation("MedicoEncargado");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.SignosVitales", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.MascotaEnferma", null)
                        .WithMany("signosVitales")
                        .HasForeignKey("MascotaEnfermaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.Historia", "HistoriaPerteneciente")
                        .WithMany("SugerenciaCuidados")
                        .HasForeignKey("HistoriaPertenecienteId");

                    b.Navigation("HistoriaPerteneciente");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Dueño", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.MascotaEnferma", null)
                        .WithOne("DueñoEncargado")
                        .HasForeignKey("Hospitalizacion.App.Dominio.Dueño", "MascotaEnfermaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Historia", b =>
                {
                    b.Navigation("SugerenciaCuidados");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.MascotaEnferma", b =>
                {
                    b.Navigation("DueñoEncargado");

                    b.Navigation("HistoriaMedica");

                    b.Navigation("signosVitales");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.MedicoVeterinario", b =>
                {
                    b.Navigation("MascotasAsignadas");
                });
#pragma warning restore 612, 618
        }
    }
}