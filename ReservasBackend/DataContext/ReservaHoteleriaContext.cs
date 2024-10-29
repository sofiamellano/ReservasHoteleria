using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using ReservasHoteleriaServices.Models;

namespace ReservasBackend.DataContext
{
    public class ReservaHoteleriaContext : DbContext
    {
        //public ReservaHoteleriaContext()
        //{
        //}

        public ReservaHoteleriaContext(DbContextOptions<ReservaHoteleriaContext> options) : base(options)
        {
        }

        public virtual DbSet<RH_Usuario> RH_Usuarios { get; set; }
        public virtual DbSet<RH_Habitacion> RH_Habitaciones { get; set; }
        public virtual DbSet<RH_Reserva> RH_Reservas { get; set; }
        public virtual DbSet<RH_ServicioAdicional> RH_ServiciosAdicionales { get; set; }
        public virtual DbSet<RH_Pago> RH_Pagos { get; set; }
        public virtual DbSet<RH_Servicio> RH_Servicios { get; set; }
        public virtual DbSet<RH_Empleado> RH_Empleados { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        var configuration = new ConfigurationBuilder()
        //                           // .SetBasePath(Directory.GetCurrentDirectory()) // Si es para un escritorio
        //                            .AddJsonFile("appsettings.json")
        //                            .Build();

        //        string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");
        //        optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
        //    }
        //}

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la relación uno a uno entre RH_Reserva y RH_Pago
            modelBuilder.Entity<RH_Reserva>()
                .HasOne(r => r.Pago)
                .WithOne(p => p.Reserva)
                .HasForeignKey<RH_Pago>(p => p.ReservaID);

            #region Datos Semilla 

            modelBuilder.Entity<RH_Usuario>().HasData(
                new RH_Usuario
                {
                    ID = 1,
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Email = "juancito@gmail.com",
                    Telefono = "123456789"
                },
                new RH_Usuario
                {
                    ID = 2,
                    Nombre = "Maria",
                    Apellido = "Gomez",
                    Email = "gomezmaria@gmail.com",
                    Telefono = "222222"
                }
            );

            modelBuilder.Entity<RH_Empleado>().HasData(
                new RH_Empleado
                {
                    ID = 1,
                    Nombre = "Empleado1",
                    Apellido = "Apellido1",
                    Cargo = "Mucama",
                    Telefono = "111111"
                },
                new RH_Empleado
                {
                    ID = 2,
                    Nombre = "Empleado2",
                    Apellido = "Apellido2",
                    Cargo = "Limpieza",
                    Telefono = "333333"
                }
            );

            modelBuilder.Entity<RH_Habitacion>().HasData(
                new RH_Habitacion
                {
                    ID = 1,
                    TipoHabitacion = "Doble",
                    Capacidad = 2,
                    PrecioPorNoche = 50000,
                    Disponible = true
                },
                new RH_Habitacion
                {
                    ID = 2,
                    TipoHabitacion = "Simple",
                    Capacidad = 1,
                    PrecioPorNoche = 30000,
                    Disponible = false
                }
            );

            modelBuilder.Entity<RH_Pago>().HasData(
                new RH_Pago
                {
                    ID = 1,
                    Monto = 50000,
                    FechaPago = new DateTime(2024, 09, 15),
                    ReservaID = 1

                },
                new RH_Pago
                {
                    ID = 2,
                    Monto = 30000,
                    FechaPago = new DateTime(2024, 08, 13),
                    ReservaID = 2
                }
            );

            modelBuilder.Entity<RH_Reserva>().HasData(
                new RH_Reserva
                {
                    ID = 1,
                    FechaReserva = new DateTime(2024, 09, 05),
                    FechaCheckIn = new DateTime(2024, 09, 10),
                    FechaCheckOut = new DateTime(2024, 09, 15),
                    EstadoReserva = "Activa",
                    UsuarioID = 1,
                    HabitacionID = 1,
                    PagoID = 1
                },
                new RH_Reserva
                {
                    ID = 2,
                    FechaReserva = new DateTime(2024, 08, 03),
                    FechaCheckIn = new DateTime(2024, 08, 10),
                    FechaCheckOut = new DateTime(2024, 08, 13),
                    EstadoReserva = "Cancelada",
                    UsuarioID = 2,
                    HabitacionID = 2,
                    PagoID = 2
                }
            );

            modelBuilder.Entity<RH_Servicio>().HasData(
                new RH_Servicio
                {
                    ID = 1,
                    Nombre = "Desayuno",
                    Precio = 10000,
                    Descripcion = "Desayuno completo"
                },
                 new RH_Servicio
                 {
                     ID = 2,
                     Nombre = "Almuerzo",
                     Precio = 20000,
                     Descripcion = "Almuerzo completo"
                 }
            );

            modelBuilder.Entity<RH_ServicioAdicional>().HasData(
               new RH_ServicioAdicional
               {
                   ID = 1,
                   TipoServicio = "Servicio de Habitacion",
                   FechaSolicitud = new DateTime(2024, 09, 11),
                   ReservaID = 1
               },
               new RH_ServicioAdicional
               {
                   ID = 2,
                   TipoServicio = "Servicio de Lavanderia",
                   FechaSolicitud = new DateTime(2024, 08, 12),
                   ReservaID = 2
               }
            );
            #endregion

            #region Definición de filtros de eliminación
            // (este código no lo habilitamos todavía porque es cuando agregamos un campo Eliminado a las tablas y modificamos los
            // ApiControllers para que al mandar a eliminar solo cambien este campo y lo pongan en verdadero, esta configuración de
            // eliminación hace que el sistema ignore los registros que tengan el eliminado en verdadero, así que hace que en
            // apariencia y funcionalidad esté "eliminado", pero van a seguir estando ahí para que podamos observar las eliminaciones que hubo)

            modelBuilder.Entity<RH_Empleado>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<RH_Habitacion>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<RH_Pago>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<RH_Reserva>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<RH_Servicio>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<RH_ServicioAdicional>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<RH_Usuario>().HasQueryFilter(m => !m.Eliminado);

            #endregion
        }
        



    }
}
