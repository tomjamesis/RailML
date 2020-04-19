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
    public class ToperationModeController : ControllerBase
    {
        private readonly DBContext _context;

        public ToperationModeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ToperationMode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToperationMode>>> GetToperationMode()
        {
            return await _context.ToperationMode.ToListAsync();
        }

        // GET: api/ToperationMode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToperationMode>> GetToperationMode(long id)
        {
            var toperationMode = await _context.ToperationMode.FindAsync(id);

            if (toperationMode == null)
            {
                return NotFound();
            }

            return toperationMode;
        }

        // PUT: api/ToperationMode/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToperationMode(long id, ToperationMode toperationMode)
        {
            if (id != toperationMode.ToperationModeId)
            {
                return BadRequest();
            }

            _context.Entry(toperationMode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToperationModeExists(id))
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

        // POST: api/ToperationMode
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToperationMode>> PostToperationMode(ToperationMode toperationMode)
        {
            _context.ToperationMode.Add(toperationMode);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToperationModeExists(toperationMode.ToperationModeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetToperationMode", new { id = toperationMode.ToperationModeId }, toperationMode);
        }

        // DELETE: api/ToperationMode/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToperationMode>> DeleteToperationMode(long id)
        {
            var toperationMode = await _context.ToperationMode.FindAsync(id);
            if (toperationMode == null)
            {
                return NotFound();
            }

            _context.ToperationMode.Remove(toperationMode);
            await _context.SaveChangesAsync();

            return toperationMode;
        }

        private bool ToperationModeExists(long id)
        {
            return _context.ToperationMode.Any(e => e.ToperationModeId == id);
        }
    }
}
