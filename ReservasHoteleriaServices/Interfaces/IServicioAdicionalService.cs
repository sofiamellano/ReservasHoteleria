using ReservasHoteleriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Interfaces
{
    public interface IServicioAdicionalService : IGenericService<RH_ServicioAdicional>
    {
        public Task<List<RH_ServicioAdicional>?> GetServiciosAdicionalesByReservaAsync(int idReserva);
    }
}
