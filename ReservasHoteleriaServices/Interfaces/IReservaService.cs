using ReservasHoteleriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Interfaces
{
    public interface IReservaService : IGenericService<RH_Reserva>
    {
       public Task<List<RH_Reserva>?> GetReservasByHotelAsync(int idHotel);

        public Task<List<RH_Reserva>?> GetAllAsync(string? filtro);
    }
}
