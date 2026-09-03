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
    public class ProvinciasController : ControllerBase
    {
        private readonly InventarioContext _context;

        public ProvinciasController(InventarioContext context)
        {
            _context = context;
        }

        // GET: api/Provincias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincia>>> GetProvincias()
        {
            return await _context.Provincias.Include(p => p.Pais).ToListAsync();
        }

        // GET: api/Provincias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provincia>> GetProvincia(int id)
        {
            var Provincia = await _context.Provincias.FindAsync(id);

            if (Provincia == null)
            {
                return NotFound();
            }

            return Provincia;
        }

        // POST: api/Provincias
        [HttpPost]
        public async Task<ActionResult<Provincia>> PostProvincia(Provincia provincia)
        {
            _context.Provincias.Add(provincia);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProvincia), new { id = provincia.Id }, provincia);
        }

        // PUT: api/Provincias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProvincia(int id, Provincia provincia)
        {
            if (id != provincia.Id)
            {
                return BadRequest();
            }

            // Attach and mark modified
            _context.Entry(provincia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinciasExists(id))
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

        // DELETE: api/Provincias/5
        // This performs a soft-delete by setting IsDeleted = true so the global query filter hides it.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvincias(int id)
        {
            var provincia = await _context.Provincias.FindAsync(id);
            if (provincia == null)
            {
                return NotFound();
            }
            provincia.IsDeleted = true;
            _context.Entry(provincia).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

              // devolvemos el total de clientes que no estan eliminados
        [HttpGet("total")]
        public async Task<ActionResult<int>> GetTotalProvincias()
        {
            return await _context.Provincias.CountAsync(c => !c.IsDeleted);
        }

        private bool ProvinciasExists(int id)
        {
            return _context.Provincias.Any(e => e.Id == id);
        }
    }
}
