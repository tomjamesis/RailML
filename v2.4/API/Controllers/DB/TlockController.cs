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
    public class TlockController : ControllerBase
    {
        private readonly DBContext _context;

        public TlockController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tlock
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tlock>>> GetTlock()
        {
            return await _context.Tlock.ToListAsync();
        }

        // GET: api/Tlock/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tlock>> GetTlock(short id)
        {
            var tlock = await _context.Tlock.FindAsync(id);

            if (tlock == null)
            {
                return NotFound();
            }

            return tlock;
        }

        // PUT: api/Tlock/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTlock(short id, Tlock tlock)
        {
            if (id != tlock.TlockId)
            {
                return BadRequest();
            }

            _context.Entry(tlock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlockExists(id))
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

        // POST: api/Tlock
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tlock>> PostTlock(Tlock tlock)
        {
            _context.Tlock.Add(tlock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlockExists(tlock.TlockId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTlock", new { id = tlock.TlockId }, tlock);
        }

        // DELETE: api/Tlock/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tlock>> DeleteTlock(short id)
        {
            var tlock = await _context.Tlock.FindAsync(id);
            if (tlock == null)
            {
                return NotFound();
            }

            _context.Tlock.Remove(tlock);
            await _context.SaveChangesAsync();

            return tlock;
        }

        private bool TlockExists(short id)
        {
            return _context.Tlock.Any(e => e.TlockId == id);
        }
    }
}
