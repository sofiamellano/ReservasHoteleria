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
    public class ServicioService : GenericService<RH_Servicio>, IServicioService
    {
        public async Task<List<RH_Servicio>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<RH_Servicio>>(content, options);
        }
    }
}
