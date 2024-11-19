using ReservasHoteleriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Interfaces
{
    public interface IEmpleadosService : IGenericService<RH_Empleado>
    {
        public Task<List<RH_Empleado>?> GetAllAsync(string? filtro);
    }
}
