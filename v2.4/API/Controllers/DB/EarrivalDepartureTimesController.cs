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
    public class EarrivalDepartureTimesController : ControllerBase
    {
        private readonly DBContext _context;

        public EarrivalDepartureTimesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EarrivalDepartureTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EarrivalDepartureTimes>>> GetEarrivalDepartureTimes()
        {
            return await _context.EarrivalDepartureTimes.ToListAsync();
        }

        // GET: api/EarrivalDepartureTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EarrivalDepartureTimes>> GetEarrivalDepartureTimes(short id)
        {
            var earrivalDepartureTimes = await _context.EarrivalDepartureTimes.FindAsync(id);

            if (earrivalDepartureTimes == null)
            {
                return NotFound();
            }

            return earrivalDepartureTimes;
        }

        // PUT: api/EarrivalDepartureTimes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEarrivalDepartureTimes(short id, EarrivalDepartureTimes earrivalDepartureTimes)
        {
            if (id != earrivalDepartureTimes.EarrivalDepartureTimesId)
            {
                return BadRequest();
            }

            _context.Entry(earrivalDepartureTimes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EarrivalDepartureTimesExists(id))
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

        // POST: api/EarrivalDepartureTimes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EarrivalDepartureTimes>> PostEarrivalDepartureTimes(EarrivalDepartureTimes earrivalDepartureTimes)
        {
            _context.EarrivalDepartureTimes.Add(earrivalDepartureTimes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EarrivalDepartureTimesExists(earrivalDepartureTimes.EarrivalDepartureTimesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEarrivalDepartureTimes", new { id = earrivalDepartureTimes.EarrivalDepartureTimesId }, earrivalDepartureTimes);
        }

        // DELETE: api/EarrivalDepartureTimes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EarrivalDepartureTimes>> DeleteEarrivalDepartureTimes(short id)
        {
            var earrivalDepartureTimes = await _context.EarrivalDepartureTimes.FindAsync(id);
            if (earrivalDepartureTimes == null)
            {
                return NotFound();
            }

            _context.EarrivalDepartureTimes.Remove(earrivalDepartureTimes);
            await _context.SaveChangesAsync();

            return earrivalDepartureTimes;
        }

        private bool EarrivalDepartureTimesExists(short id)
        {
            return _context.EarrivalDepartureTimes.Any(e => e.EarrivalDepartureTimesId == id);
        }
    }
}
