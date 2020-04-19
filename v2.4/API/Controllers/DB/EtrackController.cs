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
    public class EtrackController : ControllerBase
    {
        private readonly DBContext _context;

        public EtrackController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Etrack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Etrack>>> GetEtrack()
        {
            return await _context.Etrack.ToListAsync();
        }

        // GET: api/Etrack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Etrack>> GetEtrack(short id)
        {
            var etrack = await _context.Etrack.FindAsync(id);

            if (etrack == null)
            {
                return NotFound();
            }

            return etrack;
        }

        // PUT: api/Etrack/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtrack(short id, Etrack etrack)
        {
            if (id != etrack.EtrackId)
            {
                return BadRequest();
            }

            _context.Entry(etrack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtrackExists(id))
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

        // POST: api/Etrack
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Etrack>> PostEtrack(Etrack etrack)
        {
            _context.Etrack.Add(etrack);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtrackExists(etrack.EtrackId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtrack", new { id = etrack.EtrackId }, etrack);
        }

        // DELETE: api/Etrack/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Etrack>> DeleteEtrack(short id)
        {
            var etrack = await _context.Etrack.FindAsync(id);
            if (etrack == null)
            {
                return NotFound();
            }

            _context.Etrack.Remove(etrack);
            await _context.SaveChangesAsync();

            return etrack;
        }

        private bool EtrackExists(short id)
        {
            return _context.Etrack.Any(e => e.EtrackId == id);
        }
    }
}
