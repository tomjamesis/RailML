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
    public class TaxleWeightChangeController : ControllerBase
    {
        private readonly DBContext _context;

        public TaxleWeightChangeController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TaxleWeightChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaxleWeightChange>>> GetTaxleWeightChange()
        {
            return await _context.TaxleWeightChange.ToListAsync();
        }

        // GET: api/TaxleWeightChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaxleWeightChange>> GetTaxleWeightChange(short id)
        {
            var taxleWeightChange = await _context.TaxleWeightChange.FindAsync(id);

            if (taxleWeightChange == null)
            {
                return NotFound();
            }

            return taxleWeightChange;
        }

        // PUT: api/TaxleWeightChange/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaxleWeightChange(short id, TaxleWeightChange taxleWeightChange)
        {
            if (id != taxleWeightChange.TaxleWeightChangeId)
            {
                return BadRequest();
            }

            _context.Entry(taxleWeightChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaxleWeightChangeExists(id))
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

        // POST: api/TaxleWeightChange
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TaxleWeightChange>> PostTaxleWeightChange(TaxleWeightChange taxleWeightChange)
        {
            _context.TaxleWeightChange.Add(taxleWeightChange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TaxleWeightChangeExists(taxleWeightChange.TaxleWeightChangeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTaxleWeightChange", new { id = taxleWeightChange.TaxleWeightChangeId }, taxleWeightChange);
        }

        // DELETE: api/TaxleWeightChange/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaxleWeightChange>> DeleteTaxleWeightChange(short id)
        {
            var taxleWeightChange = await _context.TaxleWeightChange.FindAsync(id);
            if (taxleWeightChange == null)
            {
                return NotFound();
            }

            _context.TaxleWeightChange.Remove(taxleWeightChange);
            await _context.SaveChangesAsync();

            return taxleWeightChange;
        }

        private bool TaxleWeightChangeExists(short id)
        {
            return _context.TaxleWeightChange.Any(e => e.TaxleWeightChangeId == id);
        }
    }
}
