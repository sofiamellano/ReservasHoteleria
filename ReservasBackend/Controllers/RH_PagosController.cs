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
    public class RH_PagosController : ControllerBase
    {
        private readonly ReservaHoteleriaContext _context;

        public RH_PagosController(ReservaHoteleriaContext context)
        {
            _context = context;
        }

        // GET: api/RH_Pagos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RH_Pago>>> GetRH_Pagos([FromQuery] string? filtro)
        {
            if (filtro != null)
            {
                return await _context.RH_Pagos.Where(p => p.FechaPago.Equals(filtro)).ToListAsync();
            }
            return await _context.RH_Pagos.ToListAsync();
        }

        // GET: api/RH_Pagos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RH_Pago>> GetRH_Pago(int id)
        {
            var rH_Pago = await _context.RH_Pagos.FindAsync(id);

            if (rH_Pago == null)
            {
                return NotFound();
            }

            return rH_Pago;
        }

        // PUT: api/RH_Pagos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRH_Pago(int id, RH_Pago rH_Pago)
        {
            if (id != rH_Pago.ID)
            {
                return BadRequest();
            }

            _context.Entry(rH_Pago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RH_PagoExists(id))
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

        // POST: api/RH_Pagos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RH_Pago>> PostRH_Pago(RH_Pago rH_Pago)
        {
            _context.RH_Pagos.Add(rH_Pago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRH_Pago", new { id = rH_Pago.ID }, rH_Pago);
        }

        // DELETE: api/RH_Pagos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRH_Pago(int id)
        {
            var rH_Pago = await _context.RH_Pagos.FindAsync(id);
            if (rH_Pago == null)
            {
                return NotFound();
            }

            _context.RH_Pagos.Remove(rH_Pago);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RH_PagoExists(int id)
        {
            return _context.RH_Pagos.Any(e => e.ID == id);
        }
    }
}
