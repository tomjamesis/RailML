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
    public class EspeedsController : ControllerBase
    {
        private readonly DBContext _context;

        public EspeedsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Espeeds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Espeeds>>> GetEspeeds()
        {
            return await _context.Espeeds.ToListAsync();
        }

        // GET: api/Espeeds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Espeeds>> GetEspeeds(long id)
        {
            var espeeds = await _context.Espeeds.FindAsync(id);

            if (espeeds == null)
            {
                return NotFound();
            }

            return espeeds;
        }

        // PUT: api/Espeeds/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspeeds(long id, Espeeds espeeds)
        {
            if (id != espeeds.EspeedsId)
            {
                return BadRequest();
            }

            _context.Entry(espeeds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspeedsExists(id))
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

        // POST: api/Espeeds
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Espeeds>> PostEspeeds(Espeeds espeeds)
        {
            _context.Espeeds.Add(espeeds);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EspeedsExists(espeeds.EspeedsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEspeeds", new { id = espeeds.EspeedsId }, espeeds);
        }

        // DELETE: api/Espeeds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Espeeds>> DeleteEspeeds(long id)
        {
            var espeeds = await _context.Espeeds.FindAsync(id);
            if (espeeds == null)
            {
                return NotFound();
            }

            _context.Espeeds.Remove(espeeds);
            await _context.SaveChangesAsync();

            return espeeds;
        }

        private bool EspeedsExists(long id)
        {
            return _context.Espeeds.Any(e => e.EspeedsId == id);
        }
    }
}
