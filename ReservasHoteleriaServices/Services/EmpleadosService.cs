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
    public class EmpleadosService : GenericService<RH_Empleado>, IEmpleadosService
    {
        public async Task<List<RH_Empleado>?> GetAllAsync(string? filtro)
        {
            var response = await client.GetAsync($"{_endpoint}?filtro={filtro}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<RH_Empleado>>(content, options);
        }

    }
}
