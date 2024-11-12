using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Models
{
    public class RH_Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public bool Eliminado { get; set; } = false;
    }
}
