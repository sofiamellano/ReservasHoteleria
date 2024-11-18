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
    public class RH_ServiciosAdicionalesController : ControllerBase
    {
        private readonly ReservaHoteleriaContext _context;

        public RH_ServiciosAdicionalesController(ReservaHoteleriaContext context)
        {
            _context = context;
        }

        // GET: api/RH_ServiciosAdicionales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RH_ServicioAdicional>>> GetRH_ServiciosAdicionales([FromQuery] string? filtro)
        {
            if (filtro != null)
            {
                return await _context.RH_ServiciosAdicionales.Where(s => s.TipoServicio.Contains(filtro)).ToListAsync();
            }
            return await _context.RH_ServiciosAdicionales.ToListAsync();
        }

        // GET: api/RH_ServiciosAdicionales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RH_ServicioAdicional>> GetRH_ServicioAdicional(int id)
        {
            var rH_ServicioAdicional = await _context.RH_ServiciosAdicionales.FindAsync(id);

            if (rH_ServicioAdicional == null)
            {
                return NotFound();
            }

            return rH_ServicioAdicional;
        }

        // PUT: api/RH_ServiciosAdicionales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRH_ServicioAdicional(int id, RH_ServicioAdicional rH_ServicioAdicional)
        {
            if (id != rH_ServicioAdicional.ID)
            {
                return BadRequest();
            }

            _context.Entry(rH_ServicioAdicional).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RH_ServicioAdicionalExists(id))
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

        // POST: api/RH_ServiciosAdicionales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RH_ServicioAdicional>> PostRH_ServicioAdicional(RH_ServicioAdicional rH_ServicioAdicional)
        {
            _context.RH_ServiciosAdicionales.Add(rH_ServicioAdicional);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRH_ServicioAdicional", new { id = rH_ServicioAdicional.ID }, rH_ServicioAdicional);
        }

        // DELETE: api/RH_ServiciosAdicionales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRH_ServicioAdicional(int id)
        {
            var rH_ServicioAdicional = await _context.RH_ServiciosAdicionales.FindAsync(id);
            if (rH_ServicioAdicional == null)
            {
                return NotFound();
            }

            _context.RH_ServiciosAdicionales.Remove(rH_ServicioAdicional);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RH_ServicioAdicionalExists(int id)
        {
            return _context.RH_ServiciosAdicionales.Any(e => e.ID == id);
        }
    }
}
