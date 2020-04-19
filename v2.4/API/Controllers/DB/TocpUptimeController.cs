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
    public class TocpUptimeController : ControllerBase
    {
        private readonly DBContext _context;

        public TocpUptimeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TocpUptime
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TocpUptime>>> GetTocpUptime()
        {
            return await _context.TocpUptime.ToListAsync();
        }

        // GET: api/TocpUptime/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TocpUptime>> GetTocpUptime(short id)
        {
            var tocpUptime = await _context.TocpUptime.FindAsync(id);

            if (tocpUptime == null)
            {
                return NotFound();
            }

            return tocpUptime;
        }

        // PUT: api/TocpUptime/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTocpUptime(short id, TocpUptime tocpUptime)
        {
            if (id != tocpUptime.TocpUptimeId)
            {
                return BadRequest();
            }

            _context.Entry(tocpUptime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TocpUptimeExists(id))
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

        // POST: api/TocpUptime
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TocpUptime>> PostTocpUptime(TocpUptime tocpUptime)
        {
            _context.TocpUptime.Add(tocpUptime);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TocpUptimeExists(tocpUptime.TocpUptimeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTocpUptime", new { id = tocpUptime.TocpUptimeId }, tocpUptime);
        }

        // DELETE: api/TocpUptime/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TocpUptime>> DeleteTocpUptime(short id)
        {
            var tocpUptime = await _context.TocpUptime.FindAsync(id);
            if (tocpUptime == null)
            {
                return NotFound();
            }

            _context.TocpUptime.Remove(tocpUptime);
            await _context.SaveChangesAsync();

            return tocpUptime;
        }

        private bool TocpUptimeExists(short id)
        {
            return _context.TocpUptime.Any(e => e.TocpUptimeId == id);
        }
    }
}
