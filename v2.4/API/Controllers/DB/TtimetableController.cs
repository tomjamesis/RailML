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
    public class TtimetableController : ControllerBase
    {
        private readonly DBContext _context;

        public TtimetableController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ttimetable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ttimetable>>> GetTtimetable()
        {
            return await _context.Ttimetable.ToListAsync();
        }

        // GET: api/Ttimetable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ttimetable>> GetTtimetable(short id)
        {
            var ttimetable = await _context.Ttimetable.FindAsync(id);

            if (ttimetable == null)
            {
                return NotFound();
            }

            return ttimetable;
        }

        // PUT: api/Ttimetable/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtimetable(short id, Ttimetable ttimetable)
        {
            if (id != ttimetable.TtimetableId)
            {
                return BadRequest();
            }

            _context.Entry(ttimetable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtimetableExists(id))
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

        // POST: api/Ttimetable
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ttimetable>> PostTtimetable(Ttimetable ttimetable)
        {
            _context.Ttimetable.Add(ttimetable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtimetableExists(ttimetable.TtimetableId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtimetable", new { id = ttimetable.TtimetableId }, ttimetable);
        }

        // DELETE: api/Ttimetable/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ttimetable>> DeleteTtimetable(short id)
        {
            var ttimetable = await _context.Ttimetable.FindAsync(id);
            if (ttimetable == null)
            {
                return NotFound();
            }

            _context.Ttimetable.Remove(ttimetable);
            await _context.SaveChangesAsync();

            return ttimetable;
        }

        private bool TtimetableExists(short id)
        {
            return _context.Ttimetable.Any(e => e.TtimetableId == id);
        }
    }
}
