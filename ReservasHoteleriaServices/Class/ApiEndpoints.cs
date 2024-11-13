using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReservasHoteleriaServices.Class
{
    public static class ApiEndpoints
    {
        public  static string RH_Empleado { get;  set; } = "empleado";
        public  static string RH_Habitacion { get;  set; } = "habitacion";
        public  static string RH_Reserva { get;  set; } = "reserva";
        public static string RH_Servicio { get;  set; } = "servicio";
        public static string RH_ServicioAdicional { get;  set; } = "servicioadicional";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                "RH_Empleado" => "api/RH_Empleados",
                "RH_Habitacion" => "api/RH_Habitaciones",
                "RH_Reserva" => "api/RH_Reservas",
                "RH_Servicio" => "api/RH_Servicios",
                "RH_ServicioAdicional" => "api/RH_ServiciosAdicionales",
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido."),
            };
        }
    }
}
