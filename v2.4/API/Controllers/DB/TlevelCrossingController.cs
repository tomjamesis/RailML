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
    public class TlevelCrossingController : ControllerBase
    {
        private readonly DBContext _context;

        public TlevelCrossingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TlevelCrossing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TlevelCrossing>>> GetTlevelCrossing()
        {
            return await _context.TlevelCrossing.ToListAsync();
        }

        // GET: api/TlevelCrossing/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TlevelCrossing>> GetTlevelCrossing(short id)
        {
            var tlevelCrossing = await _context.TlevelCrossing.FindAsync(id);

            if (tlevelCrossing == null)
            {
                return NotFound();
            }

            return tlevelCrossing;
        }

        // PUT: api/TlevelCrossing/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTlevelCrossing(short id, TlevelCrossing tlevelCrossing)
        {
            if (id != tlevelCrossing.TlevelCrossingId)
            {
                return BadRequest();
            }

            _context.Entry(tlevelCrossing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlevelCrossingExists(id))
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

        // POST: api/TlevelCrossing
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TlevelCrossing>> PostTlevelCrossing(TlevelCrossing tlevelCrossing)
        {
            _context.TlevelCrossing.Add(tlevelCrossing);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlevelCrossingExists(tlevelCrossing.TlevelCrossingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTlevelCrossing", new { id = tlevelCrossing.TlevelCrossingId }, tlevelCrossing);
        }

        // DELETE: api/TlevelCrossing/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TlevelCrossing>> DeleteTlevelCrossing(short id)
        {
            var tlevelCrossing = await _context.TlevelCrossing.FindAsync(id);
            if (tlevelCrossing == null)
            {
                return NotFound();
            }

            _context.TlevelCrossing.Remove(tlevelCrossing);
            await _context.SaveChangesAsync();

            return tlevelCrossing;
        }

        private bool TlevelCrossingExists(short id)
        {
            return _context.TlevelCrossing.Any(e => e.TlevelCrossingId == id);
        }
    }
}
