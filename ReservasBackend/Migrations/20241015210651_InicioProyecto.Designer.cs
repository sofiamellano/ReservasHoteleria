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
    [Migration("20241015210651_InicioProyecto")]
    partial class InicioProyecto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Empleado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("RH_Empleados");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Apellido = "Apellido1",
                            Cargo = "Mucama",
                            Eliminado = false,
                            Nombre = "Empleado1",
                            Telefono = "111111"
                        },
                        new
                        {
                            ID = 2,
                            Apellido = "Apellido2",
                            Cargo = "Limpieza",
                            Eliminado = false,
                            Nombre = "Empleado2",
                            Telefono = "333333"
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Habitacion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

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
                            Capacidad = 2,
                            Disponible = true,
                            Eliminado = false,
                            PrecioPorNoche = 50000m,
                            TipoHabitacion = "Doble"
                        },
                        new
                        {
                            ID = 2,
                            Capacidad = 1,
                            Disponible = false,
                            Eliminado = false,
                            PrecioPorNoche = 30000m,
                            TipoHabitacion = "Simple"
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Pago", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("ReservaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReservaID")
                        .IsUnique();

                    b.ToTable("RH_Pagos");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Eliminado = false,
                            FechaPago = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 50000m,
                            ReservaID = 1
                        },
                        new
                        {
                            ID = 2,
                            Eliminado = false,
                            FechaPago = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 30000m,
                            ReservaID = 2
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

                    b.Property<int?>("PagoID")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HabitacionID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("RH_Reservas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Eliminado = false,
                            EstadoReserva = "Activa",
                            FechaCheckIn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaCheckOut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaReserva = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HabitacionID = 1,
                            PagoID = 1,
                            UsuarioID = 1
                        },
                        new
                        {
                            ID = 2,
                            Eliminado = false,
                            EstadoReserva = "Cancelada",
                            FechaCheckIn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaCheckOut = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaReserva = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HabitacionID = 2,
                            PagoID = 2,
                            UsuarioID = 2
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Servicio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

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
                            Descripcion = "Desayuno completo",
                            Eliminado = false,
                            Nombre = "Desayuno",
                            Precio = 10000m
                        },
                        new
                        {
                            ID = 2,
                            Descripcion = "Almuerzo completo",
                            Eliminado = false,
                            Nombre = "Almuerzo",
                            Precio = 20000m
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

                    b.Property<DateTime>("FechaSolicitud")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ReservaID")
                        .HasColumnType("int");

                    b.Property<string>("TipoServicio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ReservaID");

                    b.ToTable("RH_ServiciosAdicionales");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Eliminado = false,
                            FechaSolicitud = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservaID = 1,
                            TipoServicio = "Servicio de Habitacion"
                        },
                        new
                        {
                            ID = 2,
                            Eliminado = false,
                            FechaSolicitud = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservaID = 2,
                            TipoServicio = "Servicio de Lavanderia"
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

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
                            Apellido = "Perez",
                            Eliminado = false,
                            Email = "juancito@gmail.com",
                            Nombre = "Juan",
                            Telefono = "123456789"
                        },
                        new
                        {
                            ID = 2,
                            Apellido = "Gomez",
                            Eliminado = false,
                            Email = "gomezmaria@gmail.com",
                            Nombre = "Maria",
                            Telefono = "222222"
                        });
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Pago", b =>
                {
                    b.HasOne("ReservasHoteleriaServices.Models.RH_Reserva", "Reserva")
                        .WithOne("Pago")
                        .HasForeignKey("ReservasHoteleriaServices.Models.RH_Pago", "ReservaID");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Reserva", b =>
                {
                    b.HasOne("ReservasHoteleriaServices.Models.RH_Habitacion", "Habitacion")
                        .WithMany()
                        .HasForeignKey("HabitacionID");

                    b.HasOne("ReservasHoteleriaServices.Models.RH_Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID");

                    b.Navigation("Habitacion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_ServicioAdicional", b =>
                {
                    b.HasOne("ReservasHoteleriaServices.Models.RH_Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaID");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("ReservasHoteleriaServices.Models.RH_Reserva", b =>
                {
                    b.Navigation("Pago");
                });
#pragma warning restore 612, 618
        }
    }
}
