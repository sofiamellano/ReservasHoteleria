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
    public class RH_ServiciosController : ControllerBase
    {
        private readonly ReservaHoteleriaContext _context;

        public RH_ServiciosController(ReservaHoteleriaContext context)
        {
            _context = context;
        }

        // GET: api/RH_Servicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RH_Servicio>>> GetRH_Servicios([FromQuery] string? filtro)
        {
            if (filtro != null)
            {
                return await _context.RH_Servicios.Where(x => x.Nombre.Contains(filtro)).ToListAsync();
            }
            return await _context.RH_Servicios.ToListAsync();
        }

        // GET: api/RH_Servicios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RH_Servicio>> GetRH_Servicio(int id)
        {
            var rH_Servicio = await _context.RH_Servicios.FindAsync(id);

            if (rH_Servicio == null)
            {
                return NotFound();
            }

            return rH_Servicio;
        }

        // PUT: api/RH_Servicios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRH_Servicio(int id, RH_Servicio rH_Servicio)
        {
            if (id != rH_Servicio.ID)
            {
                return BadRequest();
            }

            _context.Entry(rH_Servicio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RH_ServicioExists(id))
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

        // POST: api/RH_Servicios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RH_Servicio>> PostRH_Servicio(RH_Servicio rH_Servicio)
        {
            _context.RH_Servicios.Add(rH_Servicio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRH_Servicio", new { id = rH_Servicio.ID }, rH_Servicio);
        }

        // DELETE: api/RH_Servicios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRH_Servicio(int id)
        {
            var rH_Servicio = await _context.RH_Servicios.FindAsync(id);
            if (rH_Servicio == null)
            {
                return NotFound();
            }

            _context.RH_Servicios.Remove(rH_Servicio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RH_ServicioExists(int id)
        {
            return _context.RH_Servicios.Any(e => e.ID == id);
        }
    }
}
