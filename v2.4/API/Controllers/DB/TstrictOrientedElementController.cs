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
    public class TstrictOrientedElementController : ControllerBase
    {
        private readonly DBContext _context;

        public TstrictOrientedElementController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TstrictOrientedElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TstrictOrientedElement>>> GetTstrictOrientedElement()
        {
            return await _context.TstrictOrientedElement.ToListAsync();
        }

        // GET: api/TstrictOrientedElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TstrictOrientedElement>> GetTstrictOrientedElement(short id)
        {
            var tstrictOrientedElement = await _context.TstrictOrientedElement.FindAsync(id);

            if (tstrictOrientedElement == null)
            {
                return NotFound();
            }

            return tstrictOrientedElement;
        }

        // PUT: api/TstrictOrientedElement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTstrictOrientedElement(short id, TstrictOrientedElement tstrictOrientedElement)
        {
            if (id != tstrictOrientedElement.TstrictOrientedElementId)
            {
                return BadRequest();
            }

            _context.Entry(tstrictOrientedElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TstrictOrientedElementExists(id))
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

        // POST: api/TstrictOrientedElement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TstrictOrientedElement>> PostTstrictOrientedElement(TstrictOrientedElement tstrictOrientedElement)
        {
            _context.TstrictOrientedElement.Add(tstrictOrientedElement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TstrictOrientedElementExists(tstrictOrientedElement.TstrictOrientedElementId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTstrictOrientedElement", new { id = tstrictOrientedElement.TstrictOrientedElementId }, tstrictOrientedElement);
        }

        // DELETE: api/TstrictOrientedElement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TstrictOrientedElement>> DeleteTstrictOrientedElement(short id)
        {
            var tstrictOrientedElement = await _context.TstrictOrientedElement.FindAsync(id);
            if (tstrictOrientedElement == null)
            {
                return NotFound();
            }

            _context.TstrictOrientedElement.Remove(tstrictOrientedElement);
            await _context.SaveChangesAsync();

            return tstrictOrientedElement;
        }

        private bool TstrictOrientedElementExists(short id)
        {
            return _context.TstrictOrientedElement.Any(e => e.TstrictOrientedElementId == id);
        }
    }
}
