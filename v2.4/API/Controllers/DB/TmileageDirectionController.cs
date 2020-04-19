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
    public class TmileageDirectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TmileageDirectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TmileageDirection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TmileageDirection>>> GetTmileageDirection()
        {
            return await _context.TmileageDirection.ToListAsync();
        }

        // GET: api/TmileageDirection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TmileageDirection>> GetTmileageDirection(byte id)
        {
            var tmileageDirection = await _context.TmileageDirection.FindAsync(id);

            if (tmileageDirection == null)
            {
                return NotFound();
            }

            return tmileageDirection;
        }

        // PUT: api/TmileageDirection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTmileageDirection(byte id, TmileageDirection tmileageDirection)
        {
            if (id != tmileageDirection.TmileageDirectionId)
            {
                return BadRequest();
            }

            _context.Entry(tmileageDirection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TmileageDirectionExists(id))
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

        // POST: api/TmileageDirection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TmileageDirection>> PostTmileageDirection(TmileageDirection tmileageDirection)
        {
            _context.TmileageDirection.Add(tmileageDirection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TmileageDirectionExists(tmileageDirection.TmileageDirectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTmileageDirection", new { id = tmileageDirection.TmileageDirectionId }, tmileageDirection);
        }

        // DELETE: api/TmileageDirection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TmileageDirection>> DeleteTmileageDirection(byte id)
        {
            var tmileageDirection = await _context.TmileageDirection.FindAsync(id);
            if (tmileageDirection == null)
            {
                return NotFound();
            }

            _context.TmileageDirection.Remove(tmileageDirection);
            await _context.SaveChangesAsync();

            return tmileageDirection;
        }

        private bool TmileageDirectionExists(byte id)
        {
            return _context.TmileageDirection.Any(e => e.TmileageDirectionId == id);
        }
    }
}
