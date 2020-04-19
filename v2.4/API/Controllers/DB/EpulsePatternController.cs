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
    public class EpulsePatternController : ControllerBase
    {
        private readonly DBContext _context;

        public EpulsePatternController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EpulsePattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EpulsePattern>>> GetEpulsePattern()
        {
            return await _context.EpulsePattern.ToListAsync();
        }

        // GET: api/EpulsePattern/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EpulsePattern>> GetEpulsePattern(long id)
        {
            var epulsePattern = await _context.EpulsePattern.FindAsync(id);

            if (epulsePattern == null)
            {
                return NotFound();
            }

            return epulsePattern;
        }

        // PUT: api/EpulsePattern/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpulsePattern(long id, EpulsePattern epulsePattern)
        {
            if (id != epulsePattern.EpulsePatternId)
            {
                return BadRequest();
            }

            _context.Entry(epulsePattern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpulsePatternExists(id))
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

        // POST: api/EpulsePattern
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EpulsePattern>> PostEpulsePattern(EpulsePattern epulsePattern)
        {
            _context.EpulsePattern.Add(epulsePattern);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EpulsePatternExists(epulsePattern.EpulsePatternId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEpulsePattern", new { id = epulsePattern.EpulsePatternId }, epulsePattern);
        }

        // DELETE: api/EpulsePattern/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EpulsePattern>> DeleteEpulsePattern(long id)
        {
            var epulsePattern = await _context.EpulsePattern.FindAsync(id);
            if (epulsePattern == null)
            {
                return NotFound();
            }

            _context.EpulsePattern.Remove(epulsePattern);
            await _context.SaveChangesAsync();

            return epulsePattern;
        }

        private bool EpulsePatternExists(long id)
        {
            return _context.EpulsePattern.Any(e => e.EpulsePatternId == id);
        }
    }
}
