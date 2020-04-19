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
    public class TimetableController : ControllerBase
    {
        private readonly DBContext _context;

        public TimetableController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Timetable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Timetable>>> GetTimetable()
        {
            return await _context.Timetable.ToListAsync();
        }

        // GET: api/Timetable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Timetable>> GetTimetable(short id)
        {
            var timetable = await _context.Timetable.FindAsync(id);

            if (timetable == null)
            {
                return NotFound();
            }

            return timetable;
        }

        // PUT: api/Timetable/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimetable(short id, Timetable timetable)
        {
            if (id != timetable.TimetableId)
            {
                return BadRequest();
            }

            _context.Entry(timetable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimetableExists(id))
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

        // POST: api/Timetable
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Timetable>> PostTimetable(Timetable timetable)
        {
            _context.Timetable.Add(timetable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TimetableExists(timetable.TimetableId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTimetable", new { id = timetable.TimetableId }, timetable);
        }

        // DELETE: api/Timetable/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Timetable>> DeleteTimetable(short id)
        {
            var timetable = await _context.Timetable.FindAsync(id);
            if (timetable == null)
            {
                return NotFound();
            }

            _context.Timetable.Remove(timetable);
            await _context.SaveChangesAsync();

            return timetable;
        }

        private bool TimetableExists(short id)
        {
            return _context.Timetable.Any(e => e.TimetableId == id);
        }
    }
}
