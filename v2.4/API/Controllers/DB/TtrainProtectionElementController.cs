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
    public class TtrainProtectionElementController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainProtectionElementController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainProtectionElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainProtectionElement>>> GetTtrainProtectionElement()
        {
            return await _context.TtrainProtectionElement.ToListAsync();
        }

        // GET: api/TtrainProtectionElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainProtectionElement>> GetTtrainProtectionElement(short id)
        {
            var ttrainProtectionElement = await _context.TtrainProtectionElement.FindAsync(id);

            if (ttrainProtectionElement == null)
            {
                return NotFound();
            }

            return ttrainProtectionElement;
        }

        // PUT: api/TtrainProtectionElement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainProtectionElement(short id, TtrainProtectionElement ttrainProtectionElement)
        {
            if (id != ttrainProtectionElement.TtrainProtectionElementId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainProtectionElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainProtectionElementExists(id))
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

        // POST: api/TtrainProtectionElement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainProtectionElement>> PostTtrainProtectionElement(TtrainProtectionElement ttrainProtectionElement)
        {
            _context.TtrainProtectionElement.Add(ttrainProtectionElement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainProtectionElementExists(ttrainProtectionElement.TtrainProtectionElementId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainProtectionElement", new { id = ttrainProtectionElement.TtrainProtectionElementId }, ttrainProtectionElement);
        }

        // DELETE: api/TtrainProtectionElement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainProtectionElement>> DeleteTtrainProtectionElement(short id)
        {
            var ttrainProtectionElement = await _context.TtrainProtectionElement.FindAsync(id);
            if (ttrainProtectionElement == null)
            {
                return NotFound();
            }

            _context.TtrainProtectionElement.Remove(ttrainProtectionElement);
            await _context.SaveChangesAsync();

            return ttrainProtectionElement;
        }

        private bool TtrainProtectionElementExists(short id)
        {
            return _context.TtrainProtectionElement.Any(e => e.TtrainProtectionElementId == id);
        }
    }
}
