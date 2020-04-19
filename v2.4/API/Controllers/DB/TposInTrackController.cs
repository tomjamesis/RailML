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
    public class TposInTrackController : ControllerBase
    {
        private readonly DBContext _context;

        public TposInTrackController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TposInTrack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TposInTrack>>> GetTposInTrack()
        {
            return await _context.TposInTrack.ToListAsync();
        }

        // GET: api/TposInTrack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TposInTrack>> GetTposInTrack(byte id)
        {
            var tposInTrack = await _context.TposInTrack.FindAsync(id);

            if (tposInTrack == null)
            {
                return NotFound();
            }

            return tposInTrack;
        }

        // PUT: api/TposInTrack/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTposInTrack(byte id, TposInTrack tposInTrack)
        {
            if (id != tposInTrack.TposInTrackId)
            {
                return BadRequest();
            }

            _context.Entry(tposInTrack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TposInTrackExists(id))
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

        // POST: api/TposInTrack
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TposInTrack>> PostTposInTrack(TposInTrack tposInTrack)
        {
            _context.TposInTrack.Add(tposInTrack);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TposInTrackExists(tposInTrack.TposInTrackId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTposInTrack", new { id = tposInTrack.TposInTrackId }, tposInTrack);
        }

        // DELETE: api/TposInTrack/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TposInTrack>> DeleteTposInTrack(byte id)
        {
            var tposInTrack = await _context.TposInTrack.FindAsync(id);
            if (tposInTrack == null)
            {
                return NotFound();
            }

            _context.TposInTrack.Remove(tposInTrack);
            await _context.SaveChangesAsync();

            return tposInTrack;
        }

        private bool TposInTrackExists(byte id)
        {
            return _context.TposInTrack.Any(e => e.TposInTrackId == id);
        }
    }
}
