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
    public class PaisesController : ControllerBase
    {
        private readonly InventarioContext _context;

        public PaisesController(InventarioContext context)
        {
            _context = context;
        }

        // GET: api/Paises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pais>>> GetPaises()
        {
            return await _context.Paises.ToListAsync();
        }

        // GET: api/Paises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pais>> GetPais(int id)
        {
            var pais = await _context.Paises.FindAsync(id);

            if (pais == null)
            {
                return NotFound();
            }

            return pais;
        }

        // POST: api/Paises
        [HttpPost]
        public async Task<ActionResult<Pais>> PostPais(Pais pais)
        {
            _context.Paises.Add(pais);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPais), new { id = pais.Id }, pais);
        }

        // PUT: api/Paises/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPais(int id, Pais pais)
        {
            if (id != pais.Id)
            {
                return BadRequest();
            }

            _context.Entry(pais).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaisesExists(id))
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

        // DELETE: api/Paises/5
        // This performs a soft-delete by setting IsDeleted = true so the global query filter hides it.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaises(int id)
        {
            var pais = await _context.Paises.FindAsync(id);
            if (pais == null)
            {
                return NotFound();
            }

            pais.IsDeleted = true;
            _context.Entry(pais).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // devolvemos el total de paises que no estan eliminados
        [HttpGet("total")]
        public async Task<ActionResult<int>> GetTotalPaises()
        {
            return await _context.Paises.CountAsync(c => !c.IsDeleted);
        }

        private bool PaisesExists(int id)
        {
            return _context.Paises.Any(e => e.Id == id);
        }
    }
}
