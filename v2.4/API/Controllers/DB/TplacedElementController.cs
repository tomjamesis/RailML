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
    public class TplacedElementController : ControllerBase
    {
        private readonly DBContext _context;

        public TplacedElementController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TplacedElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TplacedElement>>> GetTplacedElement()
        {
            return await _context.TplacedElement.ToListAsync();
        }

        // GET: api/TplacedElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TplacedElement>> GetTplacedElement(short id)
        {
            var tplacedElement = await _context.TplacedElement.FindAsync(id);

            if (tplacedElement == null)
            {
                return NotFound();
            }

            return tplacedElement;
        }

        // PUT: api/TplacedElement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTplacedElement(short id, TplacedElement tplacedElement)
        {
            if (id != tplacedElement.TplacedElementId)
            {
                return BadRequest();
            }

            _context.Entry(tplacedElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TplacedElementExists(id))
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

        // POST: api/TplacedElement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TplacedElement>> PostTplacedElement(TplacedElement tplacedElement)
        {
            _context.TplacedElement.Add(tplacedElement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TplacedElementExists(tplacedElement.TplacedElementId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTplacedElement", new { id = tplacedElement.TplacedElementId }, tplacedElement);
        }

        // DELETE: api/TplacedElement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TplacedElement>> DeleteTplacedElement(short id)
        {
            var tplacedElement = await _context.TplacedElement.FindAsync(id);
            if (tplacedElement == null)
            {
                return NotFound();
            }

            _context.TplacedElement.Remove(tplacedElement);
            await _context.SaveChangesAsync();

            return tplacedElement;
        }

        private bool TplacedElementExists(short id)
        {
            return _context.TplacedElement.Any(e => e.TplacedElementId == id);
        }
    }
}
