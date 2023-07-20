using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DA_prod.Migrations
{
    public partial class Egresos_agregados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HoraIngreso",
                table: "paciente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<bool>(
                name: "Adicto",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Alergias",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Asistencia_externa",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cancer",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cons",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Diabetes",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "EdadFam",
                table: "paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Hepatitis",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Infeccion",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MayorEdad",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Obeso",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OcupacionFam",
                table: "paciente",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Presion",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Psiq",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TrastornoMental",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Voluntario",
                table: "paciente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Egresado",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FolioInterno = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Sexo = table.Column<bool>(type: "bit", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEgreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotivoEgreso = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    ResumenSalud = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    ProblemaSalud = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Tres_meses = table.Column<bool>(type: "bit", nullable: false),
                    Terapia = table.Column<bool>(type: "bit", nullable: false),
                    Sesiones = table.Column<bool>(type: "bit", nullable: false),
                    Salud_optimo = table.Column<bool>(type: "bit", nullable: false),
                    Asistencia_externa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egresado", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Egresado");

            migrationBuilder.DropColumn(
                name: "Adicto",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Alergias",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Asistencia_externa",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Cancer",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Cons",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Diabetes",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "EdadFam",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Hepatitis",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Infeccion",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "MayorEdad",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Obeso",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "OcupacionFam",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Presion",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Psiq",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "TrastornoMental",
                table: "paciente");

            migrationBuilder.DropColumn(
                name: "Voluntario",
                table: "paciente");

            migrationBuilder.AlterColumn<string>(
                name: "HoraIngreso",
                table: "paciente",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
