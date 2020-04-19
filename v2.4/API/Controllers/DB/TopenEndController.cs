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
    public class TopenEndController : ControllerBase
    {
        private readonly DBContext _context;

        public TopenEndController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TopenEnd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopenEnd>>> GetTopenEnd()
        {
            return await _context.TopenEnd.ToListAsync();
        }

        // GET: api/TopenEnd/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TopenEnd>> GetTopenEnd(short id)
        {
            var topenEnd = await _context.TopenEnd.FindAsync(id);

            if (topenEnd == null)
            {
                return NotFound();
            }

            return topenEnd;
        }

        // PUT: api/TopenEnd/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTopenEnd(short id, TopenEnd topenEnd)
        {
            if (id != topenEnd.TopenEndId)
            {
                return BadRequest();
            }

            _context.Entry(topenEnd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TopenEndExists(id))
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

        // POST: api/TopenEnd
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TopenEnd>> PostTopenEnd(TopenEnd topenEnd)
        {
            _context.TopenEnd.Add(topenEnd);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TopenEndExists(topenEnd.TopenEndId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTopenEnd", new { id = topenEnd.TopenEndId }, topenEnd);
        }

        // DELETE: api/TopenEnd/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TopenEnd>> DeleteTopenEnd(short id)
        {
            var topenEnd = await _context.TopenEnd.FindAsync(id);
            if (topenEnd == null)
            {
                return NotFound();
            }

            _context.TopenEnd.Remove(topenEnd);
            await _context.SaveChangesAsync();

            return topenEnd;
        }

        private bool TopenEndExists(short id)
        {
            return _context.TopenEnd.Any(e => e.TopenEndId == id);
        }
    }
}
