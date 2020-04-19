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
    public class TstatesController : ControllerBase
    {
        private readonly DBContext _context;

        public TstatesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tstates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tstates>>> GetTstates()
        {
            return await _context.Tstates.ToListAsync();
        }

        // GET: api/Tstates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tstates>> GetTstates(long id)
        {
            var tstates = await _context.Tstates.FindAsync(id);

            if (tstates == null)
            {
                return NotFound();
            }

            return tstates;
        }

        // PUT: api/Tstates/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstates(long id, Tstates tstates)
        {
            if (id != tstates.TstatesId)
            {
                return BadRequest();
            }

            _context.Entry(tstates).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstatesExists(id))
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

        // POST: api/Tstates
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tstates>> PostTstates(Tstates tstates)
        {
            _context.Tstates.Add(tstates);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstatesExists(tstates.TstatesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstates", new { id = tstates.TstatesId }, tstates);
        }

        // DELETE: api/Tstates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tstates>> DeleteTstates(long id)
        {
            var tstates = await _context.Tstates.FindAsync(id);
            if (tstates == null)
            {
                return NotFound();
            }

            _context.Tstates.Remove(tstates);
            await _context.SaveChangesAsync();

            return tstates;
        }

        private bool TstatesExists(long id)
        {
            return _context.Tstates.Any(e => e.TstatesId == id);
        }
    }
}
