using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCM.App.Persistencia.Migrations
{
    public partial class Entidades3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_usuario",
                table: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_persona",
                table: "persona");

            migrationBuilder.RenameTable(
                name: "usuario",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "persona",
                newName: "personas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personas",
                table: "personas",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personas",
                table: "personas");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "usuario");

            migrationBuilder.RenameTable(
                name: "personas",
                newName: "persona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuario",
                table: "usuario",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_persona",
                table: "persona",
                column: "id");
        }
    }
}
