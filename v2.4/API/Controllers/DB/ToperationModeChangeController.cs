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
    public class ToperationModeChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public ToperationModeChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ToperationModeChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToperationModeChange>>> GetToperationModeChange()
        {
            return await _context.ToperationModeChange.ToListAsync();
        }

        // GET: api/ToperationModeChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToperationModeChange>> GetToperationModeChange(short id)
        {
            var toperationModeChange = await _context.ToperationModeChange.FindAsync(id);

            if (toperationModeChange == null)
            {
                return NotFound();
            }

            return toperationModeChange;
        }

        // PUT: api/ToperationModeChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToperationModeChange(short id, ToperationModeChange toperationModeChange)
        {
            if (id != toperationModeChange.ToperationModeChangeId)
            {
                return BadRequest();
            }

            _context.Entry(toperationModeChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToperationModeChangeExists(id))
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

        // POST: api/ToperationModeChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToperationModeChange>> PostToperationModeChange(ToperationModeChange toperationModeChange)
        {
            _context.ToperationModeChange.Add(toperationModeChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToperationModeChangeExists(toperationModeChange.ToperationModeChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetToperationModeChange", new { id = toperationModeChange.ToperationModeChangeId }, toperationModeChange);
        }

        // DELETE: api/ToperationModeChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToperationModeChange>> DeleteToperationModeChange(short id)
        {
            var toperationModeChange = await _context.ToperationModeChange.FindAsync(id);
            if (toperationModeChange == null)
            {
                return NotFound();
            }

            _context.ToperationModeChange.Remove(toperationModeChange);
            await _context.SaveChangesAsync();

            return toperationModeChange;
        }

        private bool ToperationModeChangeExists(short id)
        {
            return _context.ToperationModeChange.Any(e => e.ToperationModeChangeId == id);
        }
    }
}
