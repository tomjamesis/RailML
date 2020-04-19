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
    public class TrackTractionTypeController : ControllerBase
    {
        private readonly DBContext _context;

        public TrackTractionTypeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TrackTractionType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrackTractionType>>> GetTrackTractionType()
        {
            return await _context.TrackTractionType.ToListAsync();
        }

        // GET: api/TrackTractionType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrackTractionType>> GetTrackTractionType(long id)
        {
            var trackTractionType = await _context.TrackTractionType.FindAsync(id);

            if (trackTractionType == null)
            {
                return NotFound();
            }

            return trackTractionType;
        }

        // PUT: api/TrackTractionType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrackTractionType(long id, TrackTractionType trackTractionType)
        {
            if (id != trackTractionType.TrackTractionTypeId)
            {
                return BadRequest();
            }

            _context.Entry(trackTractionType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackTractionTypeExists(id))
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

        // POST: api/TrackTractionType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TrackTractionType>> PostTrackTractionType(TrackTractionType trackTractionType)
        {
            _context.TrackTractionType.Add(trackTractionType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrackTractionTypeExists(trackTractionType.TrackTractionTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrackTractionType", new { id = trackTractionType.TrackTractionTypeId }, trackTractionType);
        }

        // DELETE: api/TrackTractionType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TrackTractionType>> DeleteTrackTractionType(long id)
        {
            var trackTractionType = await _context.TrackTractionType.FindAsync(id);
            if (trackTractionType == null)
            {
                return NotFound();
            }

            _context.TrackTractionType.Remove(trackTractionType);
            await _context.SaveChangesAsync();

            return trackTractionType;
        }

        private bool TrackTractionTypeExists(long id)
        {
            return _context.TrackTractionType.Any(e => e.TrackTractionTypeId == id);
        }
    }
}
