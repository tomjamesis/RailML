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
    public class TdelimitedOrientedElementWithLengthController : ControllerBase
    {
        private readonly DBContext _context;

        public TdelimitedOrientedElementWithLengthController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TdelimitedOrientedElementWithLength
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdelimitedOrientedElementWithLength>>> GetTdelimitedOrientedElementWithLength()
        {
            return await _context.TdelimitedOrientedElementWithLength.ToListAsync();
        }

        // GET: api/TdelimitedOrientedElementWithLength/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TdelimitedOrientedElementWithLength>> GetTdelimitedOrientedElementWithLength(short id)
        {
            var tdelimitedOrientedElementWithLength = await _context.TdelimitedOrientedElementWithLength.FindAsync(id);

            if (tdelimitedOrientedElementWithLength == null)
            {
                return NotFound();
            }

            return tdelimitedOrientedElementWithLength;
        }

        // PUT: api/TdelimitedOrientedElementWithLength/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdelimitedOrientedElementWithLength(short id, TdelimitedOrientedElementWithLength tdelimitedOrientedElementWithLength)
        {
            if (id != tdelimitedOrientedElementWithLength.TdelimitedOrientedElementWithLengthId)
            {
                return BadRequest();
            }

            _context.Entry(tdelimitedOrientedElementWithLength).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdelimitedOrientedElementWithLengthExists(id))
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

        // POST: api/TdelimitedOrientedElementWithLength
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TdelimitedOrientedElementWithLength>> PostTdelimitedOrientedElementWithLength(TdelimitedOrientedElementWithLength tdelimitedOrientedElementWithLength)
        {
            _context.TdelimitedOrientedElementWithLength.Add(tdelimitedOrientedElementWithLength);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TdelimitedOrientedElementWithLengthExists(tdelimitedOrientedElementWithLength.TdelimitedOrientedElementWithLengthId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTdelimitedOrientedElementWithLength", new { id = tdelimitedOrientedElementWithLength.TdelimitedOrientedElementWithLengthId }, tdelimitedOrientedElementWithLength);
        }

        // DELETE: api/TdelimitedOrientedElementWithLength/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TdelimitedOrientedElementWithLength>> DeleteTdelimitedOrientedElementWithLength(short id)
        {
            var tdelimitedOrientedElementWithLength = await _context.TdelimitedOrientedElementWithLength.FindAsync(id);
            if (tdelimitedOrientedElementWithLength == null)
            {
                return NotFound();
            }

            _context.TdelimitedOrientedElementWithLength.Remove(tdelimitedOrientedElementWithLength);
            await _context.SaveChangesAsync();

            return tdelimitedOrientedElementWithLength;
        }

        private bool TdelimitedOrientedElementWithLengthExists(short id)
        {
            return _context.TdelimitedOrientedElementWithLength.Any(e => e.TdelimitedOrientedElementWithLengthId == id);
        }
    }
}
