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
    public class TbasePlacedElementController : ControllerBase
    {
        private readonly DBContext _context;

        public TbasePlacedElementController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TbasePlacedElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbasePlacedElement>>> GetTbasePlacedElement()
        {
            return await _context.TbasePlacedElement.ToListAsync();
        }

        // GET: api/TbasePlacedElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbasePlacedElement>> GetTbasePlacedElement(short id)
        {
            var tbasePlacedElement = await _context.TbasePlacedElement.FindAsync(id);

            if (tbasePlacedElement == null)
            {
                return NotFound();
            }

            return tbasePlacedElement;
        }

        // PUT: api/TbasePlacedElement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbasePlacedElement(short id, TbasePlacedElement tbasePlacedElement)
        {
            if (id != tbasePlacedElement.TbasePlacedElementId)
            {
                return BadRequest();
            }

            _context.Entry(tbasePlacedElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbasePlacedElementExists(id))
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

        // POST: api/TbasePlacedElement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbasePlacedElement>> PostTbasePlacedElement(TbasePlacedElement tbasePlacedElement)
        {
            _context.TbasePlacedElement.Add(tbasePlacedElement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbasePlacedElementExists(tbasePlacedElement.TbasePlacedElementId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbasePlacedElement", new { id = tbasePlacedElement.TbasePlacedElementId }, tbasePlacedElement);
        }

        // DELETE: api/TbasePlacedElement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbasePlacedElement>> DeleteTbasePlacedElement(short id)
        {
            var tbasePlacedElement = await _context.TbasePlacedElement.FindAsync(id);
            if (tbasePlacedElement == null)
            {
                return NotFound();
            }

            _context.TbasePlacedElement.Remove(tbasePlacedElement);
            await _context.SaveChangesAsync();

            return tbasePlacedElement;
        }

        private bool TbasePlacedElementExists(short id)
        {
            return _context.TbasePlacedElement.Any(e => e.TbasePlacedElementId == id);
        }
    }
}
