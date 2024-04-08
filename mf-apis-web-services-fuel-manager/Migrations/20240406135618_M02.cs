using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_apis_web_services_fuel_manager.Migrations
{
    /// <inheritdoc />
    public partial class M02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Consumos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consumos_UsuarioId",
                table: "Consumos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumos_Usuarios_UsuarioId",
                table: "Consumos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumos_Usuarios_UsuarioId",
                table: "Consumos");

            migrationBuilder.DropIndex(
                name: "IX_Consumos_UsuarioId",
                table: "Consumos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Consumos");
        }
    }
}
