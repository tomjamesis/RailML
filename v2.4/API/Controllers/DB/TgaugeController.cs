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
    public class TgaugeController : ControllerBase
    {
        private readonly DBContext _context;

        public TgaugeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tgauge
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tgauge>>> GetTgauge()
        {
            return await _context.Tgauge.ToListAsync();
        }

        // GET: api/Tgauge/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tgauge>> GetTgauge(long id)
        {
            var tgauge = await _context.Tgauge.FindAsync(id);

            if (tgauge == null)
            {
                return NotFound();
            }

            return tgauge;
        }

        // PUT: api/Tgauge/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTgauge(long id, Tgauge tgauge)
        {
            if (id != tgauge.TgaugeId)
            {
                return BadRequest();
            }

            _context.Entry(tgauge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TgaugeExists(id))
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

        // POST: api/Tgauge
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tgauge>> PostTgauge(Tgauge tgauge)
        {
            _context.Tgauge.Add(tgauge);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TgaugeExists(tgauge.TgaugeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTgauge", new { id = tgauge.TgaugeId }, tgauge);
        }

        // DELETE: api/Tgauge/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tgauge>> DeleteTgauge(long id)
        {
            var tgauge = await _context.Tgauge.FindAsync(id);
            if (tgauge == null)
            {
                return NotFound();
            }

            _context.Tgauge.Remove(tgauge);
            await _context.SaveChangesAsync();

            return tgauge;
        }

        private bool TgaugeExists(long id)
        {
            return _context.Tgauge.Any(e => e.TgaugeId == id);
        }
    }
}
