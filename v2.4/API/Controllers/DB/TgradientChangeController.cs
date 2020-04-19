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
    public class TgradientChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TgradientChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TgradientChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TgradientChange>>> GetTgradientChange()
        {
            return await _context.TgradientChange.ToListAsync();
        }

        // GET: api/TgradientChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TgradientChange>> GetTgradientChange(short id)
        {
            var tgradientChange = await _context.TgradientChange.FindAsync(id);

            if (tgradientChange == null)
            {
                return NotFound();
            }

            return tgradientChange;
        }

        // PUT: api/TgradientChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTgradientChange(short id, TgradientChange tgradientChange)
        {
            if (id != tgradientChange.TgradientChangeId)
            {
                return BadRequest();
            }

            _context.Entry(tgradientChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TgradientChangeExists(id))
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

        // POST: api/TgradientChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TgradientChange>> PostTgradientChange(TgradientChange tgradientChange)
        {
            _context.TgradientChange.Add(tgradientChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TgradientChangeExists(tgradientChange.TgradientChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTgradientChange", new { id = tgradientChange.TgradientChangeId }, tgradientChange);
        }

        // DELETE: api/TgradientChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TgradientChange>> DeleteTgradientChange(short id)
        {
            var tgradientChange = await _context.TgradientChange.FindAsync(id);
            if (tgradientChange == null)
            {
                return NotFound();
            }

            _context.TgradientChange.Remove(tgradientChange);
            await _context.SaveChangesAsync();

            return tgradientChange;
        }

        private bool TgradientChangeExists(short id)
        {
            return _context.TgradientChange.Any(e => e.TgradientChangeId == id);
        }
    }
}
