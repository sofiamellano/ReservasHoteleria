using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Models
{
    public class RH_Usuario
    {
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        [Required]
        public string Telefono { get; set; }

        // Relación con RH_Reserva
     //   public ICollection<RH_Reserva> Reservas { get; set; }
    }

}
