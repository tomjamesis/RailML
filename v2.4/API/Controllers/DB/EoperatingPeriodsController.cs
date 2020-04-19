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
    public class EoperatingPeriodsController : ControllerBase
    {
        private readonly DBContext _context;

        public EoperatingPeriodsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/EoperatingPeriods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EoperatingPeriods>>> GetEoperatingPeriods()
        {
            return await _context.EoperatingPeriods.ToListAsync();
        }

        // GET: api/EoperatingPeriods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EoperatingPeriods>> GetEoperatingPeriods(long id)
        {
            var eoperatingPeriods = await _context.EoperatingPeriods.FindAsync(id);

            if (eoperatingPeriods == null)
            {
                return NotFound();
            }

            return eoperatingPeriods;
        }

        // PUT: api/EoperatingPeriods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEoperatingPeriods(long id, EoperatingPeriods eoperatingPeriods)
        {
            if (id != eoperatingPeriods.EoperatingPeriodsId)
            {
                return BadRequest();
            }

            _context.Entry(eoperatingPeriods).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EoperatingPeriodsExists(id))
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

        // POST: api/EoperatingPeriods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EoperatingPeriods>> PostEoperatingPeriods(EoperatingPeriods eoperatingPeriods)
        {
            _context.EoperatingPeriods.Add(eoperatingPeriods);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EoperatingPeriodsExists(eoperatingPeriods.EoperatingPeriodsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEoperatingPeriods", new { id = eoperatingPeriods.EoperatingPeriodsId }, eoperatingPeriods);
        }

        // DELETE: api/EoperatingPeriods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EoperatingPeriods>> DeleteEoperatingPeriods(long id)
        {
            var eoperatingPeriods = await _context.EoperatingPeriods.FindAsync(id);
            if (eoperatingPeriods == null)
            {
                return NotFound();
            }

            _context.EoperatingPeriods.Remove(eoperatingPeriods);
            await _context.SaveChangesAsync();

            return eoperatingPeriods;
        }

        private bool EoperatingPeriodsExists(long id)
        {
            return _context.EoperatingPeriods.Any(e => e.EoperatingPeriodsId == id);
        }
    }
}
