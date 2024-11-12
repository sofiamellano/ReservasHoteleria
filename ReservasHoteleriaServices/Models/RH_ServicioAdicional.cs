using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Models
{
    public class RH_ServicioAdicional
    {
        public int ID { get; set; }
        public string TipoServicio { get; set; } // (Comida, Transporte, etc.)
        public bool Eliminado { get; set; } = false;

        // Clave foránea
        public int? ReservaID { get; set; }
    }
}
