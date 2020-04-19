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
    public class TownerChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TownerChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TownerChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TownerChange>>> GetTownerChange()
        {
            return await _context.TownerChange.ToListAsync();
        }

        // GET: api/TownerChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TownerChange>> GetTownerChange(short id)
        {
            var townerChange = await _context.TownerChange.FindAsync(id);

            if (townerChange == null)
            {
                return NotFound();
            }

            return townerChange;
        }

        // PUT: api/TownerChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTownerChange(short id, TownerChange townerChange)
        {
            if (id != townerChange.TownerChangeId)
            {
                return BadRequest();
            }

            _context.Entry(townerChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TownerChangeExists(id))
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

        // POST: api/TownerChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TownerChange>> PostTownerChange(TownerChange townerChange)
        {
            _context.TownerChange.Add(townerChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TownerChangeExists(townerChange.TownerChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTownerChange", new { id = townerChange.TownerChangeId }, townerChange);
        }

        // DELETE: api/TownerChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TownerChange>> DeleteTownerChange(short id)
        {
            var townerChange = await _context.TownerChange.FindAsync(id);
            if (townerChange == null)
            {
                return NotFound();
            }

            _context.TownerChange.Remove(townerChange);
            await _context.SaveChangesAsync();

            return townerChange;
        }

        private bool TownerChangeExists(short id)
        {
            return _context.TownerChange.Any(e => e.TownerChangeId == id);
        }
    }
}
