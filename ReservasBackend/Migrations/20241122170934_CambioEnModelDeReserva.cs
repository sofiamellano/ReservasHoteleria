using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservasBackend.Migrations
{
    /// <inheritdoc />
    public partial class CambioEnModelDeReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreCliente",
                table: "RH_Reservas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "RH_ReservaID",
                table: "RH_Habitaciones",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RH_Habitaciones",
                keyColumn: "ID",
                keyValue: 1,
                column: "RH_ReservaID",
                value: null);

            migrationBuilder.UpdateData(
                table: "RH_Habitaciones",
                keyColumn: "ID",
                keyValue: 2,
                column: "RH_ReservaID",
                value: null);

            migrationBuilder.UpdateData(
                table: "RH_Habitaciones",
                keyColumn: "ID",
                keyValue: 3,
                column: "RH_ReservaID",
                value: null);

            migrationBuilder.UpdateData(
                table: "RH_Reservas",
                keyColumn: "ID",
                keyValue: 1,
                column: "NombreCliente",
                value: "Juan Pérez");

            migrationBuilder.UpdateData(
                table: "RH_Reservas",
                keyColumn: "ID",
                keyValue: 2,
                column: "NombreCliente",
                value: "María Gómez");

            migrationBuilder.UpdateData(
                table: "RH_Reservas",
                keyColumn: "ID",
                keyValue: 3,
                column: "NombreCliente",
                value: "Pedro Rodríguez");

            migrationBuilder.CreateIndex(
                name: "IX_RH_Habitaciones_RH_ReservaID",
                table: "RH_Habitaciones",
                column: "RH_ReservaID");

            migrationBuilder.AddForeignKey(
                name: "FK_RH_Habitaciones_RH_Reservas_RH_ReservaID",
                table: "RH_Habitaciones",
                column: "RH_ReservaID",
                principalTable: "RH_Reservas",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RH_Habitaciones_RH_Reservas_RH_ReservaID",
                table: "RH_Habitaciones");

            migrationBuilder.DropIndex(
                name: "IX_RH_Habitaciones_RH_ReservaID",
                table: "RH_Habitaciones");

            migrationBuilder.DropColumn(
                name: "NombreCliente",
                table: "RH_Reservas");

            migrationBuilder.DropColumn(
                name: "RH_ReservaID",
                table: "RH_Habitaciones");
        }
    }
}
