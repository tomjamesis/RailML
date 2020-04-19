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
    public class TelectrificationSystemController : ControllerBase
    {
        private readonly DBContext _context;

        public TelectrificationSystemController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TelectrificationSystem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TelectrificationSystem>>> GetTelectrificationSystem()
        {
            return await _context.TelectrificationSystem.ToListAsync();
        }

        // GET: api/TelectrificationSystem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TelectrificationSystem>> GetTelectrificationSystem(long id)
        {
            var telectrificationSystem = await _context.TelectrificationSystem.FindAsync(id);

            if (telectrificationSystem == null)
            {
                return NotFound();
            }

            return telectrificationSystem;
        }

        // PUT: api/TelectrificationSystem/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelectrificationSystem(long id, TelectrificationSystem telectrificationSystem)
        {
            if (id != telectrificationSystem.TelectrificationSystemId)
            {
                return BadRequest();
            }

            _context.Entry(telectrificationSystem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelectrificationSystemExists(id))
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

        // POST: api/TelectrificationSystem
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TelectrificationSystem>> PostTelectrificationSystem(TelectrificationSystem telectrificationSystem)
        {
            _context.TelectrificationSystem.Add(telectrificationSystem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TelectrificationSystemExists(telectrificationSystem.TelectrificationSystemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTelectrificationSystem", new { id = telectrificationSystem.TelectrificationSystemId }, telectrificationSystem);
        }

        // DELETE: api/TelectrificationSystem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TelectrificationSystem>> DeleteTelectrificationSystem(long id)
        {
            var telectrificationSystem = await _context.TelectrificationSystem.FindAsync(id);
            if (telectrificationSystem == null)
            {
                return NotFound();
            }

            _context.TelectrificationSystem.Remove(telectrificationSystem);
            await _context.SaveChangesAsync();

            return telectrificationSystem;
        }

        private bool TelectrificationSystemExists(long id)
        {
            return _context.TelectrificationSystem.Any(e => e.TelectrificationSystemId == id);
        }
    }
}
