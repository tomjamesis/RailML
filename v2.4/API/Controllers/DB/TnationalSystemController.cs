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
    public class TnationalSystemController : ControllerBase
    {
        private readonly DBContext _context;

        public TnationalSystemController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TnationalSystem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TnationalSystem>>> GetTnationalSystem()
        {
            return await _context.TnationalSystem.ToListAsync();
        }

        // GET: api/TnationalSystem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TnationalSystem>> GetTnationalSystem(short id)
        {
            var tnationalSystem = await _context.TnationalSystem.FindAsync(id);

            if (tnationalSystem == null)
            {
                return NotFound();
            }

            return tnationalSystem;
        }

        // PUT: api/TnationalSystem/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTnationalSystem(short id, TnationalSystem tnationalSystem)
        {
            if (id != tnationalSystem.TnationalSystemId)
            {
                return BadRequest();
            }

            _context.Entry(tnationalSystem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TnationalSystemExists(id))
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

        // POST: api/TnationalSystem
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TnationalSystem>> PostTnationalSystem(TnationalSystem tnationalSystem)
        {
            _context.TnationalSystem.Add(tnationalSystem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TnationalSystemExists(tnationalSystem.TnationalSystemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTnationalSystem", new { id = tnationalSystem.TnationalSystemId }, tnationalSystem);
        }

        // DELETE: api/TnationalSystem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TnationalSystem>> DeleteTnationalSystem(short id)
        {
            var tnationalSystem = await _context.TnationalSystem.FindAsync(id);
            if (tnationalSystem == null)
            {
                return NotFound();
            }

            _context.TnationalSystem.Remove(tnationalSystem);
            await _context.SaveChangesAsync();

            return tnationalSystem;
        }

        private bool TnationalSystemExists(short id)
        {
            return _context.TnationalSystem.Any(e => e.TnationalSystemId == id);
        }
    }
}
