﻿// <auto-generated />
using System;
using DA_prod.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DA_prod.Migrations
{
    [DbContext(typeof(PacientesContext))]
    [Migration("20230527054450_Egresos_agregados")]
    partial class Egresos_agregados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DA_prod.Models.Egresado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Asistencia_externa")
                        .HasColumnType("bit");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEgreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("FolioInterno")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("MotivoEgreso")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ProblemaSalud")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("ResumenSalud")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<bool>("Salud_optimo")
                        .HasColumnType("bit");

                    b.Property<bool>("Sesiones")
                        .HasColumnType("bit");

                    b.Property<bool>("Sexo")
                        .HasColumnType("bit");

                    b.Property<bool>("Terapia")
                        .HasColumnType("bit");

                    b.Property<bool>("Tres_meses")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Egresado");
                });

            modelBuilder.Entity("DA_prod.Models.Pacientes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Adicto")
                        .HasColumnType("bit");

                    b.Property<bool>("Alergias")
                        .HasColumnType("bit");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Asistencia_externa")
                        .HasColumnType("bit");

                    b.Property<bool>("Cancer")
                        .HasColumnType("bit");

                    b.Property<bool>("Cons")
                        .HasColumnType("bit");

                    b.Property<string>("Criterios")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<bool>("Diabetes")
                        .HasColumnType("bit");

                    b.Property<string>("DirFam")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("EdadFam")
                        .HasColumnType("int");

                    b.Property<string>("Enfermedades")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Escolaridad")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("EstCivil")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("FolioInterno")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<bool>("Hepatitis")
                        .HasColumnType("bit");

                    b.Property<string>("HoraIngreso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Infeccion")
                        .HasColumnType("bit");

                    b.Property<int>("IngresosPrev")
                        .HasColumnType("int");

                    b.Property<bool>("MayorEdad")
                        .HasColumnType("bit");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("NombreFamiliar")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Obeso")
                        .HasColumnType("bit");

                    b.Property<string>("Ocupacion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("OcupacionFam")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Presion")
                        .HasColumnType("bit");

                    b.Property<bool>("Psiq")
                        .HasColumnType("bit");

                    b.Property<bool>("Referido")
                        .HasColumnType("bit");

                    b.Property<string>("Revision")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Salud")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<bool>("Sexo")
                        .HasColumnType("bit");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("TelefonoFam")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<bool>("TrastornoMental")
                        .HasColumnType("bit");

                    b.Property<bool>("Voluntario")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("paciente");
                });

            modelBuilder.Entity("DA_prod.Models.Servidores", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Grupo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NombreServidor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Servicio")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TelefonoPersonal")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("servidor");
                });
#pragma warning restore 612, 618
        }
    }
}
