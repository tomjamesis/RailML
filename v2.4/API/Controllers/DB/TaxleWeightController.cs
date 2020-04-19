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
    public class TaxleWeightController : ControllerBase
    {
        private readonly DBContext _context;

        public TaxleWeightController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TaxleWeight
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaxleWeight>>> GetTaxleWeight()
        {
            return await _context.TaxleWeight.ToListAsync();
        }

        // GET: api/TaxleWeight/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaxleWeight>> GetTaxleWeight(long id)
        {
            var taxleWeight = await _context.TaxleWeight.FindAsync(id);

            if (taxleWeight == null)
            {
                return NotFound();
            }

            return taxleWeight;
        }

        // PUT: api/TaxleWeight/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaxleWeight(long id, TaxleWeight taxleWeight)
        {
            if (id != taxleWeight.TaxleWeightId)
            {
                return BadRequest();
            }

            _context.Entry(taxleWeight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaxleWeightExists(id))
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

        // POST: api/TaxleWeight
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TaxleWeight>> PostTaxleWeight(TaxleWeight taxleWeight)
        {
            _context.TaxleWeight.Add(taxleWeight);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TaxleWeightExists(taxleWeight.TaxleWeightId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTaxleWeight", new { id = taxleWeight.TaxleWeightId }, taxleWeight);
        }

        // DELETE: api/TaxleWeight/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaxleWeight>> DeleteTaxleWeight(long id)
        {
            var taxleWeight = await _context.TaxleWeight.FindAsync(id);
            if (taxleWeight == null)
            {
                return NotFound();
            }

            _context.TaxleWeight.Remove(taxleWeight);
            await _context.SaveChangesAsync();

            return taxleWeight;
        }

        private bool TaxleWeightExists(long id)
        {
            return _context.TaxleWeight.Any(e => e.TaxleWeightId == id);
        }
    }
}
