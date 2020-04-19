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
    public class TstrictDirectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TstrictDirectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstrictDirection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstrictDirection>>> GetTstrictDirection()
        {
            return await _context.TstrictDirection.ToListAsync();
        }

        // GET: api/TstrictDirection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstrictDirection>> GetTstrictDirection(byte id)
        {
            var tstrictDirection = await _context.TstrictDirection.FindAsync(id);

            if (tstrictDirection == null)
            {
                return NotFound();
            }

            return tstrictDirection;
        }

        // PUT: api/TstrictDirection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstrictDirection(byte id, TstrictDirection tstrictDirection)
        {
            if (id != tstrictDirection.TstrictDirectionId)
            {
                return BadRequest();
            }

            _context.Entry(tstrictDirection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstrictDirectionExists(id))
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

        // POST: api/TstrictDirection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstrictDirection>> PostTstrictDirection(TstrictDirection tstrictDirection)
        {
            _context.TstrictDirection.Add(tstrictDirection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstrictDirectionExists(tstrictDirection.TstrictDirectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstrictDirection", new { id = tstrictDirection.TstrictDirectionId }, tstrictDirection);
        }

        // DELETE: api/TstrictDirection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstrictDirection>> DeleteTstrictDirection(byte id)
        {
            var tstrictDirection = await _context.TstrictDirection.FindAsync(id);
            if (tstrictDirection == null)
            {
                return NotFound();
            }

            _context.TstrictDirection.Remove(tstrictDirection);
            await _context.SaveChangesAsync();

            return tstrictDirection;
        }

        private bool TstrictDirectionExists(byte id)
        {
            return _context.TstrictDirection.Any(e => e.TstrictDirectionId == id);
        }
    }
}
