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
    public class ToperationalUndertakingController : ControllerBase
    {
        private readonly DBContext _context;

        public ToperationalUndertakingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ToperationalUndertaking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToperationalUndertaking>>> GetToperationalUndertaking()
        {
            return await _context.ToperationalUndertaking.ToListAsync();
        }

        // GET: api/ToperationalUndertaking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToperationalUndertaking>> GetToperationalUndertaking(short id)
        {
            var toperationalUndertaking = await _context.ToperationalUndertaking.FindAsync(id);

            if (toperationalUndertaking == null)
            {
                return NotFound();
            }

            return toperationalUndertaking;
        }

        // PUT: api/ToperationalUndertaking/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToperationalUndertaking(short id, ToperationalUndertaking toperationalUndertaking)
        {
            if (id != toperationalUndertaking.ToperationalUndertakingId)
            {
                return BadRequest();
            }

            _context.Entry(toperationalUndertaking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToperationalUndertakingExists(id))
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

        // POST: api/ToperationalUndertaking
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToperationalUndertaking>> PostToperationalUndertaking(ToperationalUndertaking toperationalUndertaking)
        {
            _context.ToperationalUndertaking.Add(toperationalUndertaking);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToperationalUndertakingExists(toperationalUndertaking.ToperationalUndertakingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetToperationalUndertaking", new { id = toperationalUndertaking.ToperationalUndertakingId }, toperationalUndertaking);
        }

        // DELETE: api/ToperationalUndertaking/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToperationalUndertaking>> DeleteToperationalUndertaking(short id)
        {
            var toperationalUndertaking = await _context.ToperationalUndertaking.FindAsync(id);
            if (toperationalUndertaking == null)
            {
                return NotFound();
            }

            _context.ToperationalUndertaking.Remove(toperationalUndertaking);
            await _context.SaveChangesAsync();

            return toperationalUndertaking;
        }

        private bool ToperationalUndertakingExists(short id)
        {
            return _context.ToperationalUndertaking.Any(e => e.ToperationalUndertakingId == id);
        }
    }
}
