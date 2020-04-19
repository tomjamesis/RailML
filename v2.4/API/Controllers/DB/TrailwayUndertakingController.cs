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
    public class TrailwayUndertakingController : ControllerBase
    {
        private readonly DBContext _context;

        public TrailwayUndertakingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TrailwayUndertaking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrailwayUndertaking>>> GetTrailwayUndertaking()
        {
            return await _context.TrailwayUndertaking.ToListAsync();
        }

        // GET: api/TrailwayUndertaking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrailwayUndertaking>> GetTrailwayUndertaking(short id)
        {
            var trailwayUndertaking = await _context.TrailwayUndertaking.FindAsync(id);

            if (trailwayUndertaking == null)
            {
                return NotFound();
            }

            return trailwayUndertaking;
        }

        // PUT: api/TrailwayUndertaking/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrailwayUndertaking(short id, TrailwayUndertaking trailwayUndertaking)
        {
            if (id != trailwayUndertaking.TrailwayUndertakingId)
            {
                return BadRequest();
            }

            _context.Entry(trailwayUndertaking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrailwayUndertakingExists(id))
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

        // POST: api/TrailwayUndertaking
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrailwayUndertaking>> PostTrailwayUndertaking(TrailwayUndertaking trailwayUndertaking)
        {
            _context.TrailwayUndertaking.Add(trailwayUndertaking);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrailwayUndertakingExists(trailwayUndertaking.TrailwayUndertakingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrailwayUndertaking", new { id = trailwayUndertaking.TrailwayUndertakingId }, trailwayUndertaking);
        }

        // DELETE: api/TrailwayUndertaking/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrailwayUndertaking>> DeleteTrailwayUndertaking(short id)
        {
            var trailwayUndertaking = await _context.TrailwayUndertaking.FindAsync(id);
            if (trailwayUndertaking == null)
            {
                return NotFound();
            }

            _context.TrailwayUndertaking.Remove(trailwayUndertaking);
            await _context.SaveChangesAsync();

            return trailwayUndertaking;
        }

        private bool TrailwayUndertakingExists(short id)
        {
            return _context.TrailwayUndertaking.Any(e => e.TrailwayUndertakingId == id);
        }
    }
}
