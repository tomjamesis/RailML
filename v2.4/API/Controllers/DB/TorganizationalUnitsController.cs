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
    public class TorganizationalUnitsController : ControllerBase
    {
        private readonly DBContext _context;

        public TorganizationalUnitsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TorganizationalUnits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TorganizationalUnits>>> GetTorganizationalUnits()
        {
            return await _context.TorganizationalUnits.ToListAsync();
        }

        // GET: api/TorganizationalUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TorganizationalUnits>> GetTorganizationalUnits(long id)
        {
            var torganizationalUnits = await _context.TorganizationalUnits.FindAsync(id);

            if (torganizationalUnits == null)
            {
                return NotFound();
            }

            return torganizationalUnits;
        }

        // PUT: api/TorganizationalUnits/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTorganizationalUnits(long id, TorganizationalUnits torganizationalUnits)
        {
            if (id != torganizationalUnits.TorganizationalUnitsId)
            {
                return BadRequest();
            }

            _context.Entry(torganizationalUnits).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TorganizationalUnitsExists(id))
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

        // POST: api/TorganizationalUnits
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TorganizationalUnits>> PostTorganizationalUnits(TorganizationalUnits torganizationalUnits)
        {
            _context.TorganizationalUnits.Add(torganizationalUnits);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TorganizationalUnitsExists(torganizationalUnits.TorganizationalUnitsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTorganizationalUnits", new { id = torganizationalUnits.TorganizationalUnitsId }, torganizationalUnits);
        }

        // DELETE: api/TorganizationalUnits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TorganizationalUnits>> DeleteTorganizationalUnits(long id)
        {
            var torganizationalUnits = await _context.TorganizationalUnits.FindAsync(id);
            if (torganizationalUnits == null)
            {
                return NotFound();
            }

            _context.TorganizationalUnits.Remove(torganizationalUnits);
            await _context.SaveChangesAsync();

            return torganizationalUnits;
        }

        private bool TorganizationalUnitsExists(long id)
        {
            return _context.TorganizationalUnits.Any(e => e.TorganizationalUnitsId == id);
        }
    }
}
