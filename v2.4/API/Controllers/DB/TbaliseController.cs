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
    public class TbaliseController : ControllerBase
    {
        private readonly DBContext _context;

        public TbaliseController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tbalise
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tbalise>>> GetTbalise()
        {
            return await _context.Tbalise.ToListAsync();
        }

        // GET: api/Tbalise/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tbalise>> GetTbalise(short id)
        {
            var tbalise = await _context.Tbalise.FindAsync(id);

            if (tbalise == null)
            {
                return NotFound();
            }

            return tbalise;
        }

        // PUT: api/Tbalise/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbalise(short id, Tbalise tbalise)
        {
            if (id != tbalise.TbaliseId)
            {
                return BadRequest();
            }

            _context.Entry(tbalise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbaliseExists(id))
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

        // POST: api/Tbalise
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tbalise>> PostTbalise(Tbalise tbalise)
        {
            _context.Tbalise.Add(tbalise);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbaliseExists(tbalise.TbaliseId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbalise", new { id = tbalise.TbaliseId }, tbalise);
        }

        // DELETE: api/Tbalise/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tbalise>> DeleteTbalise(short id)
        {
            var tbalise = await _context.Tbalise.FindAsync(id);
            if (tbalise == null)
            {
                return NotFound();
            }

            _context.Tbalise.Remove(tbalise);
            await _context.SaveChangesAsync();

            return tbalise;
        }

        private bool TbaliseExists(short id)
        {
            return _context.Tbalise.Any(e => e.TbaliseId == id);
        }
    }
}
