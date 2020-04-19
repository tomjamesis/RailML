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
    public class DateController : ControllerBase
    {
        private readonly DBContext _context;

        public DateController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Date
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Date>>> GetDate()
        {
            return await _context.Date.ToListAsync();
        }

        // GET: api/Date/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Date>> GetDate(short id)
        {
            var date = await _context.Date.FindAsync(id);

            if (date == null)
            {
                return NotFound();
            }

            return date;
        }

        // PUT: api/Date/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDate(short id, Date date)
        {
            if (id != date.DateId)
            {
                return BadRequest();
            }

            _context.Entry(date).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DateExists(id))
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

        // POST: api/Date
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Date>> PostDate(Date date)
        {
            _context.Date.Add(date);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DateExists(date.DateId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDate", new { id = date.DateId }, date);
        }

        // DELETE: api/Date/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Date>> DeleteDate(short id)
        {
            var date = await _context.Date.FindAsync(id);
            if (date == null)
            {
                return NotFound();
            }

            _context.Date.Remove(date);
            await _context.SaveChangesAsync();

            return date;
        }

        private bool DateExists(short id)
        {
            return _context.Date.Any(e => e.DateId == id);
        }
    }
}
