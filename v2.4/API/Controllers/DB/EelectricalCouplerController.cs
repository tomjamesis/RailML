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
    public class EelectricalCouplerController : ControllerBase
    {
        private readonly DBContext _context;

        public EelectricalCouplerController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EelectricalCoupler
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EelectricalCoupler>>> GetEelectricalCoupler()
        {
            return await _context.EelectricalCoupler.ToListAsync();
        }

        // GET: api/EelectricalCoupler/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EelectricalCoupler>> GetEelectricalCoupler(short id)
        {
            var eelectricalCoupler = await _context.EelectricalCoupler.FindAsync(id);

            if (eelectricalCoupler == null)
            {
                return NotFound();
            }

            return eelectricalCoupler;
        }

        // PUT: api/EelectricalCoupler/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEelectricalCoupler(short id, EelectricalCoupler eelectricalCoupler)
        {
            if (id != eelectricalCoupler.EelectricalCouplerId)
            {
                return BadRequest();
            }

            _context.Entry(eelectricalCoupler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EelectricalCouplerExists(id))
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

        // POST: api/EelectricalCoupler
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EelectricalCoupler>> PostEelectricalCoupler(EelectricalCoupler eelectricalCoupler)
        {
            _context.EelectricalCoupler.Add(eelectricalCoupler);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EelectricalCouplerExists(eelectricalCoupler.EelectricalCouplerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEelectricalCoupler", new { id = eelectricalCoupler.EelectricalCouplerId }, eelectricalCoupler);
        }

        // DELETE: api/EelectricalCoupler/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EelectricalCoupler>> DeleteEelectricalCoupler(short id)
        {
            var eelectricalCoupler = await _context.EelectricalCoupler.FindAsync(id);
            if (eelectricalCoupler == null)
            {
                return NotFound();
            }

            _context.EelectricalCoupler.Remove(eelectricalCoupler);
            await _context.SaveChangesAsync();

            return eelectricalCoupler;
        }

        private bool EelectricalCouplerExists(short id)
        {
            return _context.EelectricalCoupler.Any(e => e.EelectricalCouplerId == id);
        }
    }
}
