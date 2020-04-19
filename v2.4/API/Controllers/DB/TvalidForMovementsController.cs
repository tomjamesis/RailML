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
    public class TvalidForMovementsController : ControllerBase
    {
        private readonly DBContext _context;

        public TvalidForMovementsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TvalidForMovements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TvalidForMovements>>> GetTvalidForMovements()
        {
            return await _context.TvalidForMovements.ToListAsync();
        }

        // GET: api/TvalidForMovements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TvalidForMovements>> GetTvalidForMovements(long id)
        {
            var tvalidForMovements = await _context.TvalidForMovements.FindAsync(id);

            if (tvalidForMovements == null)
            {
                return NotFound();
            }

            return tvalidForMovements;
        }

        // PUT: api/TvalidForMovements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTvalidForMovements(long id, TvalidForMovements tvalidForMovements)
        {
            if (id != tvalidForMovements.TvalidForMovementsId)
            {
                return BadRequest();
            }

            _context.Entry(tvalidForMovements).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvalidForMovementsExists(id))
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

        // POST: api/TvalidForMovements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TvalidForMovements>> PostTvalidForMovements(TvalidForMovements tvalidForMovements)
        {
            _context.TvalidForMovements.Add(tvalidForMovements);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TvalidForMovementsExists(tvalidForMovements.TvalidForMovementsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTvalidForMovements", new { id = tvalidForMovements.TvalidForMovementsId }, tvalidForMovements);
        }

        // DELETE: api/TvalidForMovements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TvalidForMovements>> DeleteTvalidForMovements(long id)
        {
            var tvalidForMovements = await _context.TvalidForMovements.FindAsync(id);
            if (tvalidForMovements == null)
            {
                return NotFound();
            }

            _context.TvalidForMovements.Remove(tvalidForMovements);
            await _context.SaveChangesAsync();

            return tvalidForMovements;
        }

        private bool TvalidForMovementsExists(long id)
        {
            return _context.TvalidForMovements.Any(e => e.TvalidForMovementsId == id);
        }
    }
}
