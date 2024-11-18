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
    public class RH_ReservasController : ControllerBase
    {
        private readonly ReservaHoteleriaContext _context;

        public RH_ReservasController(ReservaHoteleriaContext context)
        {
            _context = context;
        }

        // GET: api/RH_Reservas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RH_Reserva>>> GetRH_Reservas([FromQuery] string? filtro)
        {
            var reservas = await _context.RH_Reservas
         .Include(r => r.Habitacion)
         .Where(r => filtro == null || r.EstadoReserva.Contains(filtro))
         .ToListAsync();

            return Ok(reservas);
        }

        // GET: api/RH_Reservas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RH_Reserva>> GetRH_Reserva(int id)
        {
            var rH_Reserva = await _context.RH_Reservas.FindAsync(id);

            if (rH_Reserva == null)
            {
                return NotFound();
            }

            return rH_Reserva;
        }

        // PUT: api/RH_Reservas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRH_Reserva(int id, RH_Reserva rH_Reserva)
        {
            if (id != rH_Reserva.ID)
            {
                return BadRequest();
            }

            _context.Entry(rH_Reserva).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RH_ReservaExists(id))
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

        // POST: api/RH_Reservas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RH_Reserva>> PostRH_Reserva(RH_Reserva rH_Reserva)
        {
            _context.RH_Reservas.Add(rH_Reserva);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRH_Reserva", new { id = rH_Reserva.ID }, rH_Reserva);
        }

        // DELETE: api/RH_Reservas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRH_Reserva(int id)
        {
            var rH_Reserva = await _context.RH_Reservas.FindAsync(id);
            if (rH_Reserva == null)
            {
                return NotFound();
            }

            _context.RH_Reservas.Remove(rH_Reserva);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RH_ReservaExists(int id)
        {
            return _context.RH_Reservas.Any(e => e.ID == id);
        }
    }
}
