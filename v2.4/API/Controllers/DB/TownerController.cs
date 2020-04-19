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
    public class TownerController : ControllerBase
    {
        private readonly DBContext _context;

        public TownerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Towner
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Towner>>> GetTowner()
        {
            return await _context.Towner.ToListAsync();
        }

        // GET: api/Towner/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Towner>> GetTowner(long id)
        {
            var towner = await _context.Towner.FindAsync(id);

            if (towner == null)
            {
                return NotFound();
            }

            return towner;
        }

        // PUT: api/Towner/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTowner(long id, Towner towner)
        {
            if (id != towner.TownerId)
            {
                return BadRequest();
            }

            _context.Entry(towner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TownerExists(id))
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

        // POST: api/Towner
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Towner>> PostTowner(Towner towner)
        {
            _context.Towner.Add(towner);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TownerExists(towner.TownerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTowner", new { id = towner.TownerId }, towner);
        }

        // DELETE: api/Towner/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Towner>> DeleteTowner(long id)
        {
            var towner = await _context.Towner.FindAsync(id);
            if (towner == null)
            {
                return NotFound();
            }

            _context.Towner.Remove(towner);
            await _context.SaveChangesAsync();

            return towner;
        }

        private bool TownerExists(long id)
        {
            return _context.Towner.Any(e => e.TownerId == id);
        }
    }
}
