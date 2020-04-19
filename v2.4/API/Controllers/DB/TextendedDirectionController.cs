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
    public class TextendedDirectionController : ControllerBase
    {
        private readonly DBContext _context;

        public TextendedDirectionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TextendedDirection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TextendedDirection>>> GetTextendedDirection()
        {
            return await _context.TextendedDirection.ToListAsync();
        }

        // GET: api/TextendedDirection/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TextendedDirection>> GetTextendedDirection(byte id)
        {
            var textendedDirection = await _context.TextendedDirection.FindAsync(id);

            if (textendedDirection == null)
            {
                return NotFound();
            }

            return textendedDirection;
        }

        // PUT: api/TextendedDirection/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTextendedDirection(byte id, TextendedDirection textendedDirection)
        {
            if (id != textendedDirection.TextendedDirectionId)
            {
                return BadRequest();
            }

            _context.Entry(textendedDirection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TextendedDirectionExists(id))
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

        // POST: api/TextendedDirection
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TextendedDirection>> PostTextendedDirection(TextendedDirection textendedDirection)
        {
            _context.TextendedDirection.Add(textendedDirection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TextendedDirectionExists(textendedDirection.TextendedDirectionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTextendedDirection", new { id = textendedDirection.TextendedDirectionId }, textendedDirection);
        }

        // DELETE: api/TextendedDirection/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TextendedDirection>> DeleteTextendedDirection(byte id)
        {
            var textendedDirection = await _context.TextendedDirection.FindAsync(id);
            if (textendedDirection == null)
            {
                return NotFound();
            }

            _context.TextendedDirection.Remove(textendedDirection);
            await _context.SaveChangesAsync();

            return textendedDirection;
        }

        private bool TextendedDirectionExists(byte id)
        {
            return _context.TextendedDirection.Any(e => e.TextendedDirectionId == id);
        }
    }
}
