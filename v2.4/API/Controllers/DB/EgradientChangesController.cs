using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.DB;

namespace API.Controllers.DB
{
    [Route("api/[controller]")]
    [ApiController]
    public class EgradientChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EgradientChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EgradientChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EgradientChanges>>> GetEgradientChanges()
        {
            return await _context.EgradientChanges.ToListAsync();
        }

        // GET: api/EgradientChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EgradientChanges>> GetEgradientChanges(long id)
        {
            var egradientChanges = await _context.EgradientChanges.FindAsync(id);

            if (egradientChanges == null)
            {
                return NotFound();
            }

            return egradientChanges;
        }

        // PUT: api/EgradientChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgradientChanges(long id, EgradientChanges egradientChanges)
        {
            if (id != egradientChanges.EgradientChangesId)
            {
                return BadRequest();
            }

            _context.Entry(egradientChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgradientChangesExists(id))
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

        // POST: api/EgradientChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EgradientChanges>> PostEgradientChanges(EgradientChanges egradientChanges)
        {
            _context.EgradientChanges.Add(egradientChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgradientChangesExists(egradientChanges.EgradientChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgradientChanges", new { id = egradientChanges.EgradientChangesId }, egradientChanges);
        }

        // DELETE: api/EgradientChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EgradientChanges>> DeleteEgradientChanges(long id)
        {
            var egradientChanges = await _context.EgradientChanges.FindAsync(id);
            if (egradientChanges == null)
            {
                return NotFound();
            }

            _context.EgradientChanges.Remove(egradientChanges);
            await _context.SaveChangesAsync();

            return egradientChanges;
        }

        private bool EgradientChangesExists(long id)
        {
            return _context.EgradientChanges.Any(e => e.EgradientChangesId == id);
        }
    }
}
