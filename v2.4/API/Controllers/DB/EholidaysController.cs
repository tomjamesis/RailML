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
    public class EholidaysController : ControllerBase
    {
        private readonly DBContext _context;

        public EholidaysController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Eholidays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eholidays>>> GetEholidays()
        {
            return await _context.Eholidays.ToListAsync();
        }

        // GET: api/Eholidays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eholidays>> GetEholidays(long id)
        {
            var eholidays = await _context.Eholidays.FindAsync(id);

            if (eholidays == null)
            {
                return NotFound();
            }

            return eholidays;
        }

        // PUT: api/Eholidays/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEholidays(long id, Eholidays eholidays)
        {
            if (id != eholidays.EholidaysId)
            {
                return BadRequest();
            }

            _context.Entry(eholidays).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EholidaysExists(id))
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

        // POST: api/Eholidays
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Eholidays>> PostEholidays(Eholidays eholidays)
        {
            _context.Eholidays.Add(eholidays);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EholidaysExists(eholidays.EholidaysId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEholidays", new { id = eholidays.EholidaysId }, eholidays);
        }

        // DELETE: api/Eholidays/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Eholidays>> DeleteEholidays(long id)
        {
            var eholidays = await _context.Eholidays.FindAsync(id);
            if (eholidays == null)
            {
                return NotFound();
            }

            _context.Eholidays.Remove(eholidays);
            await _context.SaveChangesAsync();

            return eholidays;
        }

        private bool EholidaysExists(long id)
        {
            return _context.Eholidays.Any(e => e.EholidaysId == id);
        }
    }
}
