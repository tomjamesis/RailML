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
    public class EmonitoringController : ControllerBase
    {
        private readonly DBContext _context;

        public EmonitoringController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Emonitoring
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emonitoring>>> GetEmonitoring()
        {
            return await _context.Emonitoring.ToListAsync();
        }

        // GET: api/Emonitoring/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emonitoring>> GetEmonitoring(short id)
        {
            var emonitoring = await _context.Emonitoring.FindAsync(id);

            if (emonitoring == null)
            {
                return NotFound();
            }

            return emonitoring;
        }

        // PUT: api/Emonitoring/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmonitoring(short id, Emonitoring emonitoring)
        {
            if (id != emonitoring.EmonitoringId)
            {
                return BadRequest();
            }

            _context.Entry(emonitoring).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmonitoringExists(id))
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

        // POST: api/Emonitoring
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Emonitoring>> PostEmonitoring(Emonitoring emonitoring)
        {
            _context.Emonitoring.Add(emonitoring);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmonitoringExists(emonitoring.EmonitoringId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmonitoring", new { id = emonitoring.EmonitoringId }, emonitoring);
        }

        // DELETE: api/Emonitoring/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Emonitoring>> DeleteEmonitoring(short id)
        {
            var emonitoring = await _context.Emonitoring.FindAsync(id);
            if (emonitoring == null)
            {
                return NotFound();
            }

            _context.Emonitoring.Remove(emonitoring);
            await _context.SaveChangesAsync();

            return emonitoring;
        }

        private bool EmonitoringExists(short id)
        {
            return _context.Emonitoring.Any(e => e.EmonitoringId == id);
        }
    }
}
