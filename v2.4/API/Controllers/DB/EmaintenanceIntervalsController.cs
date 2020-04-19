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
    public class EmaintenanceIntervalsController : ControllerBase
    {
        private readonly DBContext _context;

        public EmaintenanceIntervalsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EmaintenanceIntervals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmaintenanceIntervals>>> GetEmaintenanceIntervals()
        {
            return await _context.EmaintenanceIntervals.ToListAsync();
        }

        // GET: api/EmaintenanceIntervals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmaintenanceIntervals>> GetEmaintenanceIntervals(long id)
        {
            var emaintenanceIntervals = await _context.EmaintenanceIntervals.FindAsync(id);

            if (emaintenanceIntervals == null)
            {
                return NotFound();
            }

            return emaintenanceIntervals;
        }

        // PUT: api/EmaintenanceIntervals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmaintenanceIntervals(long id, EmaintenanceIntervals emaintenanceIntervals)
        {
            if (id != emaintenanceIntervals.EmaintenanceIntervalsId)
            {
                return BadRequest();
            }

            _context.Entry(emaintenanceIntervals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmaintenanceIntervalsExists(id))
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

        // POST: api/EmaintenanceIntervals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EmaintenanceIntervals>> PostEmaintenanceIntervals(EmaintenanceIntervals emaintenanceIntervals)
        {
            _context.EmaintenanceIntervals.Add(emaintenanceIntervals);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmaintenanceIntervalsExists(emaintenanceIntervals.EmaintenanceIntervalsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmaintenanceIntervals", new { id = emaintenanceIntervals.EmaintenanceIntervalsId }, emaintenanceIntervals);
        }

        // DELETE: api/EmaintenanceIntervals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmaintenanceIntervals>> DeleteEmaintenanceIntervals(long id)
        {
            var emaintenanceIntervals = await _context.EmaintenanceIntervals.FindAsync(id);
            if (emaintenanceIntervals == null)
            {
                return NotFound();
            }

            _context.EmaintenanceIntervals.Remove(emaintenanceIntervals);
            await _context.SaveChangesAsync();

            return emaintenanceIntervals;
        }

        private bool EmaintenanceIntervalsExists(long id)
        {
            return _context.EmaintenanceIntervals.Any(e => e.EmaintenanceIntervalsId == id);
        }
    }
}
