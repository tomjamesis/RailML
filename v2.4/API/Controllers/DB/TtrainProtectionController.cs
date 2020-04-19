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
    public class TtrainProtectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainProtectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainProtection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainProtection>>> GetTtrainProtection()
        {
            return await _context.TtrainProtection.ToListAsync();
        }

        // GET: api/TtrainProtection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainProtection>> GetTtrainProtection(long id)
        {
            var ttrainProtection = await _context.TtrainProtection.FindAsync(id);

            if (ttrainProtection == null)
            {
                return NotFound();
            }

            return ttrainProtection;
        }

        // PUT: api/TtrainProtection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainProtection(long id, TtrainProtection ttrainProtection)
        {
            if (id != ttrainProtection.TtrainProtectionId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainProtection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainProtectionExists(id))
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

        // POST: api/TtrainProtection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainProtection>> PostTtrainProtection(TtrainProtection ttrainProtection)
        {
            _context.TtrainProtection.Add(ttrainProtection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainProtectionExists(ttrainProtection.TtrainProtectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainProtection", new { id = ttrainProtection.TtrainProtectionId }, ttrainProtection);
        }

        // DELETE: api/TtrainProtection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainProtection>> DeleteTtrainProtection(long id)
        {
            var ttrainProtection = await _context.TtrainProtection.FindAsync(id);
            if (ttrainProtection == null)
            {
                return NotFound();
            }

            _context.TtrainProtection.Remove(ttrainProtection);
            await _context.SaveChangesAsync();

            return ttrainProtection;
        }

        private bool TtrainProtectionExists(long id)
        {
            return _context.TtrainProtection.Any(e => e.TtrainProtectionId == id);
        }
    }
}
