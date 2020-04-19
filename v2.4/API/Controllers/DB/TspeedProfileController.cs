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
    public class TspeedProfileController : ControllerBase
    {
        private readonly DBContext _context;

        public TspeedProfileController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TspeedProfile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TspeedProfile>>> GetTspeedProfile()
        {
            return await _context.TspeedProfile.ToListAsync();
        }

        // GET: api/TspeedProfile/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TspeedProfile>> GetTspeedProfile(short id)
        {
            var tspeedProfile = await _context.TspeedProfile.FindAsync(id);

            if (tspeedProfile == null)
            {
                return NotFound();
            }

            return tspeedProfile;
        }

        // PUT: api/TspeedProfile/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTspeedProfile(short id, TspeedProfile tspeedProfile)
        {
            if (id != tspeedProfile.TspeedProfileId)
            {
                return BadRequest();
            }

            _context.Entry(tspeedProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TspeedProfileExists(id))
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

        // POST: api/TspeedProfile
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TspeedProfile>> PostTspeedProfile(TspeedProfile tspeedProfile)
        {
            _context.TspeedProfile.Add(tspeedProfile);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TspeedProfileExists(tspeedProfile.TspeedProfileId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTspeedProfile", new { id = tspeedProfile.TspeedProfileId }, tspeedProfile);
        }

        // DELETE: api/TspeedProfile/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TspeedProfile>> DeleteTspeedProfile(short id)
        {
            var tspeedProfile = await _context.TspeedProfile.FindAsync(id);
            if (tspeedProfile == null)
            {
                return NotFound();
            }

            _context.TspeedProfile.Remove(tspeedProfile);
            await _context.SaveChangesAsync();

            return tspeedProfile;
        }

        private bool TspeedProfileExists(short id)
        {
            return _context.TspeedProfile.Any(e => e.TspeedProfileId == id);
        }
    }
}
