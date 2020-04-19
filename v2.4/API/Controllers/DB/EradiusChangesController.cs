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
    public class EradiusChangesController : ControllerBase
    {
        private readonly DBContext _context;

        public EradiusChangesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EradiusChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EradiusChanges>>> GetEradiusChanges()
        {
            return await _context.EradiusChanges.ToListAsync();
        }

        // GET: api/EradiusChanges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EradiusChanges>> GetEradiusChanges(long id)
        {
            var eradiusChanges = await _context.EradiusChanges.FindAsync(id);

            if (eradiusChanges == null)
            {
                return NotFound();
            }

            return eradiusChanges;
        }

        // PUT: api/EradiusChanges/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEradiusChanges(long id, EradiusChanges eradiusChanges)
        {
            if (id != eradiusChanges.EradiusChangesId)
            {
                return BadRequest();
            }

            _context.Entry(eradiusChanges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EradiusChangesExists(id))
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

        // POST: api/EradiusChanges
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EradiusChanges>> PostEradiusChanges(EradiusChanges eradiusChanges)
        {
            _context.EradiusChanges.Add(eradiusChanges);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EradiusChangesExists(eradiusChanges.EradiusChangesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEradiusChanges", new { id = eradiusChanges.EradiusChangesId }, eradiusChanges);
        }

        // DELETE: api/EradiusChanges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EradiusChanges>> DeleteEradiusChanges(long id)
        {
            var eradiusChanges = await _context.EradiusChanges.FindAsync(id);
            if (eradiusChanges == null)
            {
                return NotFound();
            }

            _context.EradiusChanges.Remove(eradiusChanges);
            await _context.SaveChangesAsync();

            return eradiusChanges;
        }

        private bool EradiusChangesExists(long id)
        {
            return _context.EradiusChanges.Any(e => e.EradiusChangesId == id);
        }
    }
}
