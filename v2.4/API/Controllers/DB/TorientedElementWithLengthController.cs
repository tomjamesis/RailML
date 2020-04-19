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
    public class TorientedElementWithLengthController : ControllerBase
    {
        private readonly DBContext _context;

        public TorientedElementWithLengthController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TorientedElementWithLength
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TorientedElementWithLength>>> GetTorientedElementWithLength()
        {
            return await _context.TorientedElementWithLength.ToListAsync();
        }

        // GET: api/TorientedElementWithLength/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TorientedElementWithLength>> GetTorientedElementWithLength(short id)
        {
            var torientedElementWithLength = await _context.TorientedElementWithLength.FindAsync(id);

            if (torientedElementWithLength == null)
            {
                return NotFound();
            }

            return torientedElementWithLength;
        }

        // PUT: api/TorientedElementWithLength/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTorientedElementWithLength(short id, TorientedElementWithLength torientedElementWithLength)
        {
            if (id != torientedElementWithLength.TorientedElementWithLengthId)
            {
                return BadRequest();
            }

            _context.Entry(torientedElementWithLength).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TorientedElementWithLengthExists(id))
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

        // POST: api/TorientedElementWithLength
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TorientedElementWithLength>> PostTorientedElementWithLength(TorientedElementWithLength torientedElementWithLength)
        {
            _context.TorientedElementWithLength.Add(torientedElementWithLength);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TorientedElementWithLengthExists(torientedElementWithLength.TorientedElementWithLengthId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTorientedElementWithLength", new { id = torientedElementWithLength.TorientedElementWithLengthId }, torientedElementWithLength);
        }

        // DELETE: api/TorientedElementWithLength/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TorientedElementWithLength>> DeleteTorientedElementWithLength(short id)
        {
            var torientedElementWithLength = await _context.TorientedElementWithLength.FindAsync(id);
            if (torientedElementWithLength == null)
            {
                return NotFound();
            }

            _context.TorientedElementWithLength.Remove(torientedElementWithLength);
            await _context.SaveChangesAsync();

            return torientedElementWithLength;
        }

        private bool TorientedElementWithLengthExists(short id)
        {
            return _context.TorientedElementWithLength.Any(e => e.TorientedElementWithLengthId == id);
        }
    }
}
