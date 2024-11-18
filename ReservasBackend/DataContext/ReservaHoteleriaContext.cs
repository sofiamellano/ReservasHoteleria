using Microsoft.EntityFrameworkCore;
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

        public virtual DbSet<RH_Habitacion> RH_Habitaciones { get; set; }
        public virtual DbSet<RH_Reserva> RH_Reservas { get; set; }
        public virtual DbSet<RH_ServicioAdicional> RH_ServiciosAdicionales { get; set; }
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

            #region Datos Semilla 


            modelBuilder.Entity<RH_Empleado>().HasData(
                new RH_Empleado
                {
                    ID = 1,
                    Nombre = "Sofía",
                    Cargo = "Recepcionista",
                },
                new RH_Empleado
                {
                    ID = 2,
                    Nombre = "Miguel",
                    Cargo = "Conserje",
                },
                new RH_Empleado
                {
                    ID = 3,
                    Nombre = "Ana",
                    Cargo = "Mucama",
                }
            );

            modelBuilder.Entity<RH_Habitacion>().HasData(
                new RH_Habitacion
                {
                    ID = 1,
                    TipoHabitacion = "Suite",
                    PrecioPorNoche = 120000,
                    Disponible = true
                },
                new RH_Habitacion
                {
                    ID = 2,
                    TipoHabitacion = "Doble",
                    PrecioPorNoche = 60000,
                    Disponible = false
                },
                new RH_Habitacion
                {
                    ID = 3,
                    TipoHabitacion = "Simple",
                    PrecioPorNoche = 35000,
                    Disponible = true
                }
            );


            modelBuilder.Entity<RH_Reserva>().HasData(
                new RH_Reserva
                {
                    ID = 1,
                    FechaReserva = new DateTime(2024, 10, 10),
                    FechaCheckIn = new DateTime(2024, 10, 15),
                    FechaCheckOut = new DateTime(2024, 10, 20),
                    EstadoReserva = "Confirmada",
                    HabitacionID = 1
                    
                },
                new RH_Reserva
                {
                    ID = 2,
                    FechaReserva = new DateTime(2024, 09, 01),
                    FechaCheckIn = new DateTime(2024, 09, 10),
                    FechaCheckOut = new DateTime(2024, 09, 12),
                    EstadoReserva = "Cancelada",
                    HabitacionID = 3,
                },
                new RH_Reserva
                {
                    ID = 3,
                    FechaReserva = new DateTime(2024, 09, 15),
                    FechaCheckIn = new DateTime(2024, 09, 18),
                    FechaCheckOut = new DateTime(2024, 09, 20),
                    EstadoReserva = "Pendiente",
                    HabitacionID = 2,
                }
            );

            modelBuilder.Entity<RH_Servicio>().HasData(
                new RH_Servicio
                {
                    ID = 1,
                    Nombre = "Desayuno Buffet",
                    Precio = 15000,
                },
                new RH_Servicio
                {
                    ID = 2,
                    Nombre = "Spa y Masajes",
                    Precio = 45000,
                },
                new RH_Servicio
                {
                    ID = 3,
                    Nombre = "Servicio de Lavandería",
                    Precio = 10000,
                }
            );

            modelBuilder.Entity<RH_ServicioAdicional>().HasData(
                new RH_ServicioAdicional
                {
                    ID = 1,
                    TipoServicio = "Transporte al aeropuerto",
                    ReservaID = 1
                },
                new RH_ServicioAdicional
                {
                    ID = 2,
                    TipoServicio = "Decoración especial",
                    ReservaID = 3
                },
                new RH_ServicioAdicional
                {
                    ID = 3,
                    TipoServicio = "Limpieza extra",
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
            modelBuilder.Entity<RH_Reserva>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<RH_Servicio>().HasQueryFilter(m => !m.Eliminado);
            modelBuilder.Entity<RH_ServicioAdicional>().HasQueryFilter(m => !m.Eliminado);
            #endregion
        }
        



    }
}
