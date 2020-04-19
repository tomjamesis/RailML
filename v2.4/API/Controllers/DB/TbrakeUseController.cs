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
    public class TbrakeUseController : ControllerBase
    {
        private readonly DBContext _context;

        public TbrakeUseController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbrakeUse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbrakeUse>>> GetTbrakeUse()
        {
            return await _context.TbrakeUse.ToListAsync();
        }

        // GET: api/TbrakeUse/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbrakeUse>> GetTbrakeUse(byte id)
        {
            var tbrakeUse = await _context.TbrakeUse.FindAsync(id);

            if (tbrakeUse == null)
            {
                return NotFound();
            }

            return tbrakeUse;
        }

        // PUT: api/TbrakeUse/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbrakeUse(byte id, TbrakeUse tbrakeUse)
        {
            if (id != tbrakeUse.TbrakeUseId)
            {
                return BadRequest();
            }

            _context.Entry(tbrakeUse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbrakeUseExists(id))
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

        // POST: api/TbrakeUse
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbrakeUse>> PostTbrakeUse(TbrakeUse tbrakeUse)
        {
            _context.TbrakeUse.Add(tbrakeUse);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbrakeUseExists(tbrakeUse.TbrakeUseId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbrakeUse", new { id = tbrakeUse.TbrakeUseId }, tbrakeUse);
        }

        // DELETE: api/TbrakeUse/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbrakeUse>> DeleteTbrakeUse(byte id)
        {
            var tbrakeUse = await _context.TbrakeUse.FindAsync(id);
            if (tbrakeUse == null)
            {
                return NotFound();
            }

            _context.TbrakeUse.Remove(tbrakeUse);
            await _context.SaveChangesAsync();

            return tbrakeUse;
        }

        private bool TbrakeUseExists(byte id)
        {
            return _context.TbrakeUse.Any(e => e.TbrakeUseId == id);
        }
    }
}
