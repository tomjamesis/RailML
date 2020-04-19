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
    public class TtrainRadioAttributesController : ControllerBase
    {
        private readonly DBContext _context;

        public TtrainRadioAttributesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtrainRadioAttributes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtrainRadioAttributes>>> GetTtrainRadioAttributes()
        {
            return await _context.TtrainRadioAttributes.ToListAsync();
        }

        // GET: api/TtrainRadioAttributes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtrainRadioAttributes>> GetTtrainRadioAttributes(long id)
        {
            var ttrainRadioAttributes = await _context.TtrainRadioAttributes.FindAsync(id);

            if (ttrainRadioAttributes == null)
            {
                return NotFound();
            }

            return ttrainRadioAttributes;
        }

        // PUT: api/TtrainRadioAttributes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtrainRadioAttributes(long id, TtrainRadioAttributes ttrainRadioAttributes)
        {
            if (id != ttrainRadioAttributes.TtrainRadioAttributesId)
            {
                return BadRequest();
            }

            _context.Entry(ttrainRadioAttributes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtrainRadioAttributesExists(id))
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

        // POST: api/TtrainRadioAttributes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtrainRadioAttributes>> PostTtrainRadioAttributes(TtrainRadioAttributes ttrainRadioAttributes)
        {
            _context.TtrainRadioAttributes.Add(ttrainRadioAttributes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtrainRadioAttributesExists(ttrainRadioAttributes.TtrainRadioAttributesId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtrainRadioAttributes", new { id = ttrainRadioAttributes.TtrainRadioAttributesId }, ttrainRadioAttributes);
        }

        // DELETE: api/TtrainRadioAttributes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtrainRadioAttributes>> DeleteTtrainRadioAttributes(long id)
        {
            var ttrainRadioAttributes = await _context.TtrainRadioAttributes.FindAsync(id);
            if (ttrainRadioAttributes == null)
            {
                return NotFound();
            }

            _context.TtrainRadioAttributes.Remove(ttrainRadioAttributes);
            await _context.SaveChangesAsync();

            return ttrainRadioAttributes;
        }

        private bool TtrainRadioAttributesExists(long id)
        {
            return _context.TtrainRadioAttributes.Any(e => e.TtrainRadioAttributesId == id);
        }
    }
}
