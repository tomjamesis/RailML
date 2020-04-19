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
    public class EcouplersController : ControllerBase
    {
        private readonly DBContext _context;

        public EcouplersController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ecouplers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ecouplers>>> GetEcouplers()
        {
            return await _context.Ecouplers.ToListAsync();
        }

        // GET: api/Ecouplers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ecouplers>> GetEcouplers(long id)
        {
            var ecouplers = await _context.Ecouplers.FindAsync(id);

            if (ecouplers == null)
            {
                return NotFound();
            }

            return ecouplers;
        }

        // PUT: api/Ecouplers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcouplers(long id, Ecouplers ecouplers)
        {
            if (id != ecouplers.EcouplersId)
            {
                return BadRequest();
            }

            _context.Entry(ecouplers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcouplersExists(id))
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

        // POST: api/Ecouplers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ecouplers>> PostEcouplers(Ecouplers ecouplers)
        {
            _context.Ecouplers.Add(ecouplers);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcouplersExists(ecouplers.EcouplersId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcouplers", new { id = ecouplers.EcouplersId }, ecouplers);
        }

        // DELETE: api/Ecouplers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ecouplers>> DeleteEcouplers(long id)
        {
            var ecouplers = await _context.Ecouplers.FindAsync(id);
            if (ecouplers == null)
            {
                return NotFound();
            }

            _context.Ecouplers.Remove(ecouplers);
            await _context.SaveChangesAsync();

            return ecouplers;
        }

        private bool EcouplersExists(long id)
        {
            return _context.Ecouplers.Any(e => e.EcouplersId == id);
        }
    }
}
