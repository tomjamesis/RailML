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
    public class EmechanicalCouplerController : ControllerBase
    {
        private readonly DBContext _context;

        public EmechanicalCouplerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EmechanicalCoupler
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmechanicalCoupler>>> GetEmechanicalCoupler()
        {
            return await _context.EmechanicalCoupler.ToListAsync();
        }

        // GET: api/EmechanicalCoupler/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmechanicalCoupler>> GetEmechanicalCoupler(short id)
        {
            var emechanicalCoupler = await _context.EmechanicalCoupler.FindAsync(id);

            if (emechanicalCoupler == null)
            {
                return NotFound();
            }

            return emechanicalCoupler;
        }

        // PUT: api/EmechanicalCoupler/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmechanicalCoupler(short id, EmechanicalCoupler emechanicalCoupler)
        {
            if (id != emechanicalCoupler.EmechanicalCouplerId)
            {
                return BadRequest();
            }

            _context.Entry(emechanicalCoupler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmechanicalCouplerExists(id))
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

        // POST: api/EmechanicalCoupler
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EmechanicalCoupler>> PostEmechanicalCoupler(EmechanicalCoupler emechanicalCoupler)
        {
            _context.EmechanicalCoupler.Add(emechanicalCoupler);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmechanicalCouplerExists(emechanicalCoupler.EmechanicalCouplerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmechanicalCoupler", new { id = emechanicalCoupler.EmechanicalCouplerId }, emechanicalCoupler);
        }

        // DELETE: api/EmechanicalCoupler/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmechanicalCoupler>> DeleteEmechanicalCoupler(short id)
        {
            var emechanicalCoupler = await _context.EmechanicalCoupler.FindAsync(id);
            if (emechanicalCoupler == null)
            {
                return NotFound();
            }

            _context.EmechanicalCoupler.Remove(emechanicalCoupler);
            await _context.SaveChangesAsync();

            return emechanicalCoupler;
        }

        private bool EmechanicalCouplerExists(short id)
        {
            return _context.EmechanicalCoupler.Any(e => e.EmechanicalCouplerId == id);
        }
    }
}
