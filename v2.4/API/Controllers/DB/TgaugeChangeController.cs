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
    public class TgaugeChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TgaugeChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TgaugeChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TgaugeChange>>> GetTgaugeChange()
        {
            return await _context.TgaugeChange.ToListAsync();
        }

        // GET: api/TgaugeChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TgaugeChange>> GetTgaugeChange(short id)
        {
            var tgaugeChange = await _context.TgaugeChange.FindAsync(id);

            if (tgaugeChange == null)
            {
                return NotFound();
            }

            return tgaugeChange;
        }

        // PUT: api/TgaugeChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTgaugeChange(short id, TgaugeChange tgaugeChange)
        {
            if (id != tgaugeChange.TgaugeChangeId)
            {
                return BadRequest();
            }

            _context.Entry(tgaugeChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TgaugeChangeExists(id))
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

        // POST: api/TgaugeChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TgaugeChange>> PostTgaugeChange(TgaugeChange tgaugeChange)
        {
            _context.TgaugeChange.Add(tgaugeChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TgaugeChangeExists(tgaugeChange.TgaugeChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTgaugeChange", new { id = tgaugeChange.TgaugeChangeId }, tgaugeChange);
        }

        // DELETE: api/TgaugeChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TgaugeChange>> DeleteTgaugeChange(short id)
        {
            var tgaugeChange = await _context.TgaugeChange.FindAsync(id);
            if (tgaugeChange == null)
            {
                return NotFound();
            }

            _context.TgaugeChange.Remove(tgaugeChange);
            await _context.SaveChangesAsync();

            return tgaugeChange;
        }

        private bool TgaugeChangeExists(short id)
        {
            return _context.TgaugeChange.Any(e => e.TgaugeChangeId == id);
        }
    }
}
