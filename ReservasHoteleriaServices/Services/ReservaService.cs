using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Models;
using System.Text.Json;

namespace ReservasHoteleriaServices.Services
{
    public class ReservaService : GenericService<RH_Reserva>, IReservaService
    { 
        public async Task<List<RH_Reserva>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<RH_Reserva>>(content, options);
        }
    }
}
