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
    public class EpneumaticCouplerController : ControllerBase
    {
        private readonly DBContext _context;

        public EpneumaticCouplerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EpneumaticCoupler
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EpneumaticCoupler>>> GetEpneumaticCoupler()
        {
            return await _context.EpneumaticCoupler.ToListAsync();
        }

        // GET: api/EpneumaticCoupler/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EpneumaticCoupler>> GetEpneumaticCoupler(short id)
        {
            var epneumaticCoupler = await _context.EpneumaticCoupler.FindAsync(id);

            if (epneumaticCoupler == null)
            {
                return NotFound();
            }

            return epneumaticCoupler;
        }

        // PUT: api/EpneumaticCoupler/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpneumaticCoupler(short id, EpneumaticCoupler epneumaticCoupler)
        {
            if (id != epneumaticCoupler.EpneumaticCouplerId)
            {
                return BadRequest();
            }

            _context.Entry(epneumaticCoupler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpneumaticCouplerExists(id))
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

        // POST: api/EpneumaticCoupler
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EpneumaticCoupler>> PostEpneumaticCoupler(EpneumaticCoupler epneumaticCoupler)
        {
            _context.EpneumaticCoupler.Add(epneumaticCoupler);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EpneumaticCouplerExists(epneumaticCoupler.EpneumaticCouplerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEpneumaticCoupler", new { id = epneumaticCoupler.EpneumaticCouplerId }, epneumaticCoupler);
        }

        // DELETE: api/EpneumaticCoupler/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EpneumaticCoupler>> DeleteEpneumaticCoupler(short id)
        {
            var epneumaticCoupler = await _context.EpneumaticCoupler.FindAsync(id);
            if (epneumaticCoupler == null)
            {
                return NotFound();
            }

            _context.EpneumaticCoupler.Remove(epneumaticCoupler);
            await _context.SaveChangesAsync();

            return epneumaticCoupler;
        }

        private bool EpneumaticCouplerExists(short id)
        {
            return _context.EpneumaticCoupler.Any(e => e.EpneumaticCouplerId == id);
        }
    }
}
