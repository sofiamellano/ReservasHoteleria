using ReservasHoteleriaServices.Interfaces;
using ReservasHoteleriaServices.Models;
using System.Text.Json;

namespace ReservasHoteleriaServices.Services
{
    public class HabitacionService : GenericService<RH_Habitacion>, IHabitacionService
    { 
        public async Task<List<RH_Habitacion>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<RH_Habitacion>>(content, options);
        }
    }
}
