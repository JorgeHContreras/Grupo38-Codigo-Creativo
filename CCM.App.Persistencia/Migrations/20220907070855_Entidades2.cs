using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCM.App.Persistencia.Migrations
{
    public partial class Entidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Receptor",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remitente",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResidenteCorrespondencia_asunto",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residente_apartamento",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cedula",
                table: "persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "persona",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "observaciones",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parqueadero",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anotacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropColumn(
                name: "Receptor",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Remitente",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "ResidenteCorrespondencia_asunto",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Residente_apartamento",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "cedula",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "observaciones",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "parqueadero",
                table: "persona");
        }
    }
}
