using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Services
{
    public class ReservaService : GenericService<RH_Reserva>, IReservaService
    {
        public async Task<List<RH_Reserva>?> GetReservasByHotelAsync(int idHotel)
        {
            var response = await client.GetAsync($"{_endpoint}/GetReservasByHotel/{idHotel}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<RH_Reserva>>(content, options);
        }
    }
}
