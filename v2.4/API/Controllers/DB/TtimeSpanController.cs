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
    public class TtimeSpanController : ControllerBase
    {
        private readonly DBContext _context;

        public TtimeSpanController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtimeSpan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtimeSpan>>> GetTtimeSpan()
        {
            return await _context.TtimeSpan.ToListAsync();
        }

        // GET: api/TtimeSpan/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtimeSpan>> GetTtimeSpan(long id)
        {
            var ttimeSpan = await _context.TtimeSpan.FindAsync(id);

            if (ttimeSpan == null)
            {
                return NotFound();
            }

            return ttimeSpan;
        }

        // PUT: api/TtimeSpan/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtimeSpan(long id, TtimeSpan ttimeSpan)
        {
            if (id != ttimeSpan.TtimeSpanId)
            {
                return BadRequest();
            }

            _context.Entry(ttimeSpan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtimeSpanExists(id))
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

        // POST: api/TtimeSpan
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtimeSpan>> PostTtimeSpan(TtimeSpan ttimeSpan)
        {
            _context.TtimeSpan.Add(ttimeSpan);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtimeSpanExists(ttimeSpan.TtimeSpanId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtimeSpan", new { id = ttimeSpan.TtimeSpanId }, ttimeSpan);
        }

        // DELETE: api/TtimeSpan/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtimeSpan>> DeleteTtimeSpan(long id)
        {
            var ttimeSpan = await _context.TtimeSpan.FindAsync(id);
            if (ttimeSpan == null)
            {
                return NotFound();
            }

            _context.TtimeSpan.Remove(ttimeSpan);
            await _context.SaveChangesAsync();

            return ttimeSpan;
        }

        private bool TtimeSpanExists(long id)
        {
            return _context.TtimeSpan.Any(e => e.TtimeSpanId == id);
        }
    }
}
