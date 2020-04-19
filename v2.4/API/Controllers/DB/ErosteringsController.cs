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
    public class ErosteringsController : ControllerBase
    {
        private readonly DBContext _context;

        public ErosteringsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Erosterings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Erosterings>>> GetErosterings()
        {
            return await _context.Erosterings.ToListAsync();
        }

        // GET: api/Erosterings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Erosterings>> GetErosterings(long id)
        {
            var erosterings = await _context.Erosterings.FindAsync(id);

            if (erosterings == null)
            {
                return NotFound();
            }

            return erosterings;
        }

        // PUT: api/Erosterings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutErosterings(long id, Erosterings erosterings)
        {
            if (id != erosterings.ErosteringsId)
            {
                return BadRequest();
            }

            _context.Entry(erosterings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ErosteringsExists(id))
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

        // POST: api/Erosterings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Erosterings>> PostErosterings(Erosterings erosterings)
        {
            _context.Erosterings.Add(erosterings);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ErosteringsExists(erosterings.ErosteringsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetErosterings", new { id = erosterings.ErosteringsId }, erosterings);
        }

        // DELETE: api/Erosterings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Erosterings>> DeleteErosterings(long id)
        {
            var erosterings = await _context.Erosterings.FindAsync(id);
            if (erosterings == null)
            {
                return NotFound();
            }

            _context.Erosterings.Remove(erosterings);
            await _context.SaveChangesAsync();

            return erosterings;
        }

        private bool ErosteringsExists(long id)
        {
            return _context.Erosterings.Any(e => e.ErosteringsId == id);
        }
    }
}
