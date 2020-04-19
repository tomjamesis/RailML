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
    public class TstatesWithLengthController : ControllerBase
    {
        private readonly DBContext _context;

        public TstatesWithLengthController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstatesWithLength
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstatesWithLength>>> GetTstatesWithLength()
        {
            return await _context.TstatesWithLength.ToListAsync();
        }

        // GET: api/TstatesWithLength/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstatesWithLength>> GetTstatesWithLength(long id)
        {
            var tstatesWithLength = await _context.TstatesWithLength.FindAsync(id);

            if (tstatesWithLength == null)
            {
                return NotFound();
            }

            return tstatesWithLength;
        }

        // PUT: api/TstatesWithLength/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstatesWithLength(long id, TstatesWithLength tstatesWithLength)
        {
            if (id != tstatesWithLength.TstatesWithLengthId)
            {
                return BadRequest();
            }

            _context.Entry(tstatesWithLength).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstatesWithLengthExists(id))
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

        // POST: api/TstatesWithLength
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstatesWithLength>> PostTstatesWithLength(TstatesWithLength tstatesWithLength)
        {
            _context.TstatesWithLength.Add(tstatesWithLength);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstatesWithLengthExists(tstatesWithLength.TstatesWithLengthId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstatesWithLength", new { id = tstatesWithLength.TstatesWithLengthId }, tstatesWithLength);
        }

        // DELETE: api/TstatesWithLength/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstatesWithLength>> DeleteTstatesWithLength(long id)
        {
            var tstatesWithLength = await _context.TstatesWithLength.FindAsync(id);
            if (tstatesWithLength == null)
            {
                return NotFound();
            }

            _context.TstatesWithLength.Remove(tstatesWithLength);
            await _context.SaveChangesAsync();

            return tstatesWithLength;
        }

        private bool TstatesWithLengthExists(long id)
        {
            return _context.TstatesWithLength.Any(e => e.TstatesWithLengthId == id);
        }
    }
}
