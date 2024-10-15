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
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cargo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
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
                    Capacidad = table.Column<int>(type: "int", nullable: false),
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
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_Servicios", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RH_Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_Usuarios", x => x.ID);
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
                    UsuarioID = table.Column<int>(type: "int", nullable: true),
                    HabitacionID = table.Column<int>(type: "int", nullable: true),
                    PagoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_Reservas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RH_Reservas_RH_Habitaciones_HabitacionID",
                        column: x => x.HabitacionID,
                        principalTable: "RH_Habitaciones",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RH_Reservas_RH_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "RH_Usuarios",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RH_Pagos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Monto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReservaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_Pagos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RH_Pagos_RH_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "RH_Reservas",
                        principalColumn: "ID");
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
                    FechaSolicitud = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReservaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RH_ServiciosAdicionales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RH_ServiciosAdicionales_RH_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "RH_Reservas",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "RH_Empleados",
                columns: new[] { "ID", "Apellido", "Cargo", "Eliminado", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Apellido1", "Mucama", false, "Empleado1", "111111" },
                    { 2, "Apellido2", "Limpieza", false, "Empleado2", "333333" }
                });

            migrationBuilder.InsertData(
                table: "RH_Habitaciones",
                columns: new[] { "ID", "Capacidad", "Disponible", "Eliminado", "PrecioPorNoche", "TipoHabitacion" },
                values: new object[,]
                {
                    { 1, 2, true, false, 50000m, "Doble" },
                    { 2, 1, false, false, 30000m, "Simple" }
                });

            migrationBuilder.InsertData(
                table: "RH_Servicios",
                columns: new[] { "ID", "Descripcion", "Eliminado", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Desayuno completo", false, "Desayuno", 10000m },
                    { 2, "Almuerzo completo", false, "Almuerzo", 20000m }
                });

            migrationBuilder.InsertData(
                table: "RH_Usuarios",
                columns: new[] { "ID", "Apellido", "Eliminado", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Perez", false, "juancito@gmail.com", "Juan", "123456789" },
                    { 2, "Gomez", false, "gomezmaria@gmail.com", "Maria", "222222" }
                });

            migrationBuilder.InsertData(
                table: "RH_Reservas",
                columns: new[] { "ID", "Eliminado", "EstadoReserva", "FechaCheckIn", "FechaCheckOut", "FechaReserva", "HabitacionID", "PagoID", "UsuarioID" },
                values: new object[,]
                {
                    { 1, false, "Activa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 2, false, "Cancelada", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "RH_Pagos",
                columns: new[] { "ID", "Eliminado", "FechaPago", "Monto", "ReservaID" },
                values: new object[,]
                {
                    { 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50000m, 1 },
                    { 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30000m, 2 }
                });

            migrationBuilder.InsertData(
                table: "RH_ServiciosAdicionales",
                columns: new[] { "ID", "Eliminado", "FechaSolicitud", "ReservaID", "TipoServicio" },
                values: new object[,]
                {
                    { 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Servicio de Habitacion" },
                    { 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Servicio de Lavanderia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RH_Pagos_ReservaID",
                table: "RH_Pagos",
                column: "ReservaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RH_Reservas_HabitacionID",
                table: "RH_Reservas",
                column: "HabitacionID");

            migrationBuilder.CreateIndex(
                name: "IX_RH_Reservas_UsuarioID",
                table: "RH_Reservas",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_RH_ServiciosAdicionales_ReservaID",
                table: "RH_ServiciosAdicionales",
                column: "ReservaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RH_Empleados");

            migrationBuilder.DropTable(
                name: "RH_Pagos");

            migrationBuilder.DropTable(
                name: "RH_Servicios");

            migrationBuilder.DropTable(
                name: "RH_ServiciosAdicionales");

            migrationBuilder.DropTable(
                name: "RH_Reservas");

            migrationBuilder.DropTable(
                name: "RH_Habitaciones");

            migrationBuilder.DropTable(
                name: "RH_Usuarios");
        }
    }
}
