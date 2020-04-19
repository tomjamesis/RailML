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
    public class TtiltingController : ControllerBase
    {
        private readonly DBContext _context;

        public TtiltingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ttilting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ttilting>>> GetTtilting()
        {
            return await _context.Ttilting.ToListAsync();
        }

        // GET: api/Ttilting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ttilting>> GetTtilting(long id)
        {
            var ttilting = await _context.Ttilting.FindAsync(id);

            if (ttilting == null)
            {
                return NotFound();
            }

            return ttilting;
        }

        // PUT: api/Ttilting/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtilting(long id, Ttilting ttilting)
        {
            if (id != ttilting.TtiltingId)
            {
                return BadRequest();
            }

            _context.Entry(ttilting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtiltingExists(id))
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

        // POST: api/Ttilting
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ttilting>> PostTtilting(Ttilting ttilting)
        {
            _context.Ttilting.Add(ttilting);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtiltingExists(ttilting.TtiltingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtilting", new { id = ttilting.TtiltingId }, ttilting);
        }

        // DELETE: api/Ttilting/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ttilting>> DeleteTtilting(long id)
        {
            var ttilting = await _context.Ttilting.FindAsync(id);
            if (ttilting == null)
            {
                return NotFound();
            }

            _context.Ttilting.Remove(ttilting);
            await _context.SaveChangesAsync();

            return ttilting;
        }

        private bool TtiltingExists(long id)
        {
            return _context.Ttilting.Any(e => e.TtiltingId == id);
        }
    }
}
