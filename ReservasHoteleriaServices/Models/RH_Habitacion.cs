using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Models
{
    public class RH_Habitacion
    {
        public int ID { get; set; }
        public string TipoHabitacion { get; set; } // (Individual, Doble, Suite, etc.)
        public decimal PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public bool Eliminado { get; set; } = false;

        public override string ToString() => TipoHabitacion;
    }
}
