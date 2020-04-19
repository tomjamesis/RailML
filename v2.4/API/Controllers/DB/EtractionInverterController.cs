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
    public class EtractionInverterController : ControllerBase
    {
        private readonly DBContext _context;

        public EtractionInverterController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtractionInverter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtractionInverter>>> GetEtractionInverter()
        {
            return await _context.EtractionInverter.ToListAsync();
        }

        // GET: api/EtractionInverter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtractionInverter>> GetEtractionInverter(short id)
        {
            var etractionInverter = await _context.EtractionInverter.FindAsync(id);

            if (etractionInverter == null)
            {
                return NotFound();
            }

            return etractionInverter;
        }

        // PUT: api/EtractionInverter/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtractionInverter(short id, EtractionInverter etractionInverter)
        {
            if (id != etractionInverter.EtractionInverterId)
            {
                return BadRequest();
            }

            _context.Entry(etractionInverter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtractionInverterExists(id))
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

        // POST: api/EtractionInverter
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtractionInverter>> PostEtractionInverter(EtractionInverter etractionInverter)
        {
            _context.EtractionInverter.Add(etractionInverter);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtractionInverterExists(etractionInverter.EtractionInverterId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtractionInverter", new { id = etractionInverter.EtractionInverterId }, etractionInverter);
        }

        // DELETE: api/EtractionInverter/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtractionInverter>> DeleteEtractionInverter(short id)
        {
            var etractionInverter = await _context.EtractionInverter.FindAsync(id);
            if (etractionInverter == null)
            {
                return NotFound();
            }

            _context.EtractionInverter.Remove(etractionInverter);
            await _context.SaveChangesAsync();

            return etractionInverter;
        }

        private bool EtractionInverterExists(short id)
        {
            return _context.EtractionInverter.Any(e => e.EtractionInverterId == id);
        }
    }
}
