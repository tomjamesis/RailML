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
    public class TarrivalDepartureTimesController : ControllerBase
    {
        private readonly DBContext _context;

        public TarrivalDepartureTimesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TarrivalDepartureTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TarrivalDepartureTimes>>> GetTarrivalDepartureTimes()
        {
            return await _context.TarrivalDepartureTimes.ToListAsync();
        }

        // GET: api/TarrivalDepartureTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TarrivalDepartureTimes>> GetTarrivalDepartureTimes(long id)
        {
            var tarrivalDepartureTimes = await _context.TarrivalDepartureTimes.FindAsync(id);

            if (tarrivalDepartureTimes == null)
            {
                return NotFound();
            }

            return tarrivalDepartureTimes;
        }

        // PUT: api/TarrivalDepartureTimes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarrivalDepartureTimes(long id, TarrivalDepartureTimes tarrivalDepartureTimes)
        {
            if (id != tarrivalDepartureTimes.TarrivalDepartureTimesId)
            {
                return BadRequest();
            }

            _context.Entry(tarrivalDepartureTimes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarrivalDepartureTimesExists(id))
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

        // POST: api/TarrivalDepartureTimes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TarrivalDepartureTimes>> PostTarrivalDepartureTimes(TarrivalDepartureTimes tarrivalDepartureTimes)
        {
            _context.TarrivalDepartureTimes.Add(tarrivalDepartureTimes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TarrivalDepartureTimesExists(tarrivalDepartureTimes.TarrivalDepartureTimesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTarrivalDepartureTimes", new { id = tarrivalDepartureTimes.TarrivalDepartureTimesId }, tarrivalDepartureTimes);
        }

        // DELETE: api/TarrivalDepartureTimes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TarrivalDepartureTimes>> DeleteTarrivalDepartureTimes(long id)
        {
            var tarrivalDepartureTimes = await _context.TarrivalDepartureTimes.FindAsync(id);
            if (tarrivalDepartureTimes == null)
            {
                return NotFound();
            }

            _context.TarrivalDepartureTimes.Remove(tarrivalDepartureTimes);
            await _context.SaveChangesAsync();

            return tarrivalDepartureTimes;
        }

        private bool TarrivalDepartureTimesExists(long id)
        {
            return _context.TarrivalDepartureTimes.Any(e => e.TarrivalDepartureTimesId == id);
        }
    }
}
