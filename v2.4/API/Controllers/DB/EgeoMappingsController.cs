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
    public class EgeoMappingsController : ControllerBase
    {
        private readonly DBContext _context;

        public EgeoMappingsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EgeoMappings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EgeoMappings>>> GetEgeoMappings()
        {
            return await _context.EgeoMappings.ToListAsync();
        }

        // GET: api/EgeoMappings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EgeoMappings>> GetEgeoMappings(long id)
        {
            var egeoMappings = await _context.EgeoMappings.FindAsync(id);

            if (egeoMappings == null)
            {
                return NotFound();
            }

            return egeoMappings;
        }

        // PUT: api/EgeoMappings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEgeoMappings(long id, EgeoMappings egeoMappings)
        {
            if (id != egeoMappings.EgeoMappingsId)
            {
                return BadRequest();
            }

            _context.Entry(egeoMappings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EgeoMappingsExists(id))
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

        // POST: api/EgeoMappings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EgeoMappings>> PostEgeoMappings(EgeoMappings egeoMappings)
        {
            _context.EgeoMappings.Add(egeoMappings);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EgeoMappingsExists(egeoMappings.EgeoMappingsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEgeoMappings", new { id = egeoMappings.EgeoMappingsId }, egeoMappings);
        }

        // DELETE: api/EgeoMappings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EgeoMappings>> DeleteEgeoMappings(long id)
        {
            var egeoMappings = await _context.EgeoMappings.FindAsync(id);
            if (egeoMappings == null)
            {
                return NotFound();
            }

            _context.EgeoMappings.Remove(egeoMappings);
            await _context.SaveChangesAsync();

            return egeoMappings;
        }

        private bool EgeoMappingsExists(long id)
        {
            return _context.EgeoMappings.Any(e => e.EgeoMappingsId == id);
        }
    }
}
