using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCM.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apartamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asunto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaDeEntrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fechaDeSalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "persona");
        }
    }
}
