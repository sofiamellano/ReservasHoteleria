using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ReservasHoteleriaServices.Models;

namespace ReservasBackend.DataContext
{
    public class ReservaHoteleriaContext : DbContext
    {
        public ReservaHoteleriaContext()
        {
        }

        public ReservaHoteleriaContext(DbContextOptions<ReservaHoteleriaContext> options) : base(options)
        {
        }
        public DbSet<RH_Usuario> Usuarios { get; set; }
        //public DbSet<RH_Habitacion> Habitaciones { get; set; }
        //public DbSet<RH_Reserva> Reservas { get; set; }
        //public DbSet<RH_ServicioAdicional> ServiciosAdicionales { get; set; }
        //public DbSet<RH_Cliente> Clientes { get; set; }
        //public DbSet<RH_Pago> Pagos { get; set; }
        //public DbSet<RH_Evaluacion> Evaluaciones { get; set; }
        //public DbSet<RH_Servicio> Servicios { get; set; }
        //public DbSet<RH_Empleado> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                                    //.SetBasePath(Directory.GetCurrentDirectory()) Especifica para escritorio
                                    .AddJsonFile("appsettings.json")
                                    .Build();
            string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

            optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
        }

        //Datos semillas
        #region Datos Semilla Usuarios
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RH_Usuario>().HasData(
                new RH_Usuario
                {
                    ID = 1,
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Email = "juancito@gmail.com",
                    Telefono = "123456789"
                }
            );
        }
        #endregion
    }
}
