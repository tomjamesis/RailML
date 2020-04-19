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
    public class TtrackController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrackController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ttrack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ttrack>>> GetTtrack()
        {
            return await _context.Ttrack.ToListAsync();
        }

        // GET: api/Ttrack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ttrack>> GetTtrack(short id)
        {
            var ttrack = await _context.Ttrack.FindAsync(id);

            if (ttrack == null)
            {
                return NotFound();
            }

            return ttrack;
        }

        // PUT: api/Ttrack/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrack(short id, Ttrack ttrack)
        {
            if (id != ttrack.TtrackId)
            {
                return BadRequest();
            }

            _context.Entry(ttrack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrackExists(id))
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

        // POST: api/Ttrack
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ttrack>> PostTtrack(Ttrack ttrack)
        {
            _context.Ttrack.Add(ttrack);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrackExists(ttrack.TtrackId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrack", new { id = ttrack.TtrackId }, ttrack);
        }

        // DELETE: api/Ttrack/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ttrack>> DeleteTtrack(short id)
        {
            var ttrack = await _context.Ttrack.FindAsync(id);
            if (ttrack == null)
            {
                return NotFound();
            }

            _context.Ttrack.Remove(ttrack);
            await _context.SaveChangesAsync();

            return ttrack;
        }

        private bool TtrackExists(short id)
        {
            return _context.Ttrack.Any(e => e.TtrackId == id);
        }
    }
}
