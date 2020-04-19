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
    public class TruleCodeElementController : ControllerBase
    {
        private readonly DBContext _context;

        public TruleCodeElementController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TruleCodeElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TruleCodeElement>>> GetTruleCodeElement()
        {
            return await _context.TruleCodeElement.ToListAsync();
        }

        // GET: api/TruleCodeElement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TruleCodeElement>> GetTruleCodeElement(short id)
        {
            var truleCodeElement = await _context.TruleCodeElement.FindAsync(id);

            if (truleCodeElement == null)
            {
                return NotFound();
            }

            return truleCodeElement;
        }

        // PUT: api/TruleCodeElement/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTruleCodeElement(short id, TruleCodeElement truleCodeElement)
        {
            if (id != truleCodeElement.TruleCodeElementId)
            {
                return BadRequest();
            }

            _context.Entry(truleCodeElement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TruleCodeElementExists(id))
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

        // POST: api/TruleCodeElement
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TruleCodeElement>> PostTruleCodeElement(TruleCodeElement truleCodeElement)
        {
            _context.TruleCodeElement.Add(truleCodeElement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TruleCodeElementExists(truleCodeElement.TruleCodeElementId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTruleCodeElement", new { id = truleCodeElement.TruleCodeElementId }, truleCodeElement);
        }

        // DELETE: api/TruleCodeElement/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TruleCodeElement>> DeleteTruleCodeElement(short id)
        {
            var truleCodeElement = await _context.TruleCodeElement.FindAsync(id);
            if (truleCodeElement == null)
            {
                return NotFound();
            }

            _context.TruleCodeElement.Remove(truleCodeElement);
            await _context.SaveChangesAsync();

            return truleCodeElement;
        }

        private bool TruleCodeElementExists(short id)
        {
            return _context.TruleCodeElement.Any(e => e.TruleCodeElementId == id);
        }
    }
}
