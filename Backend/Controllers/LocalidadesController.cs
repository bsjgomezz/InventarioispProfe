using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Services.Models;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocalidadesController : ControllerBase
    {
        private readonly InventarioContext _context;

        public LocalidadesController(InventarioContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Localidad>>> GetLocalidades()
        {
            return await _context.Localidades.Include(l => l.Provincia).ThenInclude(p => p.Pais).ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Localidad>> GetLocalidades(int id)
        {
            var Localidad = await _context.Localidades.Include(l => l.Provincia).ThenInclude(p => p.Pais).FirstOrDefaultAsync(l => l.Id == id);

            if (Localidad == null)
            {
                return NotFound();
            }

            return Localidad;
        }

        // POST: api/Localidades
        [HttpPost]
        public async Task<ActionResult<Localidad>> PostLocalidad(Localidad localidad)
        {
            _context.Localidades.Add(localidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLocalidades), new { id = localidad.Id }, localidad);
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalidad(int id, Localidad localidad)
        {
            if (id != localidad.Id)
            {
                return BadRequest();
            }

            // Attach and mark modified
            _context.Entry(localidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalidadesExists(id))
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

        // DELETE: api/Clientes/5
        // This performs a soft-delete by setting IsDeleted = true so the global query filter hides it.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocalidades(int id)
        {
            var localidad = await _context.Localidades.FindAsync(id);
            if (localidad == null)
            {
                return NotFound();
            }
            localidad.IsDeleted = true;
            localidad.IsDeleted = true;
            _context.Entry(localidad).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

              // devolvemos el total de clientes que no estan eliminados
        [HttpGet("total")]
        public async Task<ActionResult<int>> GetTotalLocalidades()
        {
            return await _context.Localidades.CountAsync(c => !c.IsDeleted);
        }

        private bool LocalidadesExists(int id)
        {
            return _context.Localidades.Any(e => e.Id == id);
        }
    }
}
