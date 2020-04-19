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
    public class TwindingController : ControllerBase
    {
        private readonly DBContext _context;

        public TwindingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Twinding
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Twinding>>> GetTwinding()
        {
            return await _context.Twinding.ToListAsync();
        }

        // GET: api/Twinding/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Twinding>> GetTwinding(long id)
        {
            var twinding = await _context.Twinding.FindAsync(id);

            if (twinding == null)
            {
                return NotFound();
            }

            return twinding;
        }

        // PUT: api/Twinding/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTwinding(long id, Twinding twinding)
        {
            if (id != twinding.TwindingId)
            {
                return BadRequest();
            }

            _context.Entry(twinding).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TwindingExists(id))
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

        // POST: api/Twinding
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Twinding>> PostTwinding(Twinding twinding)
        {
            _context.Twinding.Add(twinding);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TwindingExists(twinding.TwindingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTwinding", new { id = twinding.TwindingId }, twinding);
        }

        // DELETE: api/Twinding/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Twinding>> DeleteTwinding(long id)
        {
            var twinding = await _context.Twinding.FindAsync(id);
            if (twinding == null)
            {
                return NotFound();
            }

            _context.Twinding.Remove(twinding);
            await _context.SaveChangesAsync();

            return twinding;
        }

        private bool TwindingExists(long id)
        {
            return _context.Twinding.Any(e => e.TwindingId == id);
        }
    }
}
