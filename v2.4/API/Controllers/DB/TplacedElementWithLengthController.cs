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
    public class TplacedElementWithLengthController : ControllerBase
    {
        private readonly DBContext _context;

        public TplacedElementWithLengthController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TplacedElementWithLength
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TplacedElementWithLength>>> GetTplacedElementWithLength()
        {
            return await _context.TplacedElementWithLength.ToListAsync();
        }

        // GET: api/TplacedElementWithLength/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TplacedElementWithLength>> GetTplacedElementWithLength(short id)
        {
            var tplacedElementWithLength = await _context.TplacedElementWithLength.FindAsync(id);

            if (tplacedElementWithLength == null)
            {
                return NotFound();
            }

            return tplacedElementWithLength;
        }

        // PUT: api/TplacedElementWithLength/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTplacedElementWithLength(short id, TplacedElementWithLength tplacedElementWithLength)
        {
            if (id != tplacedElementWithLength.TplacedElementWithLengthId)
            {
                return BadRequest();
            }

            _context.Entry(tplacedElementWithLength).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TplacedElementWithLengthExists(id))
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

        // POST: api/TplacedElementWithLength
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TplacedElementWithLength>> PostTplacedElementWithLength(TplacedElementWithLength tplacedElementWithLength)
        {
            _context.TplacedElementWithLength.Add(tplacedElementWithLength);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TplacedElementWithLengthExists(tplacedElementWithLength.TplacedElementWithLengthId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTplacedElementWithLength", new { id = tplacedElementWithLength.TplacedElementWithLengthId }, tplacedElementWithLength);
        }

        // DELETE: api/TplacedElementWithLength/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TplacedElementWithLength>> DeleteTplacedElementWithLength(short id)
        {
            var tplacedElementWithLength = await _context.TplacedElementWithLength.FindAsync(id);
            if (tplacedElementWithLength == null)
            {
                return NotFound();
            }

            _context.TplacedElementWithLength.Remove(tplacedElementWithLength);
            await _context.SaveChangesAsync();

            return tplacedElementWithLength;
        }

        private bool TplacedElementWithLengthExists(short id)
        {
            return _context.TplacedElementWithLength.Any(e => e.TplacedElementWithLengthId == id);
        }
    }
}
