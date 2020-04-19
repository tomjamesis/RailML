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
    public class TlaxDirectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TlaxDirectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TlaxDirection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TlaxDirection>>> GetTlaxDirection()
        {
            return await _context.TlaxDirection.ToListAsync();
        }

        // GET: api/TlaxDirection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TlaxDirection>> GetTlaxDirection(byte id)
        {
            var tlaxDirection = await _context.TlaxDirection.FindAsync(id);

            if (tlaxDirection == null)
            {
                return NotFound();
            }

            return tlaxDirection;
        }

        // PUT: api/TlaxDirection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTlaxDirection(byte id, TlaxDirection tlaxDirection)
        {
            if (id != tlaxDirection.TlaxDirectionId)
            {
                return BadRequest();
            }

            _context.Entry(tlaxDirection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TlaxDirectionExists(id))
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

        // POST: api/TlaxDirection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TlaxDirection>> PostTlaxDirection(TlaxDirection tlaxDirection)
        {
            _context.TlaxDirection.Add(tlaxDirection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TlaxDirectionExists(tlaxDirection.TlaxDirectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTlaxDirection", new { id = tlaxDirection.TlaxDirectionId }, tlaxDirection);
        }

        // DELETE: api/TlaxDirection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TlaxDirection>> DeleteTlaxDirection(byte id)
        {
            var tlaxDirection = await _context.TlaxDirection.FindAsync(id);
            if (tlaxDirection == null)
            {
                return NotFound();
            }

            _context.TlaxDirection.Remove(tlaxDirection);
            await _context.SaveChangesAsync();

            return tlaxDirection;
        }

        private bool TlaxDirectionExists(byte id)
        {
            return _context.TlaxDirection.Any(e => e.TlaxDirectionId == id);
        }
    }
}
