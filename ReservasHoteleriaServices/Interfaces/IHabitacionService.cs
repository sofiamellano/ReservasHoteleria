using ReservasHoteleriaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHoteleriaServices.Interfaces
{
    public interface IHabitacionService : IGenericService<RH_Habitacion>
    {
        public Task<List<RH_Habitacion>?> GetAllAsync(string? filtro);
    }
}
