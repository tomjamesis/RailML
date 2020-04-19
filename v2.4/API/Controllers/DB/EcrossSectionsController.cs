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
    public class EcrossSectionsController : ControllerBase
    {
        private readonly DBContext _context;

        public EcrossSectionsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EcrossSections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EcrossSections>>> GetEcrossSections()
        {
            return await _context.EcrossSections.ToListAsync();
        }

        // GET: api/EcrossSections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EcrossSections>> GetEcrossSections(long id)
        {
            var ecrossSections = await _context.EcrossSections.FindAsync(id);

            if (ecrossSections == null)
            {
                return NotFound();
            }

            return ecrossSections;
        }

        // PUT: api/EcrossSections/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcrossSections(long id, EcrossSections ecrossSections)
        {
            if (id != ecrossSections.EcrossSectionsId)
            {
                return BadRequest();
            }

            _context.Entry(ecrossSections).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcrossSectionsExists(id))
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

        // POST: api/EcrossSections
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EcrossSections>> PostEcrossSections(EcrossSections ecrossSections)
        {
            _context.EcrossSections.Add(ecrossSections);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcrossSectionsExists(ecrossSections.EcrossSectionsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcrossSections", new { id = ecrossSections.EcrossSectionsId }, ecrossSections);
        }

        // DELETE: api/EcrossSections/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EcrossSections>> DeleteEcrossSections(long id)
        {
            var ecrossSections = await _context.EcrossSections.FindAsync(id);
            if (ecrossSections == null)
            {
                return NotFound();
            }

            _context.EcrossSections.Remove(ecrossSections);
            await _context.SaveChangesAsync();

            return ecrossSections;
        }

        private bool EcrossSectionsExists(long id)
        {
            return _context.EcrossSections.Any(e => e.EcrossSectionsId == id);
        }
    }
}
