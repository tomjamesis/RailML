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
    public class TspeedChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TspeedChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TspeedChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TspeedChange>>> GetTspeedChange()
        {
            return await _context.TspeedChange.ToListAsync();
        }

        // GET: api/TspeedChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TspeedChange>> GetTspeedChange(short id)
        {
            var tspeedChange = await _context.TspeedChange.FindAsync(id);

            if (tspeedChange == null)
            {
                return NotFound();
            }

            return tspeedChange;
        }

        // PUT: api/TspeedChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTspeedChange(short id, TspeedChange tspeedChange)
        {
            if (id != tspeedChange.TspeedChangeId)
            {
                return BadRequest();
            }

            _context.Entry(tspeedChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TspeedChangeExists(id))
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

        // POST: api/TspeedChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TspeedChange>> PostTspeedChange(TspeedChange tspeedChange)
        {
            _context.TspeedChange.Add(tspeedChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TspeedChangeExists(tspeedChange.TspeedChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTspeedChange", new { id = tspeedChange.TspeedChangeId }, tspeedChange);
        }

        // DELETE: api/TspeedChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TspeedChange>> DeleteTspeedChange(short id)
        {
            var tspeedChange = await _context.TspeedChange.FindAsync(id);
            if (tspeedChange == null)
            {
                return NotFound();
            }

            _context.TspeedChange.Remove(tspeedChange);
            await _context.SaveChangesAsync();

            return tspeedChange;
        }

        private bool TspeedChangeExists(short id)
        {
            return _context.TspeedChange.Any(e => e.TspeedChangeId == id);
        }
    }
}
