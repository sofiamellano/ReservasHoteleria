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
    public class ServicioAdicionalService : GenericService<RH_ServicioAdicional>, IServicioAdicionalService
    {
        public async Task<List<RH_ServicioAdicional>?> GetServiciosAdicionalesByReservaAsync(int idReserva)
        {
            var response = await client.GetAsync($"{_endpoint}/GetServiciosAdicionalesByReserva/{idReserva}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<RH_ServicioAdicional>>(content, options);
        }
    }
}
