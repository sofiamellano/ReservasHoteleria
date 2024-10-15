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
    public class RH_EmpleadosController : ControllerBase
    {
        private readonly ReservaHoteleriaContext _context;

        public RH_EmpleadosController(ReservaHoteleriaContext context)
        {
            _context = context;
        }

        // GET: api/RH_Empleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RH_Empleado>>> GetRH_Empleados()
        {
            return await _context.RH_Empleados.ToListAsync();
        }

        // GET: api/RH_Empleados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RH_Empleado>> GetRH_Empleado(int id)
        {
            var rH_Empleado = await _context.RH_Empleados.FindAsync(id);

            if (rH_Empleado == null)
            {
                return NotFound();
            }

            return rH_Empleado;
        }

        // PUT: api/RH_Empleados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRH_Empleado(int id, RH_Empleado rH_Empleado)
        {
            if (id != rH_Empleado.ID)
            {
                return BadRequest();
            }

            _context.Entry(rH_Empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RH_EmpleadoExists(id))
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

        // POST: api/RH_Empleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RH_Empleado>> PostRH_Empleado(RH_Empleado rH_Empleado)
        {
            _context.RH_Empleados.Add(rH_Empleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRH_Empleado", new { id = rH_Empleado.ID }, rH_Empleado);
        }

        // DELETE: api/RH_Empleados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRH_Empleado(int id)
        {
            var rH_Empleado = await _context.RH_Empleados.FindAsync(id);
            if (rH_Empleado == null)
            {
                return NotFound();
            }

            _context.RH_Empleados.Remove(rH_Empleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RH_EmpleadoExists(int id)
        {
            return _context.RH_Empleados.Any(e => e.ID == id);
        }
    }
}
