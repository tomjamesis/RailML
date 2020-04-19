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
    public class ToperatingPeriodController : ControllerBase
    {
        private readonly DBContext _context;

        public ToperatingPeriodController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ToperatingPeriod
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToperatingPeriod>>> GetToperatingPeriod()
        {
            return await _context.ToperatingPeriod.ToListAsync();
        }

        // GET: api/ToperatingPeriod/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToperatingPeriod>> GetToperatingPeriod(short id)
        {
            var toperatingPeriod = await _context.ToperatingPeriod.FindAsync(id);

            if (toperatingPeriod == null)
            {
                return NotFound();
            }

            return toperatingPeriod;
        }

        // PUT: api/ToperatingPeriod/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToperatingPeriod(short id, ToperatingPeriod toperatingPeriod)
        {
            if (id != toperatingPeriod.ToperatingPeriodId)
            {
                return BadRequest();
            }

            _context.Entry(toperatingPeriod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToperatingPeriodExists(id))
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

        // POST: api/ToperatingPeriod
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToperatingPeriod>> PostToperatingPeriod(ToperatingPeriod toperatingPeriod)
        {
            _context.ToperatingPeriod.Add(toperatingPeriod);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToperatingPeriodExists(toperatingPeriod.ToperatingPeriodId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetToperatingPeriod", new { id = toperatingPeriod.ToperatingPeriodId }, toperatingPeriod);
        }

        // DELETE: api/ToperatingPeriod/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToperatingPeriod>> DeleteToperatingPeriod(short id)
        {
            var toperatingPeriod = await _context.ToperatingPeriod.FindAsync(id);
            if (toperatingPeriod == null)
            {
                return NotFound();
            }

            _context.ToperatingPeriod.Remove(toperatingPeriod);
            await _context.SaveChangesAsync();

            return toperatingPeriod;
        }

        private bool ToperatingPeriodExists(short id)
        {
            return _context.ToperatingPeriod.Any(e => e.ToperatingPeriodId == id);
        }
    }
}
