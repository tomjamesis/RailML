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
    public class TwagonController : ControllerBase
    {
        private readonly DBContext _context;

        public TwagonController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Twagon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Twagon>>> GetTwagon()
        {
            return await _context.Twagon.ToListAsync();
        }

        // GET: api/Twagon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Twagon>> GetTwagon(long id)
        {
            var twagon = await _context.Twagon.FindAsync(id);

            if (twagon == null)
            {
                return NotFound();
            }

            return twagon;
        }

        // PUT: api/Twagon/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTwagon(long id, Twagon twagon)
        {
            if (id != twagon.TwagonId)
            {
                return BadRequest();
            }

            _context.Entry(twagon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TwagonExists(id))
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

        // POST: api/Twagon
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Twagon>> PostTwagon(Twagon twagon)
        {
            _context.Twagon.Add(twagon);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TwagonExists(twagon.TwagonId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTwagon", new { id = twagon.TwagonId }, twagon);
        }

        // DELETE: api/Twagon/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Twagon>> DeleteTwagon(long id)
        {
            var twagon = await _context.Twagon.FindAsync(id);
            if (twagon == null)
            {
                return NotFound();
            }

            _context.Twagon.Remove(twagon);
            await _context.SaveChangesAsync();

            return twagon;
        }

        private bool TwagonExists(long id)
        {
            return _context.Twagon.Any(e => e.TwagonId == id);
        }
    }
}
