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
    public class TtrainProtectionChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainProtectionChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainProtectionChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainProtectionChange>>> GetTtrainProtectionChange()
        {
            return await _context.TtrainProtectionChange.ToListAsync();
        }

        // GET: api/TtrainProtectionChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainProtectionChange>> GetTtrainProtectionChange(short id)
        {
            var ttrainProtectionChange = await _context.TtrainProtectionChange.FindAsync(id);

            if (ttrainProtectionChange == null)
            {
                return NotFound();
            }

            return ttrainProtectionChange;
        }

        // PUT: api/TtrainProtectionChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainProtectionChange(short id, TtrainProtectionChange ttrainProtectionChange)
        {
            if (id != ttrainProtectionChange.TtrainProtectionChangeId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainProtectionChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainProtectionChangeExists(id))
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

        // POST: api/TtrainProtectionChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainProtectionChange>> PostTtrainProtectionChange(TtrainProtectionChange ttrainProtectionChange)
        {
            _context.TtrainProtectionChange.Add(ttrainProtectionChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainProtectionChangeExists(ttrainProtectionChange.TtrainProtectionChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainProtectionChange", new { id = ttrainProtectionChange.TtrainProtectionChangeId }, ttrainProtectionChange);
        }

        // DELETE: api/TtrainProtectionChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainProtectionChange>> DeleteTtrainProtectionChange(short id)
        {
            var ttrainProtectionChange = await _context.TtrainProtectionChange.FindAsync(id);
            if (ttrainProtectionChange == null)
            {
                return NotFound();
            }

            _context.TtrainProtectionChange.Remove(ttrainProtectionChange);
            await _context.SaveChangesAsync();

            return ttrainProtectionChange;
        }

        private bool TtrainProtectionChangeExists(short id)
        {
            return _context.TtrainProtectionChange.Any(e => e.TtrainProtectionChangeId == id);
        }
    }
}
