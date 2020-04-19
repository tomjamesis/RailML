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
    public class TstopTimesController : ControllerBase
    {
        private readonly DBContext _context;

        public TstopTimesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstopTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstopTimes>>> GetTstopTimes()
        {
            return await _context.TstopTimes.ToListAsync();
        }

        // GET: api/TstopTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstopTimes>> GetTstopTimes(long id)
        {
            var tstopTimes = await _context.TstopTimes.FindAsync(id);

            if (tstopTimes == null)
            {
                return NotFound();
            }

            return tstopTimes;
        }

        // PUT: api/TstopTimes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstopTimes(long id, TstopTimes tstopTimes)
        {
            if (id != tstopTimes.TstopTimesId)
            {
                return BadRequest();
            }

            _context.Entry(tstopTimes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstopTimesExists(id))
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

        // POST: api/TstopTimes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstopTimes>> PostTstopTimes(TstopTimes tstopTimes)
        {
            _context.TstopTimes.Add(tstopTimes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstopTimesExists(tstopTimes.TstopTimesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstopTimes", new { id = tstopTimes.TstopTimesId }, tstopTimes);
        }

        // DELETE: api/TstopTimes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstopTimes>> DeleteTstopTimes(long id)
        {
            var tstopTimes = await _context.TstopTimes.FindAsync(id);
            if (tstopTimes == null)
            {
                return NotFound();
            }

            _context.TstopTimes.Remove(tstopTimes);
            await _context.SaveChangesAsync();

            return tstopTimes;
        }

        private bool TstopTimesExists(long id)
        {
            return _context.TstopTimes.Any(e => e.TstopTimesId == id);
        }
    }
}
