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
        public bool Eliminado { get; set; } = false;
    }

}
