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
    public class EtimetablePeriodController : ControllerBase
    {
        private readonly DBContext _context;

        public EtimetablePeriodController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtimetablePeriod
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtimetablePeriod>>> GetEtimetablePeriod()
        {
            return await _context.EtimetablePeriod.ToListAsync();
        }

        // GET: api/EtimetablePeriod/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtimetablePeriod>> GetEtimetablePeriod(short id)
        {
            var etimetablePeriod = await _context.EtimetablePeriod.FindAsync(id);

            if (etimetablePeriod == null)
            {
                return NotFound();
            }

            return etimetablePeriod;
        }

        // PUT: api/EtimetablePeriod/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtimetablePeriod(short id, EtimetablePeriod etimetablePeriod)
        {
            if (id != etimetablePeriod.EtimetablePeriodId)
            {
                return BadRequest();
            }

            _context.Entry(etimetablePeriod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtimetablePeriodExists(id))
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

        // POST: api/EtimetablePeriod
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtimetablePeriod>> PostEtimetablePeriod(EtimetablePeriod etimetablePeriod)
        {
            _context.EtimetablePeriod.Add(etimetablePeriod);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtimetablePeriodExists(etimetablePeriod.EtimetablePeriodId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtimetablePeriod", new { id = etimetablePeriod.EtimetablePeriodId }, etimetablePeriod);
        }

        // DELETE: api/EtimetablePeriod/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtimetablePeriod>> DeleteEtimetablePeriod(short id)
        {
            var etimetablePeriod = await _context.EtimetablePeriod.FindAsync(id);
            if (etimetablePeriod == null)
            {
                return NotFound();
            }

            _context.EtimetablePeriod.Remove(etimetablePeriod);
            await _context.SaveChangesAsync();

            return etimetablePeriod;
        }

        private bool EtimetablePeriodExists(short id)
        {
            return _context.EtimetablePeriod.Any(e => e.EtimetablePeriodId == id);
        }
    }
}
