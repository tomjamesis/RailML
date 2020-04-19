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
    public class TsideController : ControllerBase
    {
        private readonly DBContext _context;

        public TsideController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tside
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tside>>> GetTside()
        {
            return await _context.Tside.ToListAsync();
        }

        // GET: api/Tside/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tside>> GetTside(byte id)
        {
            var tside = await _context.Tside.FindAsync(id);

            if (tside == null)
            {
                return NotFound();
            }

            return tside;
        }

        // PUT: api/Tside/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTside(byte id, Tside tside)
        {
            if (id != tside.TsideId)
            {
                return BadRequest();
            }

            _context.Entry(tside).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TsideExists(id))
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

        // POST: api/Tside
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tside>> PostTside(Tside tside)
        {
            _context.Tside.Add(tside);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TsideExists(tside.TsideId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTside", new { id = tside.TsideId }, tside);
        }

        // DELETE: api/Tside/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tside>> DeleteTside(byte id)
        {
            var tside = await _context.Tside.FindAsync(id);
            if (tside == null)
            {
                return NotFound();
            }

            _context.Tside.Remove(tside);
            await _context.SaveChangesAsync();

            return tside;
        }

        private bool TsideExists(byte id)
        {
            return _context.Tside.Any(e => e.TsideId == id);
        }
    }
}
