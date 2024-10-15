using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Models
{
    public class RH_Pago
    {
        public int ID { get; set; }
        public decimal Monto { get; set; } // Monto del pago
        public DateTime FechaPago { get; set; } // Fecha en que se realizó el pago
        public bool Eliminado { get; set; } = false;

        public int? ReservaID { get; set; }
        public RH_Reserva? Reserva { get; set; }
        //public virtual RH_Reserva? Reserva { get; set; } // Relación con la reserva
    }
}
