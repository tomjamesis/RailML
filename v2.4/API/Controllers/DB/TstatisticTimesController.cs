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
    public class TstatisticTimesController : ControllerBase
    {
        private readonly DBContext _context;

        public TstatisticTimesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstatisticTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstatisticTimes>>> GetTstatisticTimes()
        {
            return await _context.TstatisticTimes.ToListAsync();
        }

        // GET: api/TstatisticTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstatisticTimes>> GetTstatisticTimes(long id)
        {
            var tstatisticTimes = await _context.TstatisticTimes.FindAsync(id);

            if (tstatisticTimes == null)
            {
                return NotFound();
            }

            return tstatisticTimes;
        }

        // PUT: api/TstatisticTimes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstatisticTimes(long id, TstatisticTimes tstatisticTimes)
        {
            if (id != tstatisticTimes.TstatisticTimesId)
            {
                return BadRequest();
            }

            _context.Entry(tstatisticTimes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstatisticTimesExists(id))
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

        // POST: api/TstatisticTimes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstatisticTimes>> PostTstatisticTimes(TstatisticTimes tstatisticTimes)
        {
            _context.TstatisticTimes.Add(tstatisticTimes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstatisticTimesExists(tstatisticTimes.TstatisticTimesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstatisticTimes", new { id = tstatisticTimes.TstatisticTimesId }, tstatisticTimes);
        }

        // DELETE: api/TstatisticTimes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstatisticTimes>> DeleteTstatisticTimes(long id)
        {
            var tstatisticTimes = await _context.TstatisticTimes.FindAsync(id);
            if (tstatisticTimes == null)
            {
                return NotFound();
            }

            _context.TstatisticTimes.Remove(tstatisticTimes);
            await _context.SaveChangesAsync();

            return tstatisticTimes;
        }

        private bool TstatisticTimesExists(long id)
        {
            return _context.TstatisticTimes.Any(e => e.TstatisticTimesId == id);
        }
    }
}
