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
    public class EreplacementOfController : ControllerBase
    {
        private readonly DBContext _context;

        public EreplacementOfController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EreplacementOf
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EreplacementOf>>> GetEreplacementOf()
        {
            return await _context.EreplacementOf.ToListAsync();
        }

        // GET: api/EreplacementOf/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EreplacementOf>> GetEreplacementOf(long id)
        {
            var ereplacementOf = await _context.EreplacementOf.FindAsync(id);

            if (ereplacementOf == null)
            {
                return NotFound();
            }

            return ereplacementOf;
        }

        // PUT: api/EreplacementOf/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEreplacementOf(long id, EreplacementOf ereplacementOf)
        {
            if (id != ereplacementOf.EreplacementOfId)
            {
                return BadRequest();
            }

            _context.Entry(ereplacementOf).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EreplacementOfExists(id))
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

        // POST: api/EreplacementOf
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EreplacementOf>> PostEreplacementOf(EreplacementOf ereplacementOf)
        {
            _context.EreplacementOf.Add(ereplacementOf);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EreplacementOfExists(ereplacementOf.EreplacementOfId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEreplacementOf", new { id = ereplacementOf.EreplacementOfId }, ereplacementOf);
        }

        // DELETE: api/EreplacementOf/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EreplacementOf>> DeleteEreplacementOf(long id)
        {
            var ereplacementOf = await _context.EreplacementOf.FindAsync(id);
            if (ereplacementOf == null)
            {
                return NotFound();
            }

            _context.EreplacementOf.Remove(ereplacementOf);
            await _context.SaveChangesAsync();

            return ereplacementOf;
        }

        private bool EreplacementOfExists(long id)
        {
            return _context.EreplacementOf.Any(e => e.EreplacementOfId == id);
        }
    }
}
