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
    public class TstrictOrientedElementWithLengthController : ControllerBase
    {
        private readonly DBContext _context;

        public TstrictOrientedElementWithLengthController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstrictOrientedElementWithLength
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstrictOrientedElementWithLength>>> GetTstrictOrientedElementWithLength()
        {
            return await _context.TstrictOrientedElementWithLength.ToListAsync();
        }

        // GET: api/TstrictOrientedElementWithLength/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstrictOrientedElementWithLength>> GetTstrictOrientedElementWithLength(short id)
        {
            var tstrictOrientedElementWithLength = await _context.TstrictOrientedElementWithLength.FindAsync(id);

            if (tstrictOrientedElementWithLength == null)
            {
                return NotFound();
            }

            return tstrictOrientedElementWithLength;
        }

        // PUT: api/TstrictOrientedElementWithLength/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstrictOrientedElementWithLength(short id, TstrictOrientedElementWithLength tstrictOrientedElementWithLength)
        {
            if (id != tstrictOrientedElementWithLength.TstrictOrientedElementWithLengthId)
            {
                return BadRequest();
            }

            _context.Entry(tstrictOrientedElementWithLength).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstrictOrientedElementWithLengthExists(id))
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

        // POST: api/TstrictOrientedElementWithLength
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstrictOrientedElementWithLength>> PostTstrictOrientedElementWithLength(TstrictOrientedElementWithLength tstrictOrientedElementWithLength)
        {
            _context.TstrictOrientedElementWithLength.Add(tstrictOrientedElementWithLength);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstrictOrientedElementWithLengthExists(tstrictOrientedElementWithLength.TstrictOrientedElementWithLengthId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstrictOrientedElementWithLength", new { id = tstrictOrientedElementWithLength.TstrictOrientedElementWithLengthId }, tstrictOrientedElementWithLength);
        }

        // DELETE: api/TstrictOrientedElementWithLength/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstrictOrientedElementWithLength>> DeleteTstrictOrientedElementWithLength(short id)
        {
            var tstrictOrientedElementWithLength = await _context.TstrictOrientedElementWithLength.FindAsync(id);
            if (tstrictOrientedElementWithLength == null)
            {
                return NotFound();
            }

            _context.TstrictOrientedElementWithLength.Remove(tstrictOrientedElementWithLength);
            await _context.SaveChangesAsync();

            return tstrictOrientedElementWithLength;
        }

        private bool TstrictOrientedElementWithLengthExists(short id)
        {
            return _context.TstrictOrientedElementWithLength.Any(e => e.TstrictOrientedElementWithLengthId == id);
        }
    }
}
