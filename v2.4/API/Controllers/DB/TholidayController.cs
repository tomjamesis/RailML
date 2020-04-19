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
    public class TholidayController : ControllerBase
    {
        private readonly DBContext _context;

        public TholidayController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tholiday
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tholiday>>> GetTholiday()
        {
            return await _context.Tholiday.ToListAsync();
        }

        // GET: api/Tholiday/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tholiday>> GetTholiday(long id)
        {
            var tholiday = await _context.Tholiday.FindAsync(id);

            if (tholiday == null)
            {
                return NotFound();
            }

            return tholiday;
        }

        // PUT: api/Tholiday/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTholiday(long id, Tholiday tholiday)
        {
            if (id != tholiday.TholidayId)
            {
                return BadRequest();
            }

            _context.Entry(tholiday).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TholidayExists(id))
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

        // POST: api/Tholiday
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tholiday>> PostTholiday(Tholiday tholiday)
        {
            _context.Tholiday.Add(tholiday);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TholidayExists(tholiday.TholidayId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTholiday", new { id = tholiday.TholidayId }, tholiday);
        }

        // DELETE: api/Tholiday/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tholiday>> DeleteTholiday(long id)
        {
            var tholiday = await _context.Tholiday.FindAsync(id);
            if (tholiday == null)
            {
                return NotFound();
            }

            _context.Tholiday.Remove(tholiday);
            await _context.SaveChangesAsync();

            return tholiday;
        }

        private bool TholidayExists(long id)
        {
            return _context.Tholiday.Any(e => e.TholidayId == id);
        }
    }
}
