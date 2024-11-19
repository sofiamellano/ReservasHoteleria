using ReservasHoteleriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Interfaces
{
    public interface IServicioService : IGenericService<RH_Servicio>
    {
        public Task<List<RH_Servicio>?> GetAllAsync(string? filtro);
    }
}
