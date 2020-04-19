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
    public class TdelimitedOrientedElementController : ControllerBase
    {
        private readonly DBContext _context;

        public TdelimitedOrientedElementController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TdelimitedOrientedElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdelimitedOrientedElement>>> GetTdelimitedOrientedElement()
        {
            return await _context.TdelimitedOrientedElement.ToListAsync();
        }

        // GET: api/TdelimitedOrientedElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TdelimitedOrientedElement>> GetTdelimitedOrientedElement(short id)
        {
            var tdelimitedOrientedElement = await _context.TdelimitedOrientedElement.FindAsync(id);

            if (tdelimitedOrientedElement == null)
            {
                return NotFound();
            }

            return tdelimitedOrientedElement;
        }

        // PUT: api/TdelimitedOrientedElement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdelimitedOrientedElement(short id, TdelimitedOrientedElement tdelimitedOrientedElement)
        {
            if (id != tdelimitedOrientedElement.TdelimitedOrientedElementId)
            {
                return BadRequest();
            }

            _context.Entry(tdelimitedOrientedElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdelimitedOrientedElementExists(id))
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

        // POST: api/TdelimitedOrientedElement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TdelimitedOrientedElement>> PostTdelimitedOrientedElement(TdelimitedOrientedElement tdelimitedOrientedElement)
        {
            _context.TdelimitedOrientedElement.Add(tdelimitedOrientedElement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TdelimitedOrientedElementExists(tdelimitedOrientedElement.TdelimitedOrientedElementId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTdelimitedOrientedElement", new { id = tdelimitedOrientedElement.TdelimitedOrientedElementId }, tdelimitedOrientedElement);
        }

        // DELETE: api/TdelimitedOrientedElement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TdelimitedOrientedElement>> DeleteTdelimitedOrientedElement(short id)
        {
            var tdelimitedOrientedElement = await _context.TdelimitedOrientedElement.FindAsync(id);
            if (tdelimitedOrientedElement == null)
            {
                return NotFound();
            }

            _context.TdelimitedOrientedElement.Remove(tdelimitedOrientedElement);
            await _context.SaveChangesAsync();

            return tdelimitedOrientedElement;
        }

        private bool TdelimitedOrientedElementExists(short id)
        {
            return _context.TdelimitedOrientedElement.Any(e => e.TdelimitedOrientedElementId == id);
        }
    }
}
