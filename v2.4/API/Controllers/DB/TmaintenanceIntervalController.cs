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
    public class TmaintenanceIntervalController : ControllerBase
    {
        private readonly DBContext _context;

        public TmaintenanceIntervalController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmaintenanceInterval
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmaintenanceInterval>>> GetTmaintenanceInterval()
        {
            return await _context.TmaintenanceInterval.ToListAsync();
        }

        // GET: api/TmaintenanceInterval/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmaintenanceInterval>> GetTmaintenanceInterval(short id)
        {
            var tmaintenanceInterval = await _context.TmaintenanceInterval.FindAsync(id);

            if (tmaintenanceInterval == null)
            {
                return NotFound();
            }

            return tmaintenanceInterval;
        }

        // PUT: api/TmaintenanceInterval/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmaintenanceInterval(short id, TmaintenanceInterval tmaintenanceInterval)
        {
            if (id != tmaintenanceInterval.TmaintenanceIntervalId)
            {
                return BadRequest();
            }

            _context.Entry(tmaintenanceInterval).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmaintenanceIntervalExists(id))
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

        // POST: api/TmaintenanceInterval
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmaintenanceInterval>> PostTmaintenanceInterval(TmaintenanceInterval tmaintenanceInterval)
        {
            _context.TmaintenanceInterval.Add(tmaintenanceInterval);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmaintenanceIntervalExists(tmaintenanceInterval.TmaintenanceIntervalId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmaintenanceInterval", new { id = tmaintenanceInterval.TmaintenanceIntervalId }, tmaintenanceInterval);
        }

        // DELETE: api/TmaintenanceInterval/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmaintenanceInterval>> DeleteTmaintenanceInterval(short id)
        {
            var tmaintenanceInterval = await _context.TmaintenanceInterval.FindAsync(id);
            if (tmaintenanceInterval == null)
            {
                return NotFound();
            }

            _context.TmaintenanceInterval.Remove(tmaintenanceInterval);
            await _context.SaveChangesAsync();

            return tmaintenanceInterval;
        }

        private bool TmaintenanceIntervalExists(short id)
        {
            return _context.TmaintenanceInterval.Any(e => e.TmaintenanceIntervalId == id);
        }
    }
}
