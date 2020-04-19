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
    public class TmileageChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TmileageChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmileageChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmileageChange>>> GetTmileageChange()
        {
            return await _context.TmileageChange.ToListAsync();
        }

        // GET: api/TmileageChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmileageChange>> GetTmileageChange(short id)
        {
            var tmileageChange = await _context.TmileageChange.FindAsync(id);

            if (tmileageChange == null)
            {
                return NotFound();
            }

            return tmileageChange;
        }

        // PUT: api/TmileageChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmileageChange(short id, TmileageChange tmileageChange)
        {
            if (id != tmileageChange.TmileageChangeId)
            {
                return BadRequest();
            }

            _context.Entry(tmileageChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmileageChangeExists(id))
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

        // POST: api/TmileageChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmileageChange>> PostTmileageChange(TmileageChange tmileageChange)
        {
            _context.TmileageChange.Add(tmileageChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmileageChangeExists(tmileageChange.TmileageChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmileageChange", new { id = tmileageChange.TmileageChangeId }, tmileageChange);
        }

        // DELETE: api/TmileageChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmileageChange>> DeleteTmileageChange(short id)
        {
            var tmileageChange = await _context.TmileageChange.FindAsync(id);
            if (tmileageChange == null)
            {
                return NotFound();
            }

            _context.TmileageChange.Remove(tmileageChange);
            await _context.SaveChangesAsync();

            return tmileageChange;
        }

        private bool TmileageChangeExists(short id)
        {
            return _context.TmileageChange.Any(e => e.TmileageChangeId == id);
        }
    }
}
