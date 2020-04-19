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
    public class TstandardDeviationTimesController : ControllerBase
    {
        private readonly DBContext _context;

        public TstandardDeviationTimesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstandardDeviationTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstandardDeviationTimes>>> GetTstandardDeviationTimes()
        {
            return await _context.TstandardDeviationTimes.ToListAsync();
        }

        // GET: api/TstandardDeviationTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstandardDeviationTimes>> GetTstandardDeviationTimes(long id)
        {
            var tstandardDeviationTimes = await _context.TstandardDeviationTimes.FindAsync(id);

            if (tstandardDeviationTimes == null)
            {
                return NotFound();
            }

            return tstandardDeviationTimes;
        }

        // PUT: api/TstandardDeviationTimes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstandardDeviationTimes(long id, TstandardDeviationTimes tstandardDeviationTimes)
        {
            if (id != tstandardDeviationTimes.TstandardDeviationTimesId)
            {
                return BadRequest();
            }

            _context.Entry(tstandardDeviationTimes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstandardDeviationTimesExists(id))
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

        // POST: api/TstandardDeviationTimes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstandardDeviationTimes>> PostTstandardDeviationTimes(TstandardDeviationTimes tstandardDeviationTimes)
        {
            _context.TstandardDeviationTimes.Add(tstandardDeviationTimes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstandardDeviationTimesExists(tstandardDeviationTimes.TstandardDeviationTimesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstandardDeviationTimes", new { id = tstandardDeviationTimes.TstandardDeviationTimesId }, tstandardDeviationTimes);
        }

        // DELETE: api/TstandardDeviationTimes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstandardDeviationTimes>> DeleteTstandardDeviationTimes(long id)
        {
            var tstandardDeviationTimes = await _context.TstandardDeviationTimes.FindAsync(id);
            if (tstandardDeviationTimes == null)
            {
                return NotFound();
            }

            _context.TstandardDeviationTimes.Remove(tstandardDeviationTimes);
            await _context.SaveChangesAsync();

            return tstandardDeviationTimes;
        }

        private bool TstandardDeviationTimesExists(long id)
        {
            return _context.TstandardDeviationTimes.Any(e => e.TstandardDeviationTimesId == id);
        }
    }
}
