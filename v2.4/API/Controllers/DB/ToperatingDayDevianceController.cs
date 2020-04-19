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
    public class ToperatingDayDevianceController : ControllerBase
    {
        private readonly DBContext _context;

        public ToperatingDayDevianceController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ToperatingDayDeviance
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToperatingDayDeviance>>> GetToperatingDayDeviance()
        {
            return await _context.ToperatingDayDeviance.ToListAsync();
        }

        // GET: api/ToperatingDayDeviance/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToperatingDayDeviance>> GetToperatingDayDeviance(long id)
        {
            var toperatingDayDeviance = await _context.ToperatingDayDeviance.FindAsync(id);

            if (toperatingDayDeviance == null)
            {
                return NotFound();
            }

            return toperatingDayDeviance;
        }

        // PUT: api/ToperatingDayDeviance/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToperatingDayDeviance(long id, ToperatingDayDeviance toperatingDayDeviance)
        {
            if (id != toperatingDayDeviance.ToperatingDayDevianceId)
            {
                return BadRequest();
            }

            _context.Entry(toperatingDayDeviance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToperatingDayDevianceExists(id))
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

        // POST: api/ToperatingDayDeviance
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToperatingDayDeviance>> PostToperatingDayDeviance(ToperatingDayDeviance toperatingDayDeviance)
        {
            _context.ToperatingDayDeviance.Add(toperatingDayDeviance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToperatingDayDevianceExists(toperatingDayDeviance.ToperatingDayDevianceId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetToperatingDayDeviance", new { id = toperatingDayDeviance.ToperatingDayDevianceId }, toperatingDayDeviance);
        }

        // DELETE: api/ToperatingDayDeviance/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToperatingDayDeviance>> DeleteToperatingDayDeviance(long id)
        {
            var toperatingDayDeviance = await _context.ToperatingDayDeviance.FindAsync(id);
            if (toperatingDayDeviance == null)
            {
                return NotFound();
            }

            _context.ToperatingDayDeviance.Remove(toperatingDayDeviance);
            await _context.SaveChangesAsync();

            return toperatingDayDeviance;
        }

        private bool ToperatingDayDevianceExists(long id)
        {
            return _context.ToperatingDayDeviance.Any(e => e.ToperatingDayDevianceId == id);
        }
    }
}
