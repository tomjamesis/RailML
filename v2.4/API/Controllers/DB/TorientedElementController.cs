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
    public class TorientedElementController : ControllerBase
    {
        private readonly DBContext _context;

        public TorientedElementController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TorientedElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TorientedElement>>> GetTorientedElement()
        {
            return await _context.TorientedElement.ToListAsync();
        }

        // GET: api/TorientedElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TorientedElement>> GetTorientedElement(short id)
        {
            var torientedElement = await _context.TorientedElement.FindAsync(id);

            if (torientedElement == null)
            {
                return NotFound();
            }

            return torientedElement;
        }

        // PUT: api/TorientedElement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTorientedElement(short id, TorientedElement torientedElement)
        {
            if (id != torientedElement.TorientedElementId)
            {
                return BadRequest();
            }

            _context.Entry(torientedElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TorientedElementExists(id))
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

        // POST: api/TorientedElement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TorientedElement>> PostTorientedElement(TorientedElement torientedElement)
        {
            _context.TorientedElement.Add(torientedElement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TorientedElementExists(torientedElement.TorientedElementId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTorientedElement", new { id = torientedElement.TorientedElementId }, torientedElement);
        }

        // DELETE: api/TorientedElement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TorientedElement>> DeleteTorientedElement(short id)
        {
            var torientedElement = await _context.TorientedElement.FindAsync(id);
            if (torientedElement == null)
            {
                return NotFound();
            }

            _context.TorientedElement.Remove(torientedElement);
            await _context.SaveChangesAsync();

            return torientedElement;
        }

        private bool TorientedElementExists(short id)
        {
            return _context.TorientedElement.Any(e => e.TorientedElementId == id);
        }
    }
}
