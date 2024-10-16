using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservasBackend.DataContext;
using ReservasHoteleriaServices.Models;

namespace ReservasBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RH_HabitacionesController : ControllerBase
    {
        private readonly ReservaHoteleriaContext _context;

        public RH_HabitacionesController(ReservaHoteleriaContext context)
        {
            _context = context;
        }

        // GET: api/RH_Habitaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RH_Habitacion>>> GetRH_Habitaciones()
        {
            return await _context.RH_Habitaciones.ToListAsync();
        }

        // GET: api/RH_Habitaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RH_Habitacion>> GetRH_Habitacion(int id)
        {
            var rH_Habitacion = await _context.RH_Habitaciones.FindAsync(id);

            if (rH_Habitacion == null)
            {
                return NotFound();
            }

            return rH_Habitacion;
        }

        // PUT: api/RH_Habitaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRH_Habitacion(int id, RH_Habitacion rH_Habitacion)
        {
            if (id != rH_Habitacion.ID)
            {
                return BadRequest();
            }

            _context.Entry(rH_Habitacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RH_HabitacionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RH_Habitaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RH_Habitacion>> PostRH_Habitacion(RH_Habitacion rH_Habitacion)
        {
            _context.RH_Habitaciones.Add(rH_Habitacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRH_Habitacion", new { id = rH_Habitacion.ID }, rH_Habitacion);
        }

        // DELETE: api/RH_Habitaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRH_Habitacion(int id)
        {
            var rH_Habitacion = await _context.RH_Habitaciones.FindAsync(id);
            if (rH_Habitacion == null)
            {
                return NotFound();
            }

            _context.RH_Habitaciones.Remove(rH_Habitacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RH_HabitacionExists(int id)
        {
            return _context.RH_Habitaciones.Any(e => e.ID == id);
        }
    }
}
