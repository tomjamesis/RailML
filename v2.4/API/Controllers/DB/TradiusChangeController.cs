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
    public class TradiusChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TradiusChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TradiusChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TradiusChange>>> GetTradiusChange()
        {
            return await _context.TradiusChange.ToListAsync();
        }

        // GET: api/TradiusChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TradiusChange>> GetTradiusChange(short id)
        {
            var tradiusChange = await _context.TradiusChange.FindAsync(id);

            if (tradiusChange == null)
            {
                return NotFound();
            }

            return tradiusChange;
        }

        // PUT: api/TradiusChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTradiusChange(short id, TradiusChange tradiusChange)
        {
            if (id != tradiusChange.TradiusChangeId)
            {
                return BadRequest();
            }

            _context.Entry(tradiusChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TradiusChangeExists(id))
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

        // POST: api/TradiusChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TradiusChange>> PostTradiusChange(TradiusChange tradiusChange)
        {
            _context.TradiusChange.Add(tradiusChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TradiusChangeExists(tradiusChange.TradiusChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTradiusChange", new { id = tradiusChange.TradiusChangeId }, tradiusChange);
        }

        // DELETE: api/TradiusChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TradiusChange>> DeleteTradiusChange(short id)
        {
            var tradiusChange = await _context.TradiusChange.FindAsync(id);
            if (tradiusChange == null)
            {
                return NotFound();
            }

            _context.TradiusChange.Remove(tradiusChange);
            await _context.SaveChangesAsync();

            return tradiusChange;
        }

        private bool TradiusChangeExists(short id)
        {
            return _context.TradiusChange.Any(e => e.TradiusChangeId == id);
        }
    }
}
