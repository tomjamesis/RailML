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
    public class TdelimitedDirectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TdelimitedDirectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TdelimitedDirection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdelimitedDirection>>> GetTdelimitedDirection()
        {
            return await _context.TdelimitedDirection.ToListAsync();
        }

        // GET: api/TdelimitedDirection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TdelimitedDirection>> GetTdelimitedDirection(byte id)
        {
            var tdelimitedDirection = await _context.TdelimitedDirection.FindAsync(id);

            if (tdelimitedDirection == null)
            {
                return NotFound();
            }

            return tdelimitedDirection;
        }

        // PUT: api/TdelimitedDirection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdelimitedDirection(byte id, TdelimitedDirection tdelimitedDirection)
        {
            if (id != tdelimitedDirection.TdelimitedDirectionId)
            {
                return BadRequest();
            }

            _context.Entry(tdelimitedDirection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdelimitedDirectionExists(id))
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

        // POST: api/TdelimitedDirection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TdelimitedDirection>> PostTdelimitedDirection(TdelimitedDirection tdelimitedDirection)
        {
            _context.TdelimitedDirection.Add(tdelimitedDirection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TdelimitedDirectionExists(tdelimitedDirection.TdelimitedDirectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTdelimitedDirection", new { id = tdelimitedDirection.TdelimitedDirectionId }, tdelimitedDirection);
        }

        // DELETE: api/TdelimitedDirection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TdelimitedDirection>> DeleteTdelimitedDirection(byte id)
        {
            var tdelimitedDirection = await _context.TdelimitedDirection.FindAsync(id);
            if (tdelimitedDirection == null)
            {
                return NotFound();
            }

            _context.TdelimitedDirection.Remove(tdelimitedDirection);
            await _context.SaveChangesAsync();

            return tdelimitedDirection;
        }

        private bool TdelimitedDirectionExists(byte id)
        {
            return _context.TdelimitedDirection.Any(e => e.TdelimitedDirectionId == id);
        }
    }
}
