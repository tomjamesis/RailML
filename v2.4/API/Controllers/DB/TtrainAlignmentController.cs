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
    public class TtrainAlignmentController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainAlignmentController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainAlignment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainAlignment>>> GetTtrainAlignment()
        {
            return await _context.TtrainAlignment.ToListAsync();
        }

        // GET: api/TtrainAlignment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainAlignment>> GetTtrainAlignment(byte id)
        {
            var ttrainAlignment = await _context.TtrainAlignment.FindAsync(id);

            if (ttrainAlignment == null)
            {
                return NotFound();
            }

            return ttrainAlignment;
        }

        // PUT: api/TtrainAlignment/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainAlignment(byte id, TtrainAlignment ttrainAlignment)
        {
            if (id != ttrainAlignment.TtrainAlignmentId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainAlignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainAlignmentExists(id))
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

        // POST: api/TtrainAlignment
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainAlignment>> PostTtrainAlignment(TtrainAlignment ttrainAlignment)
        {
            _context.TtrainAlignment.Add(ttrainAlignment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainAlignmentExists(ttrainAlignment.TtrainAlignmentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainAlignment", new { id = ttrainAlignment.TtrainAlignmentId }, ttrainAlignment);
        }

        // DELETE: api/TtrainAlignment/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainAlignment>> DeleteTtrainAlignment(byte id)
        {
            var ttrainAlignment = await _context.TtrainAlignment.FindAsync(id);
            if (ttrainAlignment == null)
            {
                return NotFound();
            }

            _context.TtrainAlignment.Remove(ttrainAlignment);
            await _context.SaveChangesAsync();

            return ttrainAlignment;
        }

        private bool TtrainAlignmentExists(byte id)
        {
            return _context.TtrainAlignment.Any(e => e.TtrainAlignmentId == id);
        }
    }
}
