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
    public class TtrainDetectorController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainDetectorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainDetector
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainDetector>>> GetTtrainDetector()
        {
            return await _context.TtrainDetector.ToListAsync();
        }

        // GET: api/TtrainDetector/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainDetector>> GetTtrainDetector(short id)
        {
            var ttrainDetector = await _context.TtrainDetector.FindAsync(id);

            if (ttrainDetector == null)
            {
                return NotFound();
            }

            return ttrainDetector;
        }

        // PUT: api/TtrainDetector/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainDetector(short id, TtrainDetector ttrainDetector)
        {
            if (id != ttrainDetector.TtrainDetectorId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainDetector).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainDetectorExists(id))
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

        // POST: api/TtrainDetector
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainDetector>> PostTtrainDetector(TtrainDetector ttrainDetector)
        {
            _context.TtrainDetector.Add(ttrainDetector);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainDetectorExists(ttrainDetector.TtrainDetectorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainDetector", new { id = ttrainDetector.TtrainDetectorId }, ttrainDetector);
        }

        // DELETE: api/TtrainDetector/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainDetector>> DeleteTtrainDetector(short id)
        {
            var ttrainDetector = await _context.TtrainDetector.FindAsync(id);
            if (ttrainDetector == null)
            {
                return NotFound();
            }

            _context.TtrainDetector.Remove(ttrainDetector);
            await _context.SaveChangesAsync();

            return ttrainDetector;
        }

        private bool TtrainDetectorExists(short id)
        {
            return _context.TtrainDetector.Any(e => e.TtrainDetectorId == id);
        }
    }
}
