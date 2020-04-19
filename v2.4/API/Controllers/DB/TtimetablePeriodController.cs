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
    public class TtimetablePeriodController : ControllerBase
    {
        private readonly DBContext _context;

        public TtimetablePeriodController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtimetablePeriod
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtimetablePeriod>>> GetTtimetablePeriod()
        {
            return await _context.TtimetablePeriod.ToListAsync();
        }

        // GET: api/TtimetablePeriod/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtimetablePeriod>> GetTtimetablePeriod(short id)
        {
            var ttimetablePeriod = await _context.TtimetablePeriod.FindAsync(id);

            if (ttimetablePeriod == null)
            {
                return NotFound();
            }

            return ttimetablePeriod;
        }

        // PUT: api/TtimetablePeriod/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtimetablePeriod(short id, TtimetablePeriod ttimetablePeriod)
        {
            if (id != ttimetablePeriod.TtimetablePeriodId)
            {
                return BadRequest();
            }

            _context.Entry(ttimetablePeriod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtimetablePeriodExists(id))
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

        // POST: api/TtimetablePeriod
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtimetablePeriod>> PostTtimetablePeriod(TtimetablePeriod ttimetablePeriod)
        {
            _context.TtimetablePeriod.Add(ttimetablePeriod);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtimetablePeriodExists(ttimetablePeriod.TtimetablePeriodId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtimetablePeriod", new { id = ttimetablePeriod.TtimetablePeriodId }, ttimetablePeriod);
        }

        // DELETE: api/TtimetablePeriod/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtimetablePeriod>> DeleteTtimetablePeriod(short id)
        {
            var ttimetablePeriod = await _context.TtimetablePeriod.FindAsync(id);
            if (ttimetablePeriod == null)
            {
                return NotFound();
            }

            _context.TtimetablePeriod.Remove(ttimetablePeriod);
            await _context.SaveChangesAsync();

            return ttimetablePeriod;
        }

        private bool TtimetablePeriodExists(short id)
        {
            return _context.TtimetablePeriod.Any(e => e.TtimetablePeriodId == id);
        }
    }
}
