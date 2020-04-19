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
    public class TrunTimesController : ControllerBase
    {
        private readonly DBContext _context;

        public TrunTimesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TrunTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrunTimes>>> GetTrunTimes()
        {
            return await _context.TrunTimes.ToListAsync();
        }

        // GET: api/TrunTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrunTimes>> GetTrunTimes(long id)
        {
            var trunTimes = await _context.TrunTimes.FindAsync(id);

            if (trunTimes == null)
            {
                return NotFound();
            }

            return trunTimes;
        }

        // PUT: api/TrunTimes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrunTimes(long id, TrunTimes trunTimes)
        {
            if (id != trunTimes.TrunTimesId)
            {
                return BadRequest();
            }

            _context.Entry(trunTimes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrunTimesExists(id))
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

        // POST: api/TrunTimes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrunTimes>> PostTrunTimes(TrunTimes trunTimes)
        {
            _context.TrunTimes.Add(trunTimes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrunTimesExists(trunTimes.TrunTimesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrunTimes", new { id = trunTimes.TrunTimesId }, trunTimes);
        }

        // DELETE: api/TrunTimes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrunTimes>> DeleteTrunTimes(long id)
        {
            var trunTimes = await _context.TrunTimes.FindAsync(id);
            if (trunTimes == null)
            {
                return NotFound();
            }

            _context.TrunTimes.Remove(trunTimes);
            await _context.SaveChangesAsync();

            return trunTimes;
        }

        private bool TrunTimesExists(long id)
        {
            return _context.TrunTimes.Any(e => e.TrunTimesId == id);
        }
    }
}
