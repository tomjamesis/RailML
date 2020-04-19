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
    public class TverbalCounterController : ControllerBase
    {
        private readonly DBContext _context;

        public TverbalCounterController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TverbalCounter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TverbalCounter>>> GetTverbalCounter()
        {
            return await _context.TverbalCounter.ToListAsync();
        }

        // GET: api/TverbalCounter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TverbalCounter>> GetTverbalCounter(byte id)
        {
            var tverbalCounter = await _context.TverbalCounter.FindAsync(id);

            if (tverbalCounter == null)
            {
                return NotFound();
            }

            return tverbalCounter;
        }

        // PUT: api/TverbalCounter/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTverbalCounter(byte id, TverbalCounter tverbalCounter)
        {
            if (id != tverbalCounter.TverbalCounterId)
            {
                return BadRequest();
            }

            _context.Entry(tverbalCounter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TverbalCounterExists(id))
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

        // POST: api/TverbalCounter
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TverbalCounter>> PostTverbalCounter(TverbalCounter tverbalCounter)
        {
            _context.TverbalCounter.Add(tverbalCounter);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TverbalCounterExists(tverbalCounter.TverbalCounterId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTverbalCounter", new { id = tverbalCounter.TverbalCounterId }, tverbalCounter);
        }

        // DELETE: api/TverbalCounter/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TverbalCounter>> DeleteTverbalCounter(byte id)
        {
            var tverbalCounter = await _context.TverbalCounter.FindAsync(id);
            if (tverbalCounter == null)
            {
                return NotFound();
            }

            _context.TverbalCounter.Remove(tverbalCounter);
            await _context.SaveChangesAsync();

            return tverbalCounter;
        }

        private bool TverbalCounterExists(byte id)
        {
            return _context.TverbalCounter.Any(e => e.TverbalCounterId == id);
        }
    }
}
