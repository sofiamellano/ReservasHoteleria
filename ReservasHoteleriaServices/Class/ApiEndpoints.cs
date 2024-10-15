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
        public static string RH_Pago { get;  set; } = "pago";
        public  static string RH_Reserva { get;  set; } = "reserva";
        public static string RH_Servicio { get;  set; } = "servicio";
        public static string RH_ServicioAdicional { get;  set; } = "servicioadicional";
        public static string RH_Usuario { get;  set; } = "usuario"; 

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                "RH_Empleado" => RH_Empleado,
                "RH_Habitacion" => RH_Habitacion,
                "RH_Pago" => RH_Pago,
                "RH_Reserva" => RH_Reserva,
                "RH_Servicio" => RH_Servicio,
                "RH_ServicioAdicional" => RH_ServicioAdicional,
                "RH_Usuario" => RH_Usuario,
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido."),
            };
        }
    }
}
