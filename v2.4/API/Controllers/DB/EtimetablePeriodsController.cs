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
    public class EtimetablePeriodsController : ControllerBase
    {
        private readonly DBContext _context;

        public EtimetablePeriodsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EtimetablePeriods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EtimetablePeriods>>> GetEtimetablePeriods()
        {
            return await _context.EtimetablePeriods.ToListAsync();
        }

        // GET: api/EtimetablePeriods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EtimetablePeriods>> GetEtimetablePeriods(long id)
        {
            var etimetablePeriods = await _context.EtimetablePeriods.FindAsync(id);

            if (etimetablePeriods == null)
            {
                return NotFound();
            }

            return etimetablePeriods;
        }

        // PUT: api/EtimetablePeriods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEtimetablePeriods(long id, EtimetablePeriods etimetablePeriods)
        {
            if (id != etimetablePeriods.EtimetablePeriodsId)
            {
                return BadRequest();
            }

            _context.Entry(etimetablePeriods).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtimetablePeriodsExists(id))
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

        // POST: api/EtimetablePeriods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EtimetablePeriods>> PostEtimetablePeriods(EtimetablePeriods etimetablePeriods)
        {
            _context.EtimetablePeriods.Add(etimetablePeriods);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EtimetablePeriodsExists(etimetablePeriods.EtimetablePeriodsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEtimetablePeriods", new { id = etimetablePeriods.EtimetablePeriodsId }, etimetablePeriods);
        }

        // DELETE: api/EtimetablePeriods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EtimetablePeriods>> DeleteEtimetablePeriods(long id)
        {
            var etimetablePeriods = await _context.EtimetablePeriods.FindAsync(id);
            if (etimetablePeriods == null)
            {
                return NotFound();
            }

            _context.EtimetablePeriods.Remove(etimetablePeriods);
            await _context.SaveChangesAsync();

            return etimetablePeriods;
        }

        private bool EtimetablePeriodsExists(long id)
        {
            return _context.EtimetablePeriods.Any(e => e.EtimetablePeriodsId == id);
        }
    }
}
