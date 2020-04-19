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
    public class ToperatingDayController : ControllerBase
    {
        private readonly DBContext _context;

        public ToperatingDayController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ToperatingDay
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToperatingDay>>> GetToperatingDay()
        {
            return await _context.ToperatingDay.ToListAsync();
        }

        // GET: api/ToperatingDay/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToperatingDay>> GetToperatingDay(long id)
        {
            var toperatingDay = await _context.ToperatingDay.FindAsync(id);

            if (toperatingDay == null)
            {
                return NotFound();
            }

            return toperatingDay;
        }

        // PUT: api/ToperatingDay/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToperatingDay(long id, ToperatingDay toperatingDay)
        {
            if (id != toperatingDay.ToperatingDayId)
            {
                return BadRequest();
            }

            _context.Entry(toperatingDay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToperatingDayExists(id))
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

        // POST: api/ToperatingDay
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ToperatingDay>> PostToperatingDay(ToperatingDay toperatingDay)
        {
            _context.ToperatingDay.Add(toperatingDay);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ToperatingDayExists(toperatingDay.ToperatingDayId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetToperatingDay", new { id = toperatingDay.ToperatingDayId }, toperatingDay);
        }

        // DELETE: api/ToperatingDay/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToperatingDay>> DeleteToperatingDay(long id)
        {
            var toperatingDay = await _context.ToperatingDay.FindAsync(id);
            if (toperatingDay == null)
            {
                return NotFound();
            }

            _context.ToperatingDay.Remove(toperatingDay);
            await _context.SaveChangesAsync();

            return toperatingDay;
        }

        private bool ToperatingDayExists(long id)
        {
            return _context.ToperatingDay.Any(e => e.ToperatingDayId == id);
        }
    }
}
