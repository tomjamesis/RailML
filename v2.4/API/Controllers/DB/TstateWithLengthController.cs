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
    public class TstateWithLengthController : ControllerBase
    {
        private readonly DBContext _context;

        public TstateWithLengthController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstateWithLength
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstateWithLength>>> GetTstateWithLength()
        {
            return await _context.TstateWithLength.ToListAsync();
        }

        // GET: api/TstateWithLength/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstateWithLength>> GetTstateWithLength(short id)
        {
            var tstateWithLength = await _context.TstateWithLength.FindAsync(id);

            if (tstateWithLength == null)
            {
                return NotFound();
            }

            return tstateWithLength;
        }

        // PUT: api/TstateWithLength/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstateWithLength(short id, TstateWithLength tstateWithLength)
        {
            if (id != tstateWithLength.TstateWithLengthId)
            {
                return BadRequest();
            }

            _context.Entry(tstateWithLength).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstateWithLengthExists(id))
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

        // POST: api/TstateWithLength
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstateWithLength>> PostTstateWithLength(TstateWithLength tstateWithLength)
        {
            _context.TstateWithLength.Add(tstateWithLength);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstateWithLengthExists(tstateWithLength.TstateWithLengthId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstateWithLength", new { id = tstateWithLength.TstateWithLengthId }, tstateWithLength);
        }

        // DELETE: api/TstateWithLength/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstateWithLength>> DeleteTstateWithLength(short id)
        {
            var tstateWithLength = await _context.TstateWithLength.FindAsync(id);
            if (tstateWithLength == null)
            {
                return NotFound();
            }

            _context.TstateWithLength.Remove(tstateWithLength);
            await _context.SaveChangesAsync();

            return tstateWithLength;
        }

        private bool TstateWithLengthExists(short id)
        {
            return _context.TstateWithLength.Any(e => e.TstateWithLengthId == id);
        }
    }
}
