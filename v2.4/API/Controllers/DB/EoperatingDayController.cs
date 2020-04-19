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
    public class EoperatingDayController : ControllerBase
    {
        private readonly DBContext _context;

        public EoperatingDayController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EoperatingDay
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EoperatingDay>>> GetEoperatingDay()
        {
            return await _context.EoperatingDay.ToListAsync();
        }

        // GET: api/EoperatingDay/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EoperatingDay>> GetEoperatingDay(short id)
        {
            var eoperatingDay = await _context.EoperatingDay.FindAsync(id);

            if (eoperatingDay == null)
            {
                return NotFound();
            }

            return eoperatingDay;
        }

        // PUT: api/EoperatingDay/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEoperatingDay(short id, EoperatingDay eoperatingDay)
        {
            if (id != eoperatingDay.EoperatingDayId)
            {
                return BadRequest();
            }

            _context.Entry(eoperatingDay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EoperatingDayExists(id))
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

        // POST: api/EoperatingDay
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EoperatingDay>> PostEoperatingDay(EoperatingDay eoperatingDay)
        {
            _context.EoperatingDay.Add(eoperatingDay);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EoperatingDayExists(eoperatingDay.EoperatingDayId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEoperatingDay", new { id = eoperatingDay.EoperatingDayId }, eoperatingDay);
        }

        // DELETE: api/EoperatingDay/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EoperatingDay>> DeleteEoperatingDay(short id)
        {
            var eoperatingDay = await _context.EoperatingDay.FindAsync(id);
            if (eoperatingDay == null)
            {
                return NotFound();
            }

            _context.EoperatingDay.Remove(eoperatingDay);
            await _context.SaveChangesAsync();

            return eoperatingDay;
        }

        private bool EoperatingDayExists(short id)
        {
            return _context.EoperatingDay.Any(e => e.EoperatingDayId == id);
        }
    }
}
