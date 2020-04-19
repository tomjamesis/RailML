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
    public class ElevelCrossingsController : ControllerBase
    {
        private readonly DBContext _context;

        public ElevelCrossingsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ElevelCrossings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElevelCrossings>>> GetElevelCrossings()
        {
            return await _context.ElevelCrossings.ToListAsync();
        }

        // GET: api/ElevelCrossings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElevelCrossings>> GetElevelCrossings(long id)
        {
            var elevelCrossings = await _context.ElevelCrossings.FindAsync(id);

            if (elevelCrossings == null)
            {
                return NotFound();
            }

            return elevelCrossings;
        }

        // PUT: api/ElevelCrossings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElevelCrossings(long id, ElevelCrossings elevelCrossings)
        {
            if (id != elevelCrossings.ElevelCrossingsId)
            {
                return BadRequest();
            }

            _context.Entry(elevelCrossings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElevelCrossingsExists(id))
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

        // POST: api/ElevelCrossings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ElevelCrossings>> PostElevelCrossings(ElevelCrossings elevelCrossings)
        {
            _context.ElevelCrossings.Add(elevelCrossings);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ElevelCrossingsExists(elevelCrossings.ElevelCrossingsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetElevelCrossings", new { id = elevelCrossings.ElevelCrossingsId }, elevelCrossings);
        }

        // DELETE: api/ElevelCrossings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ElevelCrossings>> DeleteElevelCrossings(long id)
        {
            var elevelCrossings = await _context.ElevelCrossings.FindAsync(id);
            if (elevelCrossings == null)
            {
                return NotFound();
            }

            _context.ElevelCrossings.Remove(elevelCrossings);
            await _context.SaveChangesAsync();

            return elevelCrossings;
        }

        private bool ElevelCrossingsExists(long id)
        {
            return _context.ElevelCrossings.Any(e => e.ElevelCrossingsId == id);
        }
    }
}
