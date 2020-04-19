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
    public class TelectrificationChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TelectrificationChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TelectrificationChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TelectrificationChange>>> GetTelectrificationChange()
        {
            return await _context.TelectrificationChange.ToListAsync();
        }

        // GET: api/TelectrificationChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TelectrificationChange>> GetTelectrificationChange(short id)
        {
            var telectrificationChange = await _context.TelectrificationChange.FindAsync(id);

            if (telectrificationChange == null)
            {
                return NotFound();
            }

            return telectrificationChange;
        }

        // PUT: api/TelectrificationChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelectrificationChange(short id, TelectrificationChange telectrificationChange)
        {
            if (id != telectrificationChange.TelectrificationChangeId)
            {
                return BadRequest();
            }

            _context.Entry(telectrificationChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelectrificationChangeExists(id))
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

        // POST: api/TelectrificationChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TelectrificationChange>> PostTelectrificationChange(TelectrificationChange telectrificationChange)
        {
            _context.TelectrificationChange.Add(telectrificationChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TelectrificationChangeExists(telectrificationChange.TelectrificationChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTelectrificationChange", new { id = telectrificationChange.TelectrificationChangeId }, telectrificationChange);
        }

        // DELETE: api/TelectrificationChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TelectrificationChange>> DeleteTelectrificationChange(short id)
        {
            var telectrificationChange = await _context.TelectrificationChange.FindAsync(id);
            if (telectrificationChange == null)
            {
                return NotFound();
            }

            _context.TelectrificationChange.Remove(telectrificationChange);
            await _context.SaveChangesAsync();

            return telectrificationChange;
        }

        private bool TelectrificationChangeExists(short id)
        {
            return _context.TelectrificationChange.Any(e => e.TelectrificationChangeId == id);
        }
    }
}
