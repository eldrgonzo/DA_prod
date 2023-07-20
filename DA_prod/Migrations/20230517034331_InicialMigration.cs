using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA_prod.Migrations
{
    public partial class InicialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paciente",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FolioInterno = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraIngreso = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Sexo = table.Column<bool>(type: "bit", nullable: false),
                    EstCivil = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Escolaridad = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IngresosPrev = table.Column<int>(type: "int", maxLength: 300, nullable: false),
                    Referido = table.Column<bool>(type: "bit", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Salud = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Enfermedades = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    NombreFamiliar = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DirFam = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TelefonoFam = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Revision = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Criterios = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paciente", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "servidor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NombreServidor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Grupo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TelefonoPersonal = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Servicio = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servidor", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paciente");

            migrationBuilder.DropTable(
                name: "servidor");
        }
    }
}
