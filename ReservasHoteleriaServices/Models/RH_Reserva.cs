using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Models
{
    public class RH_Reserva
    {
        public int ID { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaCheckIn { get; set; }
        public DateTime FechaCheckOut { get; set; }
        public string EstadoReserva { get; set; } // (Confirmada, Cancelada, etc.)
        public bool Eliminado { get; set; } = false;

        // Claves foráneas
        public int? HabitacionID { get; set; }
        public virtual RH_Habitacion? Habitacion { get; set; }


    }
}
