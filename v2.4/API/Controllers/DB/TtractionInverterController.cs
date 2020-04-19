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
    public class TtractionInverterController : ControllerBase
    {
        private readonly DBContext _context;

        public TtractionInverterController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TtractionInverter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TtractionInverter>>> GetTtractionInverter()
        {
            return await _context.TtractionInverter.ToListAsync();
        }

        // GET: api/TtractionInverter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TtractionInverter>> GetTtractionInverter(long id)
        {
            var ttractionInverter = await _context.TtractionInverter.FindAsync(id);

            if (ttractionInverter == null)
            {
                return NotFound();
            }

            return ttractionInverter;
        }

        // PUT: api/TtractionInverter/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTtractionInverter(long id, TtractionInverter ttractionInverter)
        {
            if (id != ttractionInverter.TtractionInverterId)
            {
                return BadRequest();
            }

            _context.Entry(ttractionInverter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TtractionInverterExists(id))
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

        // POST: api/TtractionInverter
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TtractionInverter>> PostTtractionInverter(TtractionInverter ttractionInverter)
        {
            _context.TtractionInverter.Add(ttractionInverter);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TtractionInverterExists(ttractionInverter.TtractionInverterId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTtractionInverter", new { id = ttractionInverter.TtractionInverterId }, ttractionInverter);
        }

        // DELETE: api/TtractionInverter/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TtractionInverter>> DeleteTtractionInverter(long id)
        {
            var ttractionInverter = await _context.TtractionInverter.FindAsync(id);
            if (ttractionInverter == null)
            {
                return NotFound();
            }

            _context.TtractionInverter.Remove(ttractionInverter);
            await _context.SaveChangesAsync();

            return ttractionInverter;
        }

        private bool TtractionInverterExists(long id)
        {
            return _context.TtractionInverter.Any(e => e.TtractionInverterId == id);
        }
    }
}
