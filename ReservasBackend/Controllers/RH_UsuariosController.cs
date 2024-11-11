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
    public class RH_UsuariosController : ControllerBase
    {
        private readonly ReservaHoteleriaContext _context;

        public RH_UsuariosController(ReservaHoteleriaContext context)
        {
            _context = context;
        }

        // GET: api/RH_Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RH_Usuario>>> GetRH_Usuarios([FromQuery] string? filtro)
        {
            if (filtro != null)
            {
                return await _context.RH_Usuarios.Where(u => u.Nombre.Contains(filtro)).ToListAsync();
            }
            return await _context.RH_Usuarios.ToListAsync();
        }

        // GET: api/RH_Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RH_Usuario>> GetRH_Usuario(int id)
        {
            var rH_Usuario = await _context.RH_Usuarios.FindAsync(id);

            if (rH_Usuario == null)
            {
                return NotFound();
            }

            return rH_Usuario;
        }

        // PUT: api/RH_Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRH_Usuario(int id, RH_Usuario rH_Usuario)
        {
            if (id != rH_Usuario.ID)
            {
                return BadRequest();
            }

            _context.Entry(rH_Usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RH_UsuarioExists(id))
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

        // POST: api/RH_Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RH_Usuario>> PostRH_Usuario(RH_Usuario rH_Usuario)
        {
            _context.RH_Usuarios.Add(rH_Usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRH_Usuario", new { id = rH_Usuario.ID }, rH_Usuario);
        }

        // DELETE: api/RH_Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRH_Usuario(int id)
        {
            var rH_Usuario = await _context.RH_Usuarios.FindAsync(id);
            if (rH_Usuario == null)
            {
                return NotFound();
            }

            _context.RH_Usuarios.Remove(rH_Usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RH_UsuarioExists(int id)
        {
            return _context.RH_Usuarios.Any(e => e.ID == id);
        }
    }
}
