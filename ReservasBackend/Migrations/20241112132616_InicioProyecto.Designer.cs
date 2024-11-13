﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservasBackend.DataContext;

#nullable disable

namespace ReservasBackend.Migrations
{
    [DbContext(typeof(ReservaHoteleriaContext))]
    [Migration("20241112132616_InicioProyecto")]
    partial class InicioProyecto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Empleado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("RH_Empleados");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Cargo = "Recepcionista",
                            Eliminado = false,
                            Nombre = "Sofía"
                        },
                        new
                        {
                            ID = 2,
                            Cargo = "Conserje",
                            Eliminado = false,
                            Nombre = "Miguel"
                        },
                        new
                        {
                            ID = 3,
                            Cargo = "Mucama",
                            Eliminado = false,
                            Nombre = "Ana"
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Habitacion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Disponible")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("PrecioPorNoche")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("TipoHabitacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("RH_Habitaciones");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Disponible = true,
                            Eliminado = false,
                            PrecioPorNoche = 120000m,
                            TipoHabitacion = "Suite"
                        },
                        new
                        {
                            ID = 2,
                            Disponible = false,
                            Eliminado = false,
                            PrecioPorNoche = 60000m,
                            TipoHabitacion = "Doble"
                        },
                        new
                        {
                            ID = 3,
                            Disponible = true,
                            Eliminado = false,
                            PrecioPorNoche = 35000m,
                            TipoHabitacion = "Simple"
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Reserva", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("EstadoReserva")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaCheckIn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaCheckOut")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaReserva")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("HabitacionID")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("RH_Reservas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Eliminado = false,
                            EstadoReserva = "Confirmada",
                            FechaCheckIn = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaCheckOut = new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaReserva = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HabitacionID = 1,
                            UsuarioID = 1
                        },
                        new
                        {
                            ID = 2,
                            Eliminado = false,
                            EstadoReserva = "Cancelada",
                            FechaCheckIn = new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaCheckOut = new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaReserva = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HabitacionID = 3,
                            UsuarioID = 2
                        },
                        new
                        {
                            ID = 3,
                            Eliminado = false,
                            EstadoReserva = "Pendiente",
                            FechaCheckIn = new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaCheckOut = new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaReserva = new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HabitacionID = 2,
                            UsuarioID = 3
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Servicio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ID");

                    b.ToTable("RH_Servicios");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Eliminado = false,
                            Nombre = "Desayuno Buffet",
                            Precio = 15000m
                        },
                        new
                        {
                            ID = 2,
                            Eliminado = false,
                            Nombre = "Spa y Masajes",
                            Precio = 45000m
                        },
                        new
                        {
                            ID = 3,
                            Eliminado = false,
                            Nombre = "Servicio de Lavandería",
                            Precio = 10000m
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_ServicioAdicional", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ReservaID")
                        .HasColumnType("int");

                    b.Property<string>("TipoServicio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("RH_ServiciosAdicionales");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Eliminado = false,
                            ReservaID = 1,
                            TipoServicio = "Transporte al aeropuerto"
                        },
                        new
                        {
                            ID = 2,
                            Eliminado = false,
                            ReservaID = 3,
                            TipoServicio = "Decoración especial"
                        },
                        new
                        {
                            ID = 3,
                            Eliminado = false,
                            ReservaID = 2,
                            TipoServicio = "Limpieza extra"
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("RH_Usuarios");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Eliminado = false,
                            Nombre = "Juan",
                            Telefono = "1145678901"
                        },
                        new
                        {
                            ID = 2,
                            Eliminado = false,
                            Nombre = "María",
                            Telefono = "1146543210"
                        },
                        new
                        {
                            ID = 3,
                            Eliminado = false,
                            Nombre = "Carlos",
                            Telefono = "1167890123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}