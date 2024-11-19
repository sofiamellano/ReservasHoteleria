using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReservasBackend.Migrations
{
    /// <inheritdoc />
    public partial class InicioProyecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RH_Empleados",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cargo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_Empleados", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RH_Habitaciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoHabitacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioPorNoche = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Disponible = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_Habitaciones", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RH_Servicios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_Servicios", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RH_ServiciosAdicionales",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoServicio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_ServiciosAdicionales", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RH_Reservas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaReserva = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaCheckIn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaCheckOut = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstadoReserva = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HabitacionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_Reservas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RH_Reservas_RH_Habitaciones_HabitacionID",
                        column: x => x.HabitacionID,
                        principalTable: "RH_Habitaciones",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "RH_Empleados",
                columns: new[] { "ID", "Cargo", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, "Recepcionista", false, "Sofía" },
                    { 2, "Conserje", false, "Miguel" },
                    { 3, "Mucama", false, "Ana" }
                });

            migrationBuilder.InsertData(
                table: "RH_Habitaciones",
                columns: new[] { "ID", "Disponible", "Eliminado", "PrecioPorNoche", "TipoHabitacion" },
                values: new object[,]
                {
                    { 1, true, false, 120000m, "Suite" },
                    { 2, false, false, 60000m, "Doble" },
                    { 3, true, false, 35000m, "Simple" }
                });

            migrationBuilder.InsertData(
                table: "RH_Servicios",
                columns: new[] { "ID", "Eliminado", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, false, "Desayuno Buffet", 15000m },
                    { 2, false, "Spa y Masajes", 45000m },
                    { 3, false, "Servicio de Lavandería", 10000m }
                });

            migrationBuilder.InsertData(
                table: "RH_ServiciosAdicionales",
                columns: new[] { "ID", "Eliminado", "TipoServicio" },
                values: new object[,]
                {
                    { 1, false, "Transporte al aeropuerto" },
                    { 2, false, "Decoración especial" },
                    { 3, false, "Limpieza extra" }
                });

            migrationBuilder.InsertData(
                table: "RH_Reservas",
                columns: new[] { "ID", "Eliminado", "EstadoReserva", "FechaCheckIn", "FechaCheckOut", "FechaReserva", "HabitacionID" },
                values: new object[,]
                {
                    { 1, false, "Confirmada", new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, false, "Cancelada", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, false, "Pendiente", new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RH_Reservas_HabitacionID",
                table: "RH_Reservas",
                column: "HabitacionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RH_Empleados");

            migrationBuilder.DropTable(
                name: "RH_Reservas");

            migrationBuilder.DropTable(
                name: "RH_Servicios");

            migrationBuilder.DropTable(
                name: "RH_ServiciosAdicionales");

            migrationBuilder.DropTable(
                name: "RH_Habitaciones");
        }
    }
}
