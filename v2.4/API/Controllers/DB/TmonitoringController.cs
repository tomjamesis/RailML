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
    public class TmonitoringController : ControllerBase
    {
        private readonly DBContext _context;

        public TmonitoringController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tmonitoring
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tmonitoring>>> GetTmonitoring()
        {
            return await _context.Tmonitoring.ToListAsync();
        }

        // GET: api/Tmonitoring/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tmonitoring>> GetTmonitoring(long id)
        {
            var tmonitoring = await _context.Tmonitoring.FindAsync(id);

            if (tmonitoring == null)
            {
                return NotFound();
            }

            return tmonitoring;
        }

        // PUT: api/Tmonitoring/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmonitoring(long id, Tmonitoring tmonitoring)
        {
            if (id != tmonitoring.TmonitoringId)
            {
                return BadRequest();
            }

            _context.Entry(tmonitoring).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmonitoringExists(id))
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

        // POST: api/Tmonitoring
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tmonitoring>> PostTmonitoring(Tmonitoring tmonitoring)
        {
            _context.Tmonitoring.Add(tmonitoring);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmonitoringExists(tmonitoring.TmonitoringId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmonitoring", new { id = tmonitoring.TmonitoringId }, tmonitoring);
        }

        // DELETE: api/Tmonitoring/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tmonitoring>> DeleteTmonitoring(long id)
        {
            var tmonitoring = await _context.Tmonitoring.FindAsync(id);
            if (tmonitoring == null)
            {
                return NotFound();
            }

            _context.Tmonitoring.Remove(tmonitoring);
            await _context.SaveChangesAsync();

            return tmonitoring;
        }

        private bool TmonitoringExists(long id)
        {
            return _context.Tmonitoring.Any(e => e.TmonitoringId == id);
        }
    }
}
