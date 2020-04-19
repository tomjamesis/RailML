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
    public class EcrossingController : ControllerBase
    {
        private readonly DBContext _context;

        public EcrossingController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ecrossing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ecrossing>>> GetEcrossing()
        {
            return await _context.Ecrossing.ToListAsync();
        }

        // GET: api/Ecrossing/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ecrossing>> GetEcrossing(short id)
        {
            var ecrossing = await _context.Ecrossing.FindAsync(id);

            if (ecrossing == null)
            {
                return NotFound();
            }

            return ecrossing;
        }

        // PUT: api/Ecrossing/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEcrossing(short id, Ecrossing ecrossing)
        {
            if (id != ecrossing.EcrossingId)
            {
                return BadRequest();
            }

            _context.Entry(ecrossing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EcrossingExists(id))
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

        // POST: api/Ecrossing
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ecrossing>> PostEcrossing(Ecrossing ecrossing)
        {
            _context.Ecrossing.Add(ecrossing);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EcrossingExists(ecrossing.EcrossingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEcrossing", new { id = ecrossing.EcrossingId }, ecrossing);
        }

        // DELETE: api/Ecrossing/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ecrossing>> DeleteEcrossing(short id)
        {
            var ecrossing = await _context.Ecrossing.FindAsync(id);
            if (ecrossing == null)
            {
                return NotFound();
            }

            _context.Ecrossing.Remove(ecrossing);
            await _context.SaveChangesAsync();

            return ecrossing;
        }

        private bool EcrossingExists(short id)
        {
            return _context.Ecrossing.Any(e => e.EcrossingId == id);
        }
    }
}
