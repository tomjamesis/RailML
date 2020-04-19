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
    public class ElevelCrossingController : ControllerBase
    {
        private readonly DBContext _context;

        public ElevelCrossingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ElevelCrossing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElevelCrossing>>> GetElevelCrossing()
        {
            return await _context.ElevelCrossing.ToListAsync();
        }

        // GET: api/ElevelCrossing/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElevelCrossing>> GetElevelCrossing(short id)
        {
            var elevelCrossing = await _context.ElevelCrossing.FindAsync(id);

            if (elevelCrossing == null)
            {
                return NotFound();
            }

            return elevelCrossing;
        }

        // PUT: api/ElevelCrossing/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElevelCrossing(short id, ElevelCrossing elevelCrossing)
        {
            if (id != elevelCrossing.ElevelCrossingId)
            {
                return BadRequest();
            }

            _context.Entry(elevelCrossing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElevelCrossingExists(id))
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

        // POST: api/ElevelCrossing
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ElevelCrossing>> PostElevelCrossing(ElevelCrossing elevelCrossing)
        {
            _context.ElevelCrossing.Add(elevelCrossing);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ElevelCrossingExists(elevelCrossing.ElevelCrossingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetElevelCrossing", new { id = elevelCrossing.ElevelCrossingId }, elevelCrossing);
        }

        // DELETE: api/ElevelCrossing/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ElevelCrossing>> DeleteElevelCrossing(short id)
        {
            var elevelCrossing = await _context.ElevelCrossing.FindAsync(id);
            if (elevelCrossing == null)
            {
                return NotFound();
            }

            _context.ElevelCrossing.Remove(elevelCrossing);
            await _context.SaveChangesAsync();

            return elevelCrossing;
        }

        private bool ElevelCrossingExists(short id)
        {
            return _context.ElevelCrossing.Any(e => e.ElevelCrossingId == id);
        }
    }
}
